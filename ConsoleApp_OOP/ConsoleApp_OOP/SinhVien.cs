using System;
using System.Collections.Generic;

public class SinhVien
{
    // Thuộc tính của lớp SinhVien
    public string MaSV { get; set; }
    public string HoTen { get; set; }
    public List<double> DiemMonHoc { get; set; }

    // Constructor
    public SinhVien(string maSV, string hoTen)
    {
        MaSV = maSV;
        HoTen = hoTen;
        DiemMonHoc = new List<double>();
    }

    // Phương thức thêm điểm
    public void ThemDiem(double diem)
    {
        DiemMonHoc.Add(diem);
    }

    // Phương thức tính điểm trung bình
    public double TinhDiemTrungBinh()
    {
        if (DiemMonHoc.Count == 0)
            return 0;

        double tongDiem = 0;
        foreach (var diem in DiemMonHoc)
        {
            tongDiem += diem;
        }

        return tongDiem / DiemMonHoc.Count;
    }

    // Phương thức kiểm tra sinh viên có đạt hay không
    public bool KiemTraDat()
    {
        return TinhDiemTrungBinh() >= 5.0;
    }

    // Phương thức hiển thị thông tin sinh viên
    public void HienThiThongTin()
    {
        Console.WriteLine($"Mã SV: {MaSV}, Họ Tên: {HoTen}, Điểm TB: {TinhDiemTrungBinh():F2}, Trạng thái: {(KiemTraDat() ? "Đạt" : "Không đạt")}");
    }
}
