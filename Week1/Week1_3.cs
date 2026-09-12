using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCAdvance.Hinh
{
    public class HinhTron
    {
        private double banKinh;
        public double BanKinh {get; 
            set
            {
                if (value < 0)
                    throw new ArgumentException("Ban kinh khong hop le");
                    else
                        banKinh = value;
            }
            }
        public HinhTron(double banKinh)
        {
            this.BanKinh = banKinh;
        }
        public double getDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
    }
}