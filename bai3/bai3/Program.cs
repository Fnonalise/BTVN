using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace XuLyVanBan
{
    public class TextProcessor
    {
        // 1) CHUAN HOA: xoa khoang trang thua + viet hoa ky tu dau moi cau
        public string ChuanHoa(string vanban)
        {
            if (string.IsNullOrWhiteSpace(vanban)) return string.Empty;

            // chuyen het ve dang chuan khoang trang: 1 space giua cac tu, xoa space dau/cuoi
            string s = Regex.Replace(vanban, @"\s+", " ").Trim();

            // viet hoa ky tu dau moi cau (sau . ! ?)
            var sb = new StringBuilder(s.Length);
            bool vietHoa = true; // dau doan la viet hoa

            foreach (char ch in s)
            {
                if (vietHoa && char.IsLetter(ch))
                {
                    sb.Append(char.ToUpper(ch));
                    vietHoa = false;
                }
                else
                {
                    sb.Append(ch);
                }

                if (ch == '.' || ch == '!' || ch == '?')
                    vietHoa = true;        // sau dau ket thuc cau -> ky tu chu tiep theo se viet hoa
                else if (!char.IsWhiteSpace(ch) && ch != '.' && ch != '!' && ch != '?')
                    ; // giu nguyen
            }
            return sb.ToString();
        }

        // 2) Tach tu (khong phan biet hoa/thuong)
        // Lay cac cum chu/cac so lam "tu"
        private static List<string> TachTu(string vanban)
        {
            var words = new List<string>();
            foreach (Match m in Regex.Matches(vanban, @"\p{L}+|\d+"))
            {
                words.Add(m.Value.ToLowerInvariant());
            }
            return words;
        }

        public int DemTongSoTu(string vanban)
        {
            return TachTu(vanban).Count;
        }

        public int DemSoTuKhacNhau(string vanban)
        {
            return TachTu(vanban).Distinct().Count();
        }

        public Dictionary<string, int> TanSuatTu(string vanban)
        {
            var kq = new Dictionary<string, int>();
            foreach (var w in TachTu(vanban))
            {
                if (kq.ContainsKey(w)) kq[w]++;
                else kq[w] = 1;
            }
            return kq;
        }
    }

    class ChuongTrinh
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhap doan van ban (nhap mot dong rong de ket thuc):");
            var lines = new List<string>();
            while (true)
            {
                string line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line)) break;
                lines.Add(line);
            }
            string vanban = string.Join(" ", lines);

            var tp = new TextProcessor();

            // 1) Chuan hoa
            string chuan = tp.ChuanHoa(vanban);

            // 2) Thong ke
            int tongTu = tp.DemTongSoTu(chuan);
            int soTuKhac = tp.DemSoTuKhacNhau(chuan);
            var tansuat = tp.TanSuatTu(chuan)
                           .OrderByDescending(p => p.Value)
                           .ThenBy(p => p.Key)
                           .ToList();

            // 3) Hien thi ket qua
            Console.WriteLine("\n=== VAN BAN DA CHUAN HOA ===");
            Console.WriteLine(chuan);

            Console.WriteLine("\n=== THONG KE ===");
            Console.WriteLine($"Tong so tu: {tongTu}");
            Console.WriteLine($"So tu khac nhau: {soTuKhac}");

            Console.WriteLine("\nBang tan suat (khong phan biet hoa/thuong):");
            Console.WriteLine($"{"Tu",-20}{"So lan",6}");
            Console.WriteLine(new string('-', 26));
            foreach (var (tu, sl) in tansuat)
                Console.WriteLine($"{tu,-20}{sl,6}");
        }
    }
}
