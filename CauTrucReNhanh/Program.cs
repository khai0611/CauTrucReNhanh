using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucReNhanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If/Else

            //VD1:
            //int a = 10;
            //int b = 0;

            //if (a > b)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //VD2:
            //Console.OutputEncoding = Encoding.UTF8; // xuất ra màn hình tiếng việt

            //int x;
            //int y;

            //Console.WriteLine("Nhập số thứ nhất: ");
            //x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Nhập số thứ hai: ");
            //y = Convert.ToInt32(Console.ReadLine());

            //if(x == y)
            //{
            //    Console.WriteLine("Hai số {0} và {1} bằng nhau" , x, y);
            //}
            //else
            //{
            //    Console.WriteLine("Hai số {0} và {1} không bằng nhau", x, y);
            //}

            //VD3:
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine("Nhập số thứ 1: ");
            //int m = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Nhập số thứ 2: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Nhập số thứ 3: ");
            //int o = Convert.ToInt32(Console.ReadLine());


            //if (m > n && m > o)
            //{
            //    Console.WriteLine("m = {0} là số lớn nhất ", m);
            //}
            //else if (n > m && n > o)
            //{
            //    Console.WriteLine("n = {0} là số lớn nhất ", n);
            //}
            //else
            //{
            //    Console.WriteLine("o = {0} là số lớn nhất ", o);
            //}

            //Console.ReadKey();
            #endregion

            #region Switch/Case

            //VD1
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Nhập vào một tháng: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Tháng có 31 ngày");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tháng có 28 ngày hoặc 29 ngày nếu là năm nhuận");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Tháng có 30 ngày");
            //        break;
            //    default:
            //        Console.WriteLine("Tháng bạn nhập không hợp lệ");
            //        break;
            //}

            //VD2:

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Nhập vào số từ 1 đến 7 để kiếm tra ngày: ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Hôm nay là thứ 2");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hôm nay là thứ 3");
            //        break;
            //    case 3:
            //        Console.WriteLine("Hôm nay là thứ 4");
            //        break;
            //    case 4:
            //        Console.WriteLine("Hôm nay là thứ 5");
            //        break;
            //    case 5:
            //        Console.WriteLine("Hôm nay là thứ 6");
            //        break;
            //    case 6:
            //        Console.WriteLine("Hôm nay là thứ 7");
            //        break;
            //    case 7:
            //        Console.WriteLine("Hôm nay là chủ nhật");
            //        break;
            //    default:
            //        Console.WriteLine("Ngày nhập không hợp lệ!. Mời bạn nhập lại");
            //        break;
            //}

            Console.ReadKey();
            #endregion
        }
    }
}

//Cấu trúc rẽ nhánh là gì?
/*
 * - Cấu trúc dùng để diễn đạt một việc sẽ được thực hiện khi một điều kiện cụ thể được thỏa mãn
 * - Còn được gọi là câu lệnh điều kiện
 * - Có 2 loại: If/Else và Switch/Case
 * Mệnh đề If/Else trong C# được sử dụng để kiểm tra giá trị dạng boolean của điều kiện. Mệnh đề này trả về giá trị True hoặc False.4
 * Cú pháp: 
 *  if (condition) 
    {
        // khối lệnh được thực thi nếu condition là True
    }
    else
    {
        // khối lệnh được thực thi nếu condition là False
    }
    
    Switch/Case: Lệnh switch-case trong C# được sử dụng để thực thi 1 hoặc nhiều khối lệnh từ nhiều điều kiện.
    switch(expression) 
    {
        case x:
            // code
            break;
        case y:
            // code
          break;
        default:
            // code
        break;
    }
 * - Khi gặp lệnh break , lệnh switch sẽ bị ngắt. Lệnh tiếp theo bên ngoài switch được thực thi.
 * - Nếu không có case nào phù hợp với expression của lệnh switch thì khối lệnh sau từ khóa default được thực thi.
 */
