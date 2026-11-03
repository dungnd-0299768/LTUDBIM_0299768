using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SinhVien
    {
        public string HoTen;
        public string QueQuan;
        public double DiemToan;
        public double DiemLy;
        public double DiemHoa;
        public double DiemTB;

        public SinhVien(string _HoTen, string _QueQuan, double _DiemToan, double _DiemLy, double _DiemHoa)
        {
            this.HoTen = _HoTen;
            this.QueQuan = _QueQuan;
            this.DiemToan = _DiemToan;
            this.DiemLy = _DiemLy;
            this.DiemHoa = _DiemHoa;
        }


        // PHUONG THUC TINH DIEM TB
        public double TinhDiemTB( SinhVien sv1)
        {
            DiemTB = (DiemToan + DiemLy + DiemHoa) / 3;
            return DiemTB;
        }

        // PHUONG THUC IN DANH SACH
        public static void InDS(List<SinhVien> ds)
        {
            Console.WriteLine("DANH SACH SINH VIEN");
            foreach (SinhVien s in ds)
            {
               Console.WriteLine("Ho Ten:"+ s.HoTen);
                Console.WriteLine(" Que Quan:"+ s.QueQuan);
                Console.WriteLine(" Diem Toan:"+ s.DiemToan);
                Console.WriteLine(" Diem Ly:" + s.DiemLy);
                Console.WriteLine(" Diem Hoa:" + s.DiemHoa);
                Console.WriteLine(" Diem Trung Binh"+ s.DiemTB.ToString("F2"));
            }
        }
        class Program
        {
            public static void Main(string[] args)
            {
                // khai bao danh sach sinh vien
                List<SinhVien> ds = new List<SinhVien>();
                Console.WriteLine(" Nhap so luong sinh vien:");
                    int n=int.Parse(Console.ReadLine());

                // nhap thong tin sinh vien
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\nNhap sinh vien thu:"+(i+1));
                    Console.WriteLine("Ho ten: ");
                    Console.WriteLine("Que quan: ");
                    Console.WriteLine("Diem toan: ");
                    double toan= double.Parse(Console.ReadLine());
                    Console.WriteLine("Diem ly: ");
                    double ly = double.Parse(Console.ReadLine());
                    Console.WriteLine("Diem hoa: ");
                    double hoa = double.Parse(Console.ReadLine());

                    // tao doi tuong sinh vien
                    SinhVien sv = new SinhVien( toan, ly, hoa); 

                }
            }

        }

    }
}
