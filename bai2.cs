using System;

namespace NumericTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhắc người dùng nhập một số thực
            Console.WriteLine("Nhập một số thực:");

            // Đọc giá trị nhập từ bàn phím và chuyển đổi thành kiểu double
            string userInput = Console.ReadLine();
            double realNumber;

            // Kiểm tra xem người dùng đã nhập một số thực hợp lệ chưa
            if (double.TryParse(userInput, out realNumber))
            {
                // Ép kiểu số thực thành kiểu int và kiểu long
                int intNumber = (int)realNumber;
                long longNumber = (long)realNumber;

                // Hiển thị kết quả ra màn hình
                Console.WriteLine($"Số bạn đã nhập là {realNumber}, dưới dạng int là {intNumber} và dưới dạng long là {longNumber}");
            }
            else
            {
                Console.WriteLine("Bạn đã nhập không phải là một số thực hợp lệ.");
            }
        }
    }
}
