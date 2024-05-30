using System;

namespace CharToIntConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhắc người dùng nhập một ký tự
            Console.WriteLine("Nhập một ký tự:");

            // Đọc giá trị nhập từ bàn phím và chuyển đổi thành kiểu char
            string userInput = Console.ReadLine();
            char character;

            // Kiểm tra xem người dùng đã nhập một ký tự hợp lệ chưa
            if (char.TryParse(userInput, out character))
            {
                // Ép kiểu ký tự thành kiểu int để lấy mã ASCII
                int asciiCode = (int)character;

                // Hiển thị kết quả ra màn hình
                Console.WriteLine($"Ký tự bạn đã nhập là '{character}', mã ASCII của nó là {asciiCode}");
            }
            else
            {
                Console.WriteLine("Bạn đã nhập không phải là một ký tự hợp lệ.");
            }
        }
    }
}
