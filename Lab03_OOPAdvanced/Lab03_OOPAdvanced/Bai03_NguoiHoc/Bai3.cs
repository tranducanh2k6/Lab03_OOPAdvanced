
using System;

namespace Lab03_OOPAdvanced.Bai03
{
    public abstract class NguoiHoc
    {
        public string HoTen { get; set; }
        public int SoTinChi { get; set; }

        protected NguoiHoc(string hoTen, int soTinChi)
        {
            HoTen = hoTen;
            SoTinChi = soTinChi;
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
            Console.WriteLine("\n=== BAI 3 ===");

            NguoiHoc sv1 = new SinhVienChinhQuy("An", 18);
            NguoiHoc sv2 = new SinhVienLienThong("Binh", 15);

            Console.WriteLine(
                $"{sv1.HoTen}: {sv1.TinhHocPhi():N0} VND");
            Console.WriteLine(
                $"{sv2.HoTen}: {sv2.TinhHocPhi():N0} VND");
        }
    }
}
