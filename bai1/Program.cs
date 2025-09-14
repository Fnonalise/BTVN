using System;
using System.Globalization;

namespace XuLyMaTran
{
    public class MaTran
    {
        private readonly double[,] dulieu;

        public int SoDong { get; }
        public int SoCot { get; }

        public bool LaVuong => SoDong == SoCot;

        public MaTran(int m, int n)
        {
            if (m <= 0 || n <= 0) throw new ArgumentException("Kich thuoc phai > 0.");
            SoDong = m; SoCot = n;
            dulieu = new double[m, n];
        }

        public double this[int i, int j]
        {
            get => dulieu[i, j];
            set => dulieu[i, j] = value;
        }

        // ==== Nhap & In ====
        public static MaTran Nhap(string ten = "A")
        {
            Console.WriteLine($"--- Nhap ma tran {ten} ---");
            int m = DocSoNguyen("So dong m = ", 1);
            int n = DocSoNguyen("So cot  n = ", 1);

            var M = new MaTran(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    M[i, j] = DocSoThuc($"[{i},{j}] = ");
                }
            }
            return M;
        }

        public void In(string tieude = "Ma tran")
        {
            Console.WriteLine($"--- {tieude} ({SoDong}x{SoCot}) ---");
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                    Console.Write($"{dulieu[i, j],10:0.###} ");
                Console.WriteLine();
            }
        }

        // ==== Cong ====
        public MaTran Cong(MaTran B)
        {
            if (SoDong != B.SoDong || SoCot != B.SoCot)
                throw new InvalidOperationException("Hai ma tran phai cung kich thuoc de cong.");

            var C = new MaTran(SoDong, SoCot);
            for (int i = 0; i < SoDong; i++)
                for (int j = 0; j < SoCot; j++)
                    C[i, j] = this[i, j] + B[i, j];
            return C;
        }

        // ==== Nhan ====
        public MaTran Nhan(MaTran B)
        {
            if (SoCot != B.SoDong)
                throw new InvalidOperationException("So cot cua A phai bang so dong cua B de nhan.");

            var C = new MaTran(SoDong, B.SoCot);
            for (int i = 0; i < SoDong; i++)
                for (int k = 0; k < SoCot; k++)
                {
                    double aik = this[i, k];
                    for (int j = 0; j < B.SoCot; j++)
                        C[i, j] += aik * B[k, j];
                }
            return C;
        }

        // ==== Chuyen vi ====
        public MaTran ChuyenVi()
        {
            var T = new MaTran(SoCot, SoDong);
            for (int i = 0; i < SoDong; i++)
                for (int j = 0; j < SoCot; j++)
                    T[j, i] = this[i, j];
            return T;
        }

        // ==== Max / Min ====
        public (double lonnhat, double nhonhat) TimMaxMin()
        {
            double max = this[0, 0], min = this[0, 0];
            for (int i = 0; i < SoDong; i++)
                for (int j = 0; j < SoCot; j++)
                {
                    double v = this[i, j];
                    if (v > max) max = v;
                    if (v < min) min = v;
                }
            return (max, min);
        }

        // ==== Dinh thuc ====
        public double DinhThuc()
        {
            if (!LaVuong) throw new InvalidOperationException("Chi tinh dinh thuc cho ma tran vuong.");

            double[,] a = (double[,])dulieu.Clone();
            int n = SoDong;
            double det = 1.0;

            for (int col = 0; col < n; col++)
            {
                int pivot = col;
                for (int r = col + 1; r < n; r++)
                    if (Math.Abs(a[r, col]) > Math.Abs(a[pivot, col])) pivot = r;

                if (Math.Abs(a[pivot, col]) < 1e-12) return 0.0;

                if (pivot != col)
                {
                    HoanDoiDong(a, pivot, col);
                    det = -det;
                }

                det *= a[col, col];

                for (int r = col + 1; r < n; r++)
                {
                    double hs = a[r, col] / a[col, col];
                    for (int c = col; c < n; c++)
                        a[r, c] -= hs * a[col, c];
                }
            }
            return det;
        }

        private static void HoanDoiDong(double[,] a, int r1, int r2)
        {
            int n = a.GetLength(1);
            for (int c = 0; c < n; c++)
                (a[r1, c], a[r2, c]) = (a[r2, c], a[r1, c]);
        }

        // ==== Doi xung ====
        public bool LaDoiXung()
        {
            if (!LaVuong) return false;
            for (int i = 0; i < SoDong; i++)
                for (int j = i + 1; j < SoCot; j++)
                    if (Math.Abs(this[i, j] - this[j, i]) > 1e-9) return false;
            return true;
        }

        // ==== Ham nhap lieu ====
        private static int DocSoNguyen(string tb, int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                Console.Write(tb);
                var s = Console.ReadLine();
                if (int.TryParse(s, out int v) && v >= min && v <= max) return v;
                Console.WriteLine(" -> Nhap so nguyen hop le!");
            }
        }

        private static double DocSoThuc(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                var s = Console.ReadLine();
                if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double v) ||
                    double.TryParse(s, NumberStyles.Float, CultureInfo.CurrentCulture, out v))
                    return v;
                Console.WriteLine(" -> Nhap so thuc hop le!");
            }
        }
    }

    class ChuongTrinh
    {
        static void Main()
        {
            MaTran A = null, B = null;

            while (true)
            {
                Console.WriteLine("\n===== MENU MA TRAN =====");
                Console.WriteLine("1. Nhap va hien thi ma tran");
                Console.WriteLine("2. Cong hai ma tran A + B");
                Console.WriteLine("3. Nhan hai ma tran A x B");
                Console.WriteLine("4. Chuyen vi ma tran A");
                Console.WriteLine("5. Tim gia tri lon nhat va nho nhat cua A");
                Console.WriteLine("6. Dinh thuc & kiem tra doi xung cua A");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon: ");

                string chon = Console.ReadLine()?.Trim() ?? "";
                Console.WriteLine();

                try
                {
                    switch (chon)
                    {
                        case "1":
                            A = MaTran.Nhap("A");
                            A.In("A");
                            Console.WriteLine();
                            B = MaTran.Nhap("B");
                            B.In("B");
                            break;

                        case "2":
                            if (A == null || B == null) throw new Exception("Hay nhap A va B truoc.");
                            var C = A.Cong(B);
                            C.In("A + B");
                            break;

                        case "3":
                            if (A == null || B == null) throw new Exception("Hay nhap A va B truoc.");
                            var P = A.Nhan(B);
                            P.In("A x B");
                            break;

                        case "4":
                            if (A == null) throw new Exception("Hay nhap A truoc.");
                            var AT = A.ChuyenVi();
                            AT.In("A^T");
                            break;

                        case "5":
                            if (A == null) throw new Exception("Hay nhap A truoc.");
                            var (max, min) = A.TimMaxMin();
                            Console.WriteLine($"Max(A) = {max}, Min(A) = {min}");
                            break;

                        case "6":
                            if (A == null) throw new Exception("Hay nhap A truoc.");
                            if (!A.LaVuong)
                                Console.WriteLine("A khong vuong.");
                            else
                            {
                                Console.WriteLine($"det(A) = {A.DinhThuc()}");
                                Console.WriteLine($"A {(A.LaDoiXung() ? "" : "khong ")}doi xung.");
                            }
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("Lua chon khong hop le!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Loi: " + ex.Message);
                }
            }
        }
    }
}
