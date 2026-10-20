
using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced.Bai06
{
    public abstract class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }

        protected NhanVien(string ma, string ten)
        {
            MaNV = ma;
            HoTen = ten;
        }

        public abstract decimal TinhLuong();

        public virtual void HienThi()
        {
            Console.WriteLine(
                $"{MaNV} - {HoTen} - Luong: {TinhLuong():N0} VND");
        }
    }

    public class NhanVienVanPhong : NhanVien
    {
        public decimal LuongCoBan { get; set; }
        public decimal PhuCap { get; set; }

        public NhanVienVanPhong(string ma, string ten,
            decimal luong, decimal phuCap) : base(ma, ten)
        {
            LuongCoBan = luong;
            PhuCap = phuCap;
        }

        public override decimal TinhLuong()
        {
            return LuongCoBan + PhuCap;
        }
    }

    public class NhanVienKinhDoanh : NhanVien
    {
        public decimal LuongCoBan { get; set; }
        public decimal DoanhSo { get; set; }
        public decimal TyLeHoaHong { get; set; }

        public NhanVienKinhDoanh(string ma, string ten,
            decimal luong, decimal doanhSo, decimal tyLe)
            : base(ma, ten)
        {
            LuongCoBan = luong;
            DoanhSo = doanhSo;
            TyLeHoaHong = tyLe;
        }

        public override decimal TinhLuong()
        {
            return LuongCoBan + DoanhSo * TyLeHoaHong;
        }
    }

    public class GiangVien : NhanVien
    {
        public int SoTietDay { get; set; }
        public decimal TienMoiTiet { get; set; }

        public GiangVien(string ma, string ten,
            int soTiet, decimal tienMoiTiet) : base(ma, ten)
        {
            SoTietDay = soTiet;
            TienMoiTiet = tienMoiTiet;
        }

        public override decimal TinhLuong()
        {
            return SoTietDay * TienMoiTiet;
        }
    }

    public static class Demo
    {
        public static void Run()
        {
            Console.WriteLine("\n=== BAI 6 ===");

            List<NhanVien> ds = new List<NhanVien>
            {
                new NhanVienVanPhong("NV01", "An", 8000000m, 1000000m),
                new NhanVienKinhDoanh("NV02", "Binh",
                    6000000m, 100000000m, 0.05m),
                new GiangVien("GV01", "Cuong", 40, 200000m)
            };

            foreach (NhanVien nv in ds)
                nv.HienThi();
        }
    }
}
