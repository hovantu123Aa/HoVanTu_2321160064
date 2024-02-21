using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐỀ_2
{
    class NhanVienHD:NhanVien
    {
        private int danhthu;
        public NhanVienHD() : base(){ }
        public NhanVienHD(string hoten, string maso, int luongcung,int danhthu): base(hoten, maso, luongcung)
        {
            this.danhthu = danhthu;
        }
        public int DanhThu
        {
            set { this.danhthu = value; }
            get { return this.danhthu; }

        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("nhap danh thu");
            this.danhthu = int.Parse(Console.ReadLine());
        }
        public override int TinhLuong()
        {
            double luongThucHanh = LuongCung + (0.5 * LuongCung);
            return (int)TinhLuong();
        }
    }
}
