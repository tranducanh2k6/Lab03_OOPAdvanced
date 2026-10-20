
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab03_OOPAdvanced.Bai10
{
    public interface IExportable
    {
        string XuatDuLieu();
    }

    public abstract class SinhVien : IExportable
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }

        protected SinhVien(string ma, string ten, double diem)
        {
            MaSV = ma;
            HoTen = ten;
            DiemTB = diem;
        }

        public abstract string LoaiSinhVien();

        public virtual string XuatDuLieu()
        {
            return $"{MaSV} - {HoTen} - {DiemTB:N2} - {LoaiSinhVien()}";
        }
    }

    public class SinhVienChinhQuy : SinhVien
    {
        public SinhVienChinhQuy(string ma, string ten, double diem)
            : base(ma, ten, diem) { }

        public override string LoaiSinhVien() => "Chinh quy";
    }

    public class SinhVienLienThong : SinhVien
    {
        public SinhVienLienThong(string ma, string ten, double diem)
            : base(ma, ten, diem) { }

        public override string LoaiSinhVien() => "Lien thong";
    }

    public class SinhVienQuocTe : SinhVien
    {
        public SinhVienQuocTe(string ma, string ten, double diem)
            : base(ma, ten, diem) { }

        public override string LoaiSinhVien() => "Quoc te";
    }

    public static class Demo
    {
        public static void Run()
        {
            Console.WriteLine("\n=== BAI 10 ===");

            List<SinhVien> ds = new List<SinhVien>
            {
                new SinhVienChinhQuy("SV01", "An", 8.5),
                new SinhVienLienThong("SV02", "Binh", 7.0),
                new SinhVienChinhQuy("SV03", "Cuong", 9.0),
                new SinhVienQuocTe("SV04", "Dung", 8.0),
                new SinhVienLienThong("SV05", "Ha", 6.5)
            };

            Console.WriteLine("DANH SACH SINH VIEN");
            foreach (SinhVien sv in ds)
                Console.WriteLine(sv.XuatDuLieu());

            string tuKhoa = "SV02";
            Console.WriteLine($"\nTim kiem ma: {tuKhoa}");

            var ketQua = ds.Where(sv =>
    sv.MaSV.IndexOf(
        tuKhoa,
        StringComparison.OrdinalIgnoreCase) >= 0);

            foreach (SinhVien sv in ketQua)
                Console.WriteLine(sv.XuatDuLieu());

            Console.WriteLine("\nTHONG KE THEO LOAI");
            var thongKe = ds.GroupBy(sv => sv.LoaiSinhVien());

            foreach (var nhom in thongKe)
            {
                Console.WriteLine(
                    $"{nhom.Key}: {nhom.Count()} sinh vien");
            }

            Console.WriteLine(
                $"\nDiem trung binh ca danh sach: {ds.Average(sv => sv.DiemTB):N2}");
        }
    }
}
