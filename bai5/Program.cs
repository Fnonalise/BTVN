using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StudentManager
{
    // Chỉ cho phép 3 khóa học
    enum CourseName { Java, DotNet, CCPP }

    // Thực thể sinh viên
    class Student
    {
        public string Name { get; set; } = "";
        public int Semester { get; set; }
        public CourseName Course { get; set; }

        public override string ToString()
            => $"{Name} | Semester {Semester} | {CourseToText(Course)}";

        public static string CourseToText(CourseName c)
            => c switch { CourseName.Java => "Java", CourseName.DotNet => ".Net", _ => "C/C++" };

        public static bool TryParseCourse(string s, out CourseName course)
        {
            s = (s ?? "").Trim().ToLower(CultureInfo.InvariantCulture);
            switch (s)
            {
                case "java": course = CourseName.Java; return true;
                case ".net":
                case "dotnet":
                case "net": course = CourseName.DotNet; return true;
                case "c/c++":
                case "c++":
                case "ccpp": course = CourseName.CCPP; return true;
                default: course = CourseName.Java; return false;
            }
        }
    }

    // Đọc/ghi tệp
    class StudentRepository
    {
        public string Path { get; }

        public StudentRepository(string path) => Path = path;

        public List<Student> Load()
        {
            var list = new List<Student>();
            if (!File.Exists(Path)) return list;

            foreach (var line in File.ReadAllLines(Path))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split('|');
                if (parts.Length != 3) continue;

                string name = parts[0].Trim();
                if (!int.TryParse(parts[1].Trim(), out int sem) || sem < 1) continue;

                if (!Student.TryParseCourse(parts[2], out var course)) continue;

                list.Add(new Student { Name = name, Semester = sem, Course = course });
            }
            return list;
        }

        public void Save(List<Student> students)
        {
            var lines = students.Select(s => $"{s.Name}|{s.Semester}|{Student.CourseToText(s.Course)}");
            File.WriteAllLines(Path, lines);
        }
    }

    // Nghiệp vụ: tìm kiếm, sửa, xóa, thống kê
    class StudentService
    {
        private readonly StudentRepository _repo;
        private readonly List<Student> _students;

        public StudentService(StudentRepository repo)
        {
            _repo = repo;
            _students = _repo.Load();
        }

        public IReadOnlyList<Student> All => _students;

        public List<int> SearchByName(string keyword)
        {
            keyword = (keyword ?? "").Trim().ToLower();
            var idxs = new List<int>();
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].Name.ToLower().Contains(keyword))
                    idxs.Add(i);
            }
            return idxs;
        }

        public bool Edit(int index, string? name, int? semester, CourseName? course)
        {
            if (index < 0 || index >= _students.Count) return false;
            if (!string.IsNullOrWhiteSpace(name)) _students[index].Name = name.Trim();
            if (semester.HasValue && semester.Value >= 1) _students[index].Semester = semester.Value;
            if (course.HasValue) _students[index].Course = course.Value;
            return true;
        }

        public bool Delete(int index)
        {
            if (index < 0 || index >= _students.Count) return false;
            _students.RemoveAt(index);
            return true;
        }

        // Thống kê: Student Name | Course | Total of Course
        public IEnumerable<(string Name, string Course, int Count)> Stats()
        {
            return _students
                .GroupBy(s => new { s.Name, s.Course })
                .OrderBy(g => g.Key.Name)
                .ThenBy(g => g.Key.Course)
                .Select(g => (g.Key.Name, Student.CourseToText(g.Key.Course), g.Count()));
        }

        public void Save() => _repo.Save(_students);
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "StudentList.txt"; // đổi nếu bạn dùng tên khác
            var repo = new StudentRepository(filePath);
            var svc = new StudentService(repo);

            while (true)
            {
                Console.WriteLine("\n=== QUAN LY SINH VIEN ===");
                Console.WriteLine("1. Xem danh sach");
                Console.WriteLine("2. Tim kiem theo name");
                Console.WriteLine("3. Sua thong tin");
                Console.WriteLine("4. Xoa sinh vien");
                Console.WriteLine("5. Thong ke so lan dang ky (Name | Course | Total)");
                Console.WriteLine("6. Luu va thoat");
                Console.Write("Chon (1-6): ");

                var choice = Console.ReadLine()?.Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    if (svc.All.Count == 0) Console.WriteLine("Danh sach rong.");
                    else
                    {
                        for (int i = 0; i < svc.All.Count; i++)
                            Console.WriteLine($"[{i}] {svc.All[i]}");
                    }
                }
                else if (choice == "2")
                {
                    Console.Write("Nhap tu khoa ten: ");
                    string kw = Console.ReadLine() ?? "";
                    var idxs = svc.SearchByName(kw);
                    if (idxs.Count == 0) Console.WriteLine("Khong tim thay.");
                    else
                    {
                        foreach (var idx in idxs)
                            Console.WriteLine($"[{idx}] {svc.All[idx]}");
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("Nhap index sinh vien can sua: ");
                    if (!int.TryParse(Console.ReadLine(), out int idx))
                    {
                        Console.WriteLine("Index khong hop le."); continue;
                    }
                    if (idx < 0 || idx >= svc.All.Count)
                    {
                        Console.WriteLine("Index ngoai pham vi."); continue;
                    }

                    Console.WriteLine($"Hien tai: {svc.All[idx]}");
                    Console.Write("Nhap ten moi (bo trong = giu nguyen): ");
                    string name = Console.ReadLine() ?? "";

                    Console.Write("Nhap hoc ky moi (>=1, bo trong = giu nguyen): ");
                    string semStr = Console.ReadLine() ?? "";
                    int? sem = null;
                    if (!string.IsNullOrWhiteSpace(semStr) && int.TryParse(semStr, out int s) && s >= 1) sem = s;

                    Console.Write("Nhap khoa hoc moi (Java/.Net/C/C++; bo trong = giu nguyen): ");
                    string courseStr = Console.ReadLine() ?? "";
                    CourseName? course = null;
                    if (!string.IsNullOrWhiteSpace(courseStr) && Student.TryParseCourse(courseStr, out var c)) course = c;

                    if (svc.Edit(idx, string.IsNullOrWhiteSpace(name) ? null : name, sem, course))
                        Console.WriteLine("Da cap nhat.");
                    else
                        Console.WriteLine("Sua that bai.");
                }
                else if (choice == "4")
                {
                    Console.Write("Nhap index sinh vien can xoa: ");
                    if (!int.TryParse(Console.ReadLine(), out int idx))
                    { Console.WriteLine("Index khong hop le."); continue; }

                    if (svc.Delete(idx)) Console.WriteLine("Da xoa.");
                    else Console.WriteLine("Xoa that bai.");
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Student Name | Course | Total of Course");
                    foreach (var row in svc.Stats())
                        Console.WriteLine($"{row.Name} | {row.Course} | {row.Count}");
                }
                else if (choice == "6")
                {
                    svc.Save();
                    Console.WriteLine($"Da luu vao: {filePath}");
                    break;
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le.");
                }
            }
        }
    }
}
