using System.Text;

namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();
            Point[] points = new Point[5];

            for (int i = 0; i < points.Length; i++)
            {
                //float x = (float)(random.Next(-10, 10));
                //float y = (float)(random.Next(-10, 10));

                float x = random.Next(-10, 10);
                float y= random.Next(-10, 10);
                points[i] = new Point(x, y);
            }

            Console.WriteLine("Các điểm ngẫu nhiên:");
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"Điểm [{i}]: ({points[i].X}, {points[i].Y})\t \t{points[i].Position()}");
            }

            int p1, p2;

            while (true)
            {
                p1 = random.Next(points.Length);
                p2 = random.Next(points.Length);
                if (p1 != p2) break; // Lặp đến khi hai điểm khác nhau
            }


            double distance = Point.Distance(points[p1], points[p2]);
            Console.WriteLine("-----------------------------------------");
            //Console.WriteLine($"Khoảng cách giữa hai điểm ({points[p1].X}, {points[p1].Y}) và ({points[p2].X}, {points[p2].Y}): {distance}");
            Console.WriteLine($"Khoảng cách giữa hai điểm [{p1}] và [{p2}]: {distance}");
            //Console.WriteLine($"Điểm [{p1}] ({points[p1].X}, {points[p1].Y}): {points[p1].Position()} - Điểm [{p2}] ({points[p2].X}, {points[p2].Y}): {points[p2].Position()}");




            Point[] threePoints = new Point[3];
            int[] index = new int[3];
            int count = 0;
            while (count < 3)
            {
                int randomIndex = random.Next(points.Length);
                bool duplicate = false;

                for (int i = 0; i < index.Length; i++)
                {
                    if (index[i] == randomIndex)
                    {
                        duplicate = true;
                        break;
                    }
                }

                if (!duplicate)
                {
                    index[count] = randomIndex;
                    threePoints[count] = points[randomIndex];
                    count++;
                }
            }
            Console.WriteLine("\n3 điểm được chọn ngẫu nhiên:");
            for (int i = 0; i < threePoints.Length; i++)
            {
                Console.WriteLine($"Điểm [{index[i]}]: ({threePoints[i].X}, {threePoints[i].Y})");
            }


            Console.WriteLine("\n3 vector được tạo từ các điểm ngẫu nhiên:");
            List<Vector> threeVectors = new List<Vector>();
            for (int i = 0; i < threePoints.Length - 1; i++)
            {
                for (int j = i + 1; j < threePoints.Length; j++)
                {
                    Vector vector = new Vector(threePoints[i], threePoints[j]);
                    threeVectors.Add(vector);
                    Console.WriteLine($"Vector [{threeVectors.Count}]: ({vector.PointA.X}, {vector.PointA.Y}) - ({vector.PointB.X}, {vector.PointB.Y})");
                }
            }
            Console.WriteLine("-----------------------------------------");

            // Kiểm tra tọa độ của Vector
            for (int i = 0; i < threeVectors.Count; i++)
            {
                Point vectorPoint = Vector.CalculatorVector(threeVectors[i].PointA, threeVectors[i].PointB);
                Console.WriteLine($"Vector [{i + 1}]: ({vectorPoint.X}, {vectorPoint.Y})");
            }
            // Kiểm tra góc giữa các Vector
            for (int i = 0; i < threeVectors.Count - 1; i++)
            {
                for (int j = i + 1; j < threeVectors.Count; j++)
                {
                    double angle = Vector.AngleBetweenVectors(threeVectors[i], threeVectors[j]);
                    Console.WriteLine($"Góc giữa Vector [{i + 1}] - [{j + 1}]: {angle.ToString("F4")} độ");
                    Console.WriteLine($"Góc giữa Vector [{i + 1}] - [{j + 1}]: {angle} độ");
                }
            }
            Console.ReadKey();
        }
    }
}
/*
Cho hai lớp đối tượng (lớp Point và lớp Vector). 
Lớp Point có các field là tọa độ x, y (float). 
Lớp Vector có hai field A, B là 2 Point.
Câu 1: Khai báo lớp Point. Bổ sung getter, setter và 3 loại Constructor cho từng field
Câu 2: Khai báo lớp Vector. Bổ sung getter, setter và 3 loại constructor cho từng field 
Câu 3: Bổ sung vào lớp Point method tính khoảng cách giữa 2 điểm
Câu 4: Bổ sung vào lớp Point method xác định vị trí của nó trong góc phần tư của hệ tọa độ Decac 2 chiều
Câu 5: Bổ sung method cho lớp Vector để xác định tọa độ của Vector 
Câu 6: Bổ sung method cho lớp Vector để xác định góc giữa hai Vector 
Câu 7: Trong hàm Main, tạo một mảng gồm 5 Point tọa độ ngẫu nhiên và kiểm tra các kết quả từ câu 3 -> 4
Câu 8: Lấy ngẫu nhiên 3 cặp điểm trong mảng 5 Point ở câu 7 để tạo thành 3 Vector. 
Sử dụng cấu trúc List để chứa 3 Vector này. Sau đó kiểm thử các kết quả của câu 5 và 6 cho List Vector nói trên
*/