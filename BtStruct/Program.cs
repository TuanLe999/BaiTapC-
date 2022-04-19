using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtStruct
{
    class Program
    {
        enum lop
        {
            T1 = 1, T2, T3
        }

        struct sinhVien
        {
            public string MSV_320;
            public string ten_320;
            public lop lop_320;
            public double diemToan_320;
            public double diemLy_320;
            public double diemHoa_320;

        }
        static void taoDanhSach(ref sinhVien[] sv_320)
        {
            for (int i_320 = 0; i_320 < sv_320.Length; i_320++)
            {
                Console.WriteLine("Nhập thông tin sinh viên {0}:", i_320 + 1);
                Console.Write("Nhập mã sinh viên: ");
                sv_320[i_320].MSV_320 = Console.ReadLine();
                Console.Write("Nhập tên sinh viên: ");
                sv_320[i_320].ten_320 = Console.ReadLine();
                Console.Write("Nhập lớp (1,2,3): ");
                sv_320[i_320].lop_320 = (lop)int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập điểm Toán: ");
                sv_320[i_320].diemToan_320 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập điểm Lý: ");
                sv_320[i_320].diemLy_320 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập điểm Hóa: ");
                sv_320[i_320].diemHoa_320 = double.Parse(Console.ReadLine());
            }
        }

        static void inThongTin(sinhVien sv_320)
        {
            Console.WriteLine("Mã sinh viên: " + sv_320.MSV_320);
            Console.WriteLine("Tên: " + sv_320.ten_320);
            Console.WriteLine("Lớp: " + sv_320.lop_320);
            Console.WriteLine("Điểm Toán: " + sv_320.diemToan_320);
            Console.WriteLine("Điểm Lý: " + sv_320.diemLy_320);
            Console.WriteLine("Điểm Hóa: " + sv_320.diemHoa_320);
        }
        static double tinhDTB(sinhVien sv_320)
        {
            return (sv_320.diemToan_320 + sv_320.diemLy_320 + sv_320.diemHoa_320) / 3;
        }

        static int timSinhVien(sinhVien[] sv_320, string ten)
        {
            int check_320 = 0;
            for (int i = 0; i < sv_320.Length; i++)
            {
                if (string.Equals(ten, sv_320[i].ten_320))
                {
                    inThongTin(sv_320[i]);
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Điểm trung bình: " + tinhDTB(sv_320[i]));
                    check_320 = 1;
                }

            }
            return check_320;

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Số sinh viên cần lưu: ");
            int n_320 = int.Parse(Console.ReadLine());
            sinhVien[] sv_320 = new sinhVien[n_320];
            taoDanhSach(ref sv_320);
            foreach (sinhVien s_320 in sv_320)
            {
                Console.WriteLine("-------------------------");
                inThongTin(s_320);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("\nNhập tên sinh viên cần tìm: ");
            string name_320 = Console.ReadLine();
            if (timSinhVien(sv_320, name_320) == 0)
            {
                Console.WriteLine("Không có sinh viên cần tìm! ");
            }
            Console.ReadKey();
        }
    }
}
