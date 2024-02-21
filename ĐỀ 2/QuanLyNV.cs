using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐỀ_2
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>();
        }
        public void NhapDS()
        {
            string tieptuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.Write("chon loai nhan vien  [1 Bien Che,2:Hop Dong]:");
                chon = int.Parse(Console.ReadLine());
                switch(chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.nhap();
                        dsNV.Add(nv);
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.nhap();
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.Write("chon khong dung chon lai .chon 1 trong 2 phuong an");
                        break;
                }
                Console.Write("Ban co muon tiep tuc khong? Y/N:");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "y");

        }
        public void XuatDS()
        {
            Console.WriteLine($"{"Ma so"}  {"Ho Ten"}  {"Nam Sinh"}  {"Luong"}");
            foreach (NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.MaSo}  {x.HoTen}  {x.LuongCung}  {x.TinhLuong():#,##0 vnd}");
            }
        }
        public int Tinhtongluong()
        {
            int sum = 0;
            foreach(NhanVien a in dsNV)
            {
                sum += a.TinhLuong();
            }
            return sum;
        }
        public int tinhtrungbinh()
        {
            double avg;
            int sum = 0;
            int count = 0;
            foreach(NhanVien a in dsNV)
            {
                sum += a.TinhLuong();
                count++;
            }
            avg = sum / count;
            return avg;
        }
    }
}
