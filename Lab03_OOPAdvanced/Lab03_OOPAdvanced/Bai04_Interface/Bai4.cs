
using System;

namespace Lab03_OOPAdvanced.Bai04
{
    public interface IValidatable
    {
        bool IsValid(out string message);
    }

    public interface IPrintable
    {
        string ToDisplayText();
    }

    public class SinhVien : IValidatable, IPrintable
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }

        public SinhVien(string ma, string ten, double diem)
        {
            MaSV = ma;
            HoTen = ten;
            DiemTB = diem;
        }

        public bool IsValid(out string message)
        {
            if (string.IsNullOrWhiteSpace(MaSV))
            {
                message = "Thieu ma sinh vien";
                return false;
            }

            if (string.IsNullOrWhiteSpace(HoTen))
            {
                message = "Thieu ho ten";
                return false;
            }

            if (DiemTB < 0 || DiemTB > 10)
            {
                message = "Diem phai tu 0 den 10";
                return false;
            }

            message = "Du lieu hop le";
            return true;
        }

        public string ToDisplayText()
        {
            return $"{MaSV} - {HoTen} - {DiemTB:N2}";
        }
    }

    public static class Demo
    {
        public static void Run()
        {
            Console.WriteLine("\n=== BAI 4 ===");

            SinhVien sv = new SinhVien("SV004", "Pham Minh Duc", 8.5);

            bool hopLe = sv.IsValid(out string thongBao);
            Console.WriteLine(thongBao);

            if (hopLe)
                Console.WriteLine(sv.ToDisplayText());

            SinhVien svSai = new SinhVien("", "Nguyen Van A", 12);
            svSai.IsValid(out string loi);
            Console.WriteLine("Kiem tra du lieu sai: " + loi);
        }
    }
}
