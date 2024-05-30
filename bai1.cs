using System;

namespace DataTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhắc người dùng nhập một số nguyên
            Console.WriteLine("Nhập một số nguyên:");

            // Đọc giá trị nhập từ bàn phím và chuyển đổi thành kiểu int
            string userInput = Console.ReadLine();
            int number;

            // Kiểm tra xem người dùng đã nhập một số nguyên hợp lệ chưa
            if (int.TryParse(userInput, out number))
            {
                // Ép kiểu số nguyên thành kiểu double
                double doubleNumber = (double)number;

                // Hiển thị kết quả ra màn hình
                Console.WriteLine($"Số bạn đã nhập là {number} và dưới dạng double là {doubleNumber}");
            }
            else
            {
                Console.WriteLine("Bạn đã nhập không phải là một số nguyên hợp lệ.");
            }
        }
    }
}
