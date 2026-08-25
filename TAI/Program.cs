internal class Ex02
{
    static void ex01()
    {
        Console.WriteLine("nhap chi so dien cu");
        float cu = float.Parse(Console.ReadLine());
        Console.WriteLine("nhap chi so dien moi");
        float moi = float.Parse(Console.ReadLine());
        Console.WriteLine("luong dien tieu thu trong thang");
        float fa = cu * 18 / 10 + 32;
        Console.WriteLine($"{cu} c = {ke} k = {fa} f"); 
    }
    static void ex02()
    {
    }
    static void Main()
    {
        ex01();
    }

}
