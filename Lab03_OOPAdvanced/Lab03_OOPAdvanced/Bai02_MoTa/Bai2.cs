
using System;

namespace Lab03_OOPAdvanced.Bai02
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

        public virtual string MoTa()
        {
            return $"{HoTen} - {NgaySinh:dd/MM/yyyy}";
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

        public override string MoTa()
        {
            return $"{base.MoTa()} - {MaSV} - {DiemTB:N2}";
        }
    }

    public static class Demo
    {
        public static void Run()
        {
            Console.WriteLine("\n=== BAI 2 ===");

            Nguoi nguoi = new Nguoi(
                "Tran Van Binh", new DateTime(2005, 3, 15));

            SinhVien sv = new SinhVien(
                "SV002", "Le Thi Hoa",
                new DateTime(2006, 8, 20), 9.2);

            Console.WriteLine(nguoi.MoTa());
            Console.WriteLine(sv.MoTa());
        }
    }
}
