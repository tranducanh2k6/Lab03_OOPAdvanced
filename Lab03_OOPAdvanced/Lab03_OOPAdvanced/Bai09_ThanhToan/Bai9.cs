
using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced.Bai09
{
    public interface IPayment
    {
        bool ThanhToan(decimal soTien, out string thongBao);
    }

    public class ThanhToanTienMat : IPayment
    {
        public bool ThanhToan(decimal soTien, out string thongBao)
        {
            if (soTien <= 0)
            {
                thongBao = "So tien khong hop le";
                return false;
            }

            thongBao = "Thanh toan tien mat thanh cong";
            return true;
        }
    }

    public class ChuyenKhoan : IPayment
    {
        public string SoTaiKhoan { get; set; }

        public ChuyenKhoan(string soTaiKhoan)
        {
            SoTaiKhoan = soTaiKhoan;
        }

        public bool ThanhToan(decimal soTien, out string thongBao)
        {
            if (soTien <= 0 || string.IsNullOrWhiteSpace(SoTaiKhoan))
            {
                thongBao = "Thong tin chuyen khoan khong hop le";
                return false;
            }

            thongBao = "Chuyen khoan thanh cong (mo phong)";
            return true;
        }
    }

    public class ViDienTu : IPayment
    {
        public string MaVi { get; set; }

        public ViDienTu(string maVi)
        {
            MaVi = maVi;
        }

        public bool ThanhToan(decimal soTien, out string thongBao)
        {
            if (soTien <= 0 || string.IsNullOrWhiteSpace(MaVi))
            {
                thongBao = "Thong tin vi dien tu khong hop le";
                return false;
            }

            thongBao = "Thanh toan vi dien tu thanh cong (mo phong)";
            return true;
        }
    }

    public static class Demo
    {
        public static void Run()
        {
            Console.WriteLine("\n=== BAI 9 ===");

            List<IPayment> ds = new List<IPayment>
            {
                new ThanhToanTienMat(),
                new ChuyenKhoan("123456789"),
                new ViDienTu("VIMO001")
            };

            decimal soTien = 500000m;
            int giaoDichThanhCong = 0;

            foreach (IPayment payment in ds)
            {
                if (payment.ThanhToan(soTien, out string thongBao))
                {
                    giaoDichThanhCong++;
                    Console.WriteLine(
                        $"{soTien:N0} VND - {thongBao}");
                }
                else
                {
                    Console.WriteLine("That bai: " + thongBao);
                }
            }

            Console.WriteLine(
                $"Tong giao dich thanh cong: {giaoDichThanhCong}");
        }
    }
}
