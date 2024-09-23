
using System;
using System.Collections.Generic;

class Program
{
    static List<SinhVien> danhSachSinhVien = new List<SinhVien>();

    // Phương thức thêm sinh viên
    static void ThemSinhVien()
    {
        Console.Write("Nhập mã sinh viên: ");
        string maSV = Console.ReadLine();
        Console.Write("Nhập họ tên sinh viên: ");
        string hoTen = Console.ReadLine();

        SinhVien sv = new SinhVien(maSV, hoTen);
        danhSachSinhVien.Add(sv);

        Console.WriteLine("Thêm sinh viên thành công!\n");
    }

    // Phương thức tìm sinh viên theo mã
    static SinhVien TimSinhVienTheoMa(string maSV)
    {
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.MaSV == maSV)
            {
                return sv;
            }
        }
        return null;
    }

    // Phương thức nhập điểm cho sinh viên
    static void NhapDiemChoSinhVien()
    {
        Console.Write("Nhập mã sinh viên cần nhập điểm: ");
        string maSV = Console.ReadLine();
        SinhVien sv = TimSinhVienTheoMa(maSV);

        if (sv != null)
        {
            Console.Write("Nhập số môn học: ");
            int soMonHoc = int.Parse(Console.ReadLine());

            for (int i = 0; i < soMonHoc; i++)
            {
                Console.Write($"Nhập điểm môn học {i + 1}: ");
                double diem = double.Parse(Console.ReadLine());
                sv.ThemDiem(diem);
            }

            Console.WriteLine("Đã nhập điểm thành công!\n");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên!\n");
        }
    }

    // Phương thức hiển thị danh sách sinh viên
    static void HienThiDanhSachSinhVien()
    {
        Console.WriteLine("Danh sách sinh viên:");
        foreach (var sv in danhSachSinhVien)
        {
            sv.HienThiThongTin();
        }
        Console.WriteLine();
    }

    // Main program
    static void Main(string[] args)
    {
        int luaChon = 0;

        do
        {
            Console.WriteLine("1. Thêm sinh viên");
            Console.WriteLine("2. Nhập điểm cho sinh viên");
            Console.WriteLine("3. Hiển thị danh sách sinh viên");
            Console.WriteLine("0. Thoát");
            Console.Write("Nhập lựa chọn: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    ThemSinhVien();
                    break;
                case 2:
                    NhapDiemChoSinhVien();
                    break;
                case 3:
                    HienThiDanhSachSinhVien();
                    break;
                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }

        } while (luaChon != 0);
    }
}
