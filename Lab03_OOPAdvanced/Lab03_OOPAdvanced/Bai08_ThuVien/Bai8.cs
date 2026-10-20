
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab03_OOPAdvanced.Bai08
{
    public abstract class TaiLieu
    {
        public string MaTaiLieu { get; set; }
        public string TieuDe { get; set; }

        protected TaiLieu(string ma, string tieuDe)
        {
            MaTaiLieu = ma;
            TieuDe = tieuDe;
        }

        public abstract string LoaiTaiLieu();

        public virtual string ThongTin()
        {
            return $"{MaTaiLieu} - {TieuDe} - {LoaiTaiLieu()}";
        }
    }

    public class Sach : TaiLieu
    {
        public string TacGia { get; set; }

        public Sach(string ma, string ten, string tacGia)
            : base(ma, ten)
        {
            TacGia = tacGia;
        }

        public override string LoaiTaiLieu() => "Sach";

        public override string ThongTin()
        {
            return $"{base.ThongTin()} - Tac gia: {TacGia}";
        }
    }

    public class TapChi : TaiLieu
    {
        public int SoPhatHanh { get; set; }

        public TapChi(string ma, string ten, int so)
            : base(ma, ten)
        {
            SoPhatHanh = so;
        }

        public override string LoaiTaiLieu() => "Tap chi";

        public override string ThongTin()
        {
            return $"{base.ThongTin()} - So: {SoPhatHanh}";
        }
    }

    public class LuanVan : TaiLieu
    {
        public string TacGia { get; set; }
        public string Nganh { get; set; }

        public LuanVan(string ma, string ten, string tacGia, string nganh)
            : base(ma, ten)
        {
            TacGia = tacGia;
            Nganh = nganh;
        }

        public override string LoaiTaiLieu() => "Luan van";

        public override string ThongTin()
        {
            return $"{base.ThongTin()} - Tac gia: {TacGia} - Nganh: {Nganh}";
        }
    }

    public static class Demo
    {
        public static void Run()
        {
            Console.WriteLine("\n=== BAI 8 ===");

            List<TaiLieu> ds = new List<TaiLieu>
            {
                new Sach("TL01", "Lap trinh C#", "Nguyen An"),
                new TapChi("TL02", "Cong nghe", 12),
                new LuanVan("TL03", "Ung dung AI", "Tran Binh", "CNTT")
            };

            Console.WriteLine("Danh sach tai lieu:");
            foreach (TaiLieu tl in ds)
                Console.WriteLine(tl.ThongTin());

            string tuKhoa = "AI";
            Console.WriteLine($"\nTim kiem: {tuKhoa}");

            var ketQua = ds.Where(tl =>
      tl.TieuDe.IndexOf(
          tuKhoa,
          StringComparison.OrdinalIgnoreCase) >= 0);

            foreach (TaiLieu tl in ketQua)
                Console.WriteLine(tl.ThongTin());
        }
    }
}
