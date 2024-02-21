using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐỀ_2
{
    class NhanVienBC:NhanVien
    {
        private string mucxeploai;
        public NhanVienBC() : base(){ }
        public NhanVienBC(string hoten,string maso,int luongcung,string mucxeploai) : base(hoten, maso, luongcung)
        {
            this.mucxeploai = mucxeploai;
        }
        public string MucXeploai
        {
            set { this.mucxeploai = value; }
            get { return this.mucxeploai; }
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("nhap muc xep loai");
            this.mucxeploai = Console.ReadLine();
        }
        public override int TinhLuong()
        {
            double thuong;
            double luongthuchanh;
            switch (mucxeploai)
            {
                case "A":
                    thuong = 1.5 * LuongCung;
                    break;
                case "B":
                    thuong = 1.2 * LuongCung;
                    break;
                case "C":
                    thuong = 0.8 * LuongCung;
                    break;
            }
            luongthuchanh = thuong+LuongCung;
            return (int)luongthuchanh;
        }
    }
}
