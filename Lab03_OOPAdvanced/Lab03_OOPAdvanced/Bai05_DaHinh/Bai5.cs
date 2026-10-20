
using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced.Bai05
{
    public abstract class NguoiHoc
    {
        public string HoTen { get; set; }
        public int SoTinChi { get; set; }

        protected NguoiHoc(string ten, int tinChi)
        {
            HoTen = ten;
            SoTinChi = tinChi;
        }

        public abstract decimal TinhHocPhi();
    }

    public class SinhVienChinhQuy : NguoiHoc
    {
        public SinhVienChinhQuy(string ten, int tinChi)
            : base(ten, tinChi) { }

        public override decimal TinhHocPhi()
        {
            return SoTinChi * 450000m;
        }
    }

    public class SinhVienLienThong : NguoiHoc
    {
        public SinhVienLienThong(string ten, int tinChi)
            : base(ten, tinChi) { }

        public override decimal TinhHocPhi()
        {
            return SoTinChi * 520000m;
        }
    }

    public static class Demo
    {
        public static void Run()
        {
            Console.WriteLine("\n=== BAI 5 ===");

            List<NguoiHoc> ds = new List<NguoiHoc>
            {
                new SinhVienChinhQuy("An", 18),
                new SinhVienLienThong("Binh", 15),
                new SinhVienChinhQuy("Cuong", 20)
            };

            decimal tong = 0;

            foreach (NguoiHoc item in ds)
            {
                decimal hocPhi = item.TinhHocPhi();
                tong += hocPhi;

                Console.WriteLine(
                    $"{item.HoTen}: {hocPhi:N0} VND");
            }

            Console.WriteLine($"Tong hoc phi: {tong:N0} VND");
        }
    }
}
