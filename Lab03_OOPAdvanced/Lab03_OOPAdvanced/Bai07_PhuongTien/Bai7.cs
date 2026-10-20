
using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced.Bai07
{
    public interface IMove
    {
        double TinhTocDo();
        decimal TinhChiPhi(double soKm);
    }

    public class XeMay : IMove
    {
        public double TocDo { get; set; }
        public XeMay(double tocDo) { TocDo = tocDo; }

        public double TinhTocDo() => TocDo;
        public decimal TinhChiPhi(double soKm)
            => (decimal)soKm * 1500m;
    }

    public class OTo : IMove
    {
        public double TocDo { get; set; }
        public OTo(double tocDo) { TocDo = tocDo; }

        public double TinhTocDo() => TocDo;
        public decimal TinhChiPhi(double soKm)
            => (decimal)soKm * 3000m;
    }

    public class XeDap : IMove
    {
        public double TocDo { get; set; }
        public XeDap(double tocDo) { TocDo = tocDo; }

        public double TinhTocDo() => TocDo;
        public decimal TinhChiPhi(double soKm) => 0m;
    }

    public static class Demo
    {
        public static void Run()
        {
            Console.WriteLine("\n=== BAI 7 ===");

            List<IMove> ds = new List<IMove>
            {
                new XeMay(40),
                new OTo(60),
                new XeDap(15)
            };

            string[] ten = { "Xe may", "O to", "Xe dap" };
            double soKm = 10;

            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine(
                    $"{ten[i]}: {ds[i].TinhTocDo():N0} km/h, " +
                    $"chi phi {soKm:N0} km = " +
                    $"{ds[i].TinhChiPhi(soKm):N0} VND");
            }
        }
    }
}
