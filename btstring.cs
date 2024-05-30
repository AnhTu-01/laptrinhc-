using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập một chuỗi: ");
        string chuoiNguoiDung = Console.ReadLine();

        string chuoiDaoNguoc = DaoNguocChuoi(chuoiNguoiDung);
        Console.WriteLine("Chuỗi đã đảo ngược: " + chuoiDaoNguoc);

        Console.Write("Nhập một chuỗi tìm kiếm: ");
        string chuoiTimKiem = Console.ReadLine();

        int soLanXuatHien = DemSoLanXuatHien(chuoiNguoiDung, chuoiTimKiem);
        Console.WriteLine("Số lần xuất hiện của '" + chuoiTimKiem + "': " + soLanXuatHien);

        Console.Write("Nhập một chuỗi con cũ: ");
        string chuoiConCu = Console.ReadLine();
        Console.Write("Nhập một chuỗi con mới: ");
        string chuoiConMoi = Console.ReadLine();

        string chuoiDaThayThe = ThayTheChuoiCon(chuoiNguoiDung, chuoiConCu, chuoiConMoi);
        Console.WriteLine("Chuỗi đã thay thế: " + chuoiDaThayThe);

        string chuoiKhongKhoangTrang = XoaKhoangTrang(chuoiNguoiDung);
        Console.WriteLine("Chuỗi không có khoảng trắng: " + chuoiKhongKhoangTrang);
    }

    static string DaoNguocChuoi(string chuoiDauVao)
    {
        char[] mangKyTu = chuoiDauVao.ToCharArray();
        Array.Reverse(mangKyTu);
        return new string(mangKyTu);
    }

    static int DemSoLanXuatHien(string chuoiDauVao, string chuoiTimKiem)
    {
        int soLan = 0;
        int chiSo = 0;

        while ((chiSo = chuoiDauVao.IndexOf(chuoiTimKiem, chiSo)) != -1)
        {
            soLan++;
            chiSo += chuoiTimKiem.Length;
        }

        return soLan;
    }

    static string ThayTheChuoiCon(string chuoiDauVao, string chuoiConCu, string chuoiConMoi)
    {
        return chuoiDauVao.Replace(chuoiConCu, chuoiConMoi);
    }

    static string XoaKhoangTrang(string chuoiDauVao)
    {
        return string.Concat(chuoiDauVao.Where(c => !char.IsWhiteSpace(c)));
    }
}
