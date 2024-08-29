using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3_OOP
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
          * 1. tạoo 2 lớp Human và Employee
          * Human name: string
          *      age :int
          * Employee : human { các thành  viên của human 
          *                    coef : float
          *                    num of child : int }
          *      a.khai báo 2 lớp trên 
          *      b.tạo mảng 5 Employee và in ra :
          *      stt . họ tên . tuổi . lương 
          *      trong đó lương = coef * 2300.000 + num of child * 300.00
          *2. 2 lớp point và point2D 
          *Point { calc-dist : alstract }
          *Point2D : point { triển khai cacl-dist 
          *x,y : float ( tọa độ )         }
          *a. khai báo 2 lớp
          *b. triển khai phương thức calc-dist
          *tạo 1 list gồm 10 point2D 
          *in ra khoảng cách giữa các cặp point2D
          *liệt kê các tọa độ tạo thành tam giác vuông
          *
          */
            Employee[] employees = new Employee[5];
            employees[1] = new Employee { age = 21, coef = 10f, Name = "hehe", numOfChild = 0 };
            employees[2] = new Employee { Name = "kaka", age = 25, coef = 9f, numOfChild = 0 };
            employees[3] = new Employee { numOfChild = 1, age = 30, coef = 12f, Name = "hihi" };
            employees[4] = new Employee { coef = 11f, age = 29, Name = "hoho", numOfChild = 5 };
            employees[0] = new Employee { coef = 10f, age = 19, numOfChild = 2, Name = "wwe" };
            Console.WriteLine(" lap 3");
            Console.WriteLine("STT\tHọ tên\tTuổi\t Lương");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"{i + 1}\t{employees[i].Name}\t{employees[i].age}\t{employees[i].Caculatery()}");
            }
            Console.WriteLine();
            Console.WriteLine(" lap 4");

            List<Point2D> points = new List<Point2D>();
            // Khởi tạo các điểm 2D (bạn tự thay đổi tọa độ)
            points.Add(new Point2D { name = "A", x = 0, y = 0 });
            points.Add(new Point2D { x = 1, y = 0, name = "B" });
            points.Add(new Point2D { x = 0, y = 1, name = "C" });
            points.Add(new Point2D { x = 2, y = 3, name = "D" });
            points.Add(new Point2D { x = 3, y = 4, name = "E" });
            points.Add(new Point2D { x = 2, y = 0, name = "F" });
            points.Add(new Point2D { x = 1, y = 1, name = "G" });
            points.Add(new Point2D { x = 0, y = -2, name = "H" });
            points.Add(new Point2D { x = -3, y = 9, name = "I" });
            points.Add(new Point2D { x = 8, y = -4, name = "K" });
            points.Add(new Point2D { x = 9, y = 6, name = "M" });



            // Tính và in khoảng cách giữa các cặp điểm
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    double distance = points[i].CalcDist(points[j]);
                    Console.WriteLine($">>khoảng cách(D): {points[i].name}({points[i].x},{points[i].y})_{points[j].name}({points[j].x},{points[j].y}) = {distance}");
                    Console.WriteLine(  );
                }
            }
            Console.WriteLine(  );
            for (int i = 0; i < points.Count - 2; i++)
            {
                for (int j = i + 1; j < points.Count - 1; j++)
                {
                    for (int k = j + 1; k < points.Count; k++)
                    {
                        double ab = points[i].CalcDist(points[j]);
                        double bc = points[j].CalcDist(points[k]);
                        double ac = points[i].CalcDist(points[k]);

                        // Kiểm tra định lý Pytago
                        if (Math.Abs(ab * ab + bc * bc - ac * ac) < 0.0001 ||
                            Math.Abs(ab * ab + ac * ac - bc * bc) < 0.0001 ||
                            Math.Abs(ac * ac + bc * bc - ab * ab) < 0.0001)
                        {
                            Console.WriteLine($"Các điểm {points[i].name} ({points[i].x},{points[i].y}), {points[j].name}({points[j].x},{points[j].y}), {points[k].name} ({points[k].x},{points[k].y}) tạo thành tam giác vuông");
                        }
                    }
                }


                Console.ReadKey();
            }
        }
    }

}
