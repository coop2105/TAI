// using System;
// using System.Text;
//
// namespace _26C1INF50900505_CSLT.session05
// {
//     internal class BaiTapHam
//     {
//
//         public static void Main(string[] args)
//         {
//             Console.OutputEncoding = Encoding.UTF8;
//
//             EX1();
//             EX2();
//             EX3();
//             EX4();
//             EX5();
//             EX6();
//             EX7();
//             EX8();
//             EX9();
//             EX10();
//         }
//
//         static int TinhTong(int a, int b)
//         {
//             return a + b;
//         }
//
//         static bool KiemTraChan(int n)
//         {
//             return n % 2 == 0;
//         }
//
//         static int TimMax(int a, int b, int c)
//         {
//             return Math.Max(Math.Max(a, b), c);
//         }
//
//         static long TinhGiaiThua(int n)
//         {
//             long ketQua = 1;
//             for (int i = 1; i <= n; i++)
//             {
//                 ketQua *= i;
//             }
//             return ketQua;
//         }
//
//         static string DaoNguocChuoi(string input)
//         {
//             char[] arr = input.ToCharArray();
//             Array.Reverse(arr);
//             return new string(arr);
//         }
//
//         static bool KiemTraNguyenTo(int n)
//         {
//             if (n < 2) return false;
//             for (int i = 2; i * i <= n; i++)
//             {
//                 if (n % i == 0) return false;
//             }
//             return true;
//         }
//
//         static void InFibonacci(int n)
//         {
//             long a = 0, b = 1;
//             for (int i = 0; i < n; i++)
//             {
//                 Console.Write(a + " ");
//                 long tam = a + b;
//                 a = b;
//                 b = tam;
//             }
//             Console.WriteLine();
//         }
//
//         static int DemNguyenAm(string s)
//         {
//             int dem = 0;
//             string nguyenAm = "aeiouAEIOU";
//             foreach (char c in s)
//             {
//                 if (nguyenAm.Contains(c)) dem++;
//             }
//             return dem;
//         }
//
//         static double TinhLuyThua(double x, int y)
//         {
//             double ketQua = 1;
//             for (int i = 0; i < y; i++)
//             {
//                 ketQua *= x;
//             }
//             return ketQua;
//         }
//
//         static double TinhTrungBinh(int[] arr)
//         {
//             int tong = 0;
//             foreach (int x in arr)
//             {
//                 tong += x;
//             }
//             return (double)tong / arr.Length;
//         }
//
//         static void EX1()
//         {
//             Console.WriteLine("Tinh tong hai so nguyen");
//             int a = 5, b = 7;
//             Console.WriteLine($"TinhTong({a}, {b}) = {TinhTong(a, b)}");
//         }
//
//         static void EX2()
//         {
//             Console.WriteLine("\nKiem tra so chan le");
//             int n = 10;
//             Console.WriteLine($"KiemTraChan({n}) = {KiemTraChan(n)}");
//         }
//
//         static void EX3()
//         {
//             Console.WriteLine("\nTim so lon nhat trong ba so");
//             int a = 3, b = 9, c = 6;
//             Console.WriteLine($"TimMax({a}, {b}, {c}) = {TimMax(a, b, c)}");
//         }
//
//         static void EX4()
//         {
//             Console.WriteLine("\nTinh giai thua cua mot so");
//             int n = 5;
//             Console.WriteLine($"TinhGiaiThua({n}) = {TinhGiaiThua(n)}");
//         }
//
//         static void EX5()
//         {
//             Console.WriteLine("\nDao nguoc chuoi ky tu");
//             string s = "Xin Chao";
//             Console.WriteLine($"DaoNguocChuoi(\"{s}\") = {DaoNguocChuoi(s)}");
//         }
//
//         static void EX6()
//         {
//             Console.WriteLine("\nKiem tra so nguyen to");
//             int n1 = 7, n2 = 10;
//             Console.WriteLine($"KiemTraNguyenTo({n1}) = {KiemTraNguyenTo(n1)}");
//             Console.WriteLine($"KiemTraNguyenTo({n2}) = {KiemTraNguyenTo(n2)}");
//         }
//
//         static void EX7()
//         {
//             Console.WriteLine("\nIn day Fibonacci");
//             int n = 6;
//             Console.Write($"InFibonacci({n}) = ");
//             InFibonacci(n);
//         }
//
//         static void EX8()
//         {
//             Console.WriteLine("\nDem so luong nguyen am trong chuoi");
//             string s = "Hello World";
//             Console.WriteLine($"DemNguyenAm(\"{s}\") = {DemNguyenAm(s)}");
//         }
//
//         static void EX9()
//         {
//             Console.WriteLine("\nTinh luy thua");
//             double x = 2;
//             int y = 3;
//             Console.WriteLine($"TinhLuyThua({x}, {y}) = {TinhLuyThua(x, y)}");
//         }
//
//         static void EX10()
//         {
//             Console.WriteLine("\nTinh diem trung binh cua mang");
//             int[] arr = { 4, 5, 6, 7 };
//             Console.WriteLine($"TinhTrungBinh([{string.Join(", ", arr)}]) = {TinhTrungBinh(arr)}");
//         }
//     }
// }