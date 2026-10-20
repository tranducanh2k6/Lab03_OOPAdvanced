
using System;

namespace Lab03_OOPAdvanced.Bai01
{
    public class Nguoi
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }

        public Nguoi(string hoTen, DateTime ngaySinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }
    }

    public class SinhVien : Nguoi
    {
        public string MaSV { get; set; }
        public double DiemTB { get; set; }

        public SinhVien(string ma, string ten,
            DateTime ngaySinh, double diem)
            : base(ten, ngaySinh)
        {
            MaSV = ma;
            DiemTB = diem;
        }

        public void HienThi()
        {
            Console.WriteLine(
                $"{MaSV} - {HoTen} - {NgaySinh:dd/MM/yyyy} - {DiemTB:N2}");
        }
    }

    public static class Demo
    {
        public static void Run()
        {
            Console.WriteLine("\n=== BAI 1 ===");

            SinhVien sv = new SinhVien(
                "SV001", "Nguyen Van An",
                new DateTime(2006, 5, 10), 8.5);

            sv.HienThi();
        }
    }
}
