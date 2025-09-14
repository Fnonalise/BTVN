using System;

namespace TimKiemSapXep
{
    public class ArrayProcessor
    {
        private int[] mang = Array.Empty<int>();

        // ===== Nhap / Hien thi =====
        public void Nhap()
        {
            int n = DocInt("Nhap so luong phan tu n = ", min: 1);
            mang = new int[n];
            for (int i = 0; i < n; i++)
                mang[i] = DocInt($"mang[{i}] = ");
        }

        public void HienThi(string tieude = "Mang")
        {
            Console.Write($"{tieude} ({mang.Length} phan tu): ");
            for (int i = 0; i < mang.Length; i++)
                Console.Write(mang[i] + (i + 1 == mang.Length ? "" : " "));
            Console.WriteLine();
        }

        // ===== Bubble Sort (Noi bot, tang dan) =====
        public int[] SapXepNoiBotCopy()
        {
            int[] a = (int[])mang.Clone();
            for (int i = 0; i < a.Length - 1; i++)
            {
                bool doi = false;
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        (a[j], a[j + 1]) = (a[j + 1], a[j]);
                        doi = true;
                    }
                }
                if (!doi) break; // da sap xep
            }
            return a;
        }

        // ===== Quick Sort (tang dan) tren copy =====
        public int[] QuickSortCopy()
        {
            int[] a = (int[])mang.Clone();
            QuickSort(a, 0, a.Length - 1);
            return a;
        }

        private static void QuickSort(int[] a, int left, int right)
        {
            if (left >= right) return;
            int i = left, j = right;
            int pivot = a[(left + right) / 2];

            while (i <= j)
            {
                while (a[i] < pivot) i++;
                while (a[j] > pivot) j--;
                if (i <= j)
                {
                    (a[i], a[j]) = (a[j], a[i]);
                    i++; j--;
                }
            }
            if (left < j) QuickSort(a, left, j);
            if (i < right) QuickSort(a, i, right);
        }

        // ===== Linear Search: tra ve vi tri dau tien, -1 neu khong thay =====
        public int TimTuyenTinh(int key)
        {
            for (int i = 0; i < mang.Length; i++)
                if (mang[i] == key) return i;
            return -1;
        }

        // ===== Binary Search tren mang DA SAP XEP (truyen mang da sap xep vao) =====
        public static int TimNhiPhan(int[] daSapXep, int key)
        {
            int l = 0, r = daSapXep.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (daSapXep[mid] == key) return mid;
                if (daSapXep[mid] < key) l = mid + 1;
                else r = mid - 1;
            }
            return -1;
        }

        // ===== Helper doc so nguyen =====
        private static int DocInt(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                Console.Write(prompt);
                string s = Console.ReadLine() ?? "";
                if (int.TryParse(s, out int v) && v >= min && v <= max) return v;
                Console.WriteLine(" -> Vui long nhap so nguyen hop le!");
            }
        }
    }

    // ================= Chuong trinh chinh =================
    class Program
    {
        static void Main()
        {
            var xuLy = new ArrayProcessor();

            // 1) Nhap va in mang ban dau
            xuLy.Nhap();
            xuLy.HienThi("Mang ban dau");

            // 2) Sap xep bang Bubble Sort
            int[] bubble = xuLy.SapXepNoiBotCopy();
            InMang(bubble, "Mang sau Bubble Sort (tang dan)");

            // 3) Sap xep bang Quick Sort
            int[] quick = xuLy.QuickSortCopy();
            InMang(quick, "Mang sau Quick Sort (tang dan)");

            // 4) Tim kiem
            Console.WriteLine("\n=== Tim kiem ===");
            Console.Write("Nhap gia tri can tim = ");
            int key = int.Parse(Console.ReadLine() ?? "0");

            int idxLinear = xuLy.TimTuyenTinh(key);
            Console.WriteLine(idxLinear >= 0
                ? $"Linear Search: thay {key} tai vi tri {idxLinear} (theo mang goc)."
                : $"Linear Search: khong thay {key} trong mang goc.");

            int idxBinary = ArrayProcessor.TimNhiPhan(quick, key);
            Console.WriteLine(idxBinary >= 0
                ? $"Binary Search: thay {key} tai vi tri {idxBinary} (theo mang da Quick Sort)."
                : $"Binary Search: khong thay {key} trong mang da sap xep.");
        }

        static void InMang(int[] a, string tieude)
        {
            Console.Write($"{tieude}: ");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + (i + 1 == a.Length ? "" : " "));
            Console.WriteLine();
        }
    }
}
