internal class ex02
{
    static void ex01()
    {
        Console.WriteLine("nhap do c");
        float ce = float.Parse(Console.ReadLine());
        float ke = ce + 273;
        float fa = ce * 18 / 10 + 32;
        Console.WriteLine($"{ce} c = {ke} k = {fa} f"); 
    }
    static void Main()
    {
        ex01();
    }

}
