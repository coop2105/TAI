using System;

class Program
{
    static int DoDaiChuoi(string s)
    {
        int count = 0;
        try
        {
            while (true)
            {
                char c = s[count];
                count++;
            }
        }
        catch (IndexOutOfRangeException)
        {
            return count;
        }
    }

    static void EX01()
    {
        Console.Write("Nhập chuỗi: ");
        string s = Console.ReadLine();
        Console.WriteLine(s);
    }

    static void EX02()
    {
        Console.Write("Nhập chuỗi: ");
        string s = Console.ReadLine();
        Console.WriteLine($"Độ dài chuỗi: {DoDaiChuoi(s)}");
    }

    static void EX03()
    {
        Console.Write("Nhập chuỗi: ");
        string s = Console.ReadLine();
        int len = DoDaiChuoi(s);

        for (int i = 0; i < len; i++)
        {
            Console.WriteLine($"Ký tự {i}: {s[i]}");
        }
    }

    static void EX04()
    {
        Console.Write("Nhập chuỗi: ");
        string s = Console.ReadLine();
        int len = DoDaiChuoi(s);

        for (int i = len - 1; i >= 0; i--)
        {
            Console.Write(s[i]);
        }
        Console.WriteLine();
    }

    static void EX05()
    {
        Console.Write("Nhập chuỗi: ");
        string s = Console.ReadLine();
        int len = DoDaiChuoi(s);

        int soTu = 0;
        bool dangTrongTu = false;

        for (int i = 0; i < len; i++)
        {
            if (s[i] != ' ' && !dangTrongTu)
            {
                soTu++;
                dangTrongTu = true;
            }
            else if (s[i] == ' ')
            {
                dangTrongTu = false;
            }
        }

        Console.WriteLine($"Số từ: {soTu}");
    }

    static void EX06()
    {
        Console.Write("Nhập chuỗi 1: ");
        string s1 = Console.ReadLine();
        Console.Write("Nhập chuỗi 2: ");
        string s2 = Console.ReadLine();

        int len1 = DoDaiChuoi(s1);
        int len2 = DoDaiChuoi(s2);

        bool bangNhau = true;

        if (len1 != len2)
        {
            bangNhau = false;
        }
        else
        {
            for (int i = 0; i < len1; i++)
            {
                if (s1[i] != s2[i])
                {
                    bangNhau = false;
                    break;
                }
            }
        }

        Console.WriteLine(bangNhau ? "Hai chuỗi giống nhau" : "Hai chuỗi khác nhau");
    }

    static void EX07()
    {
        Console.Write("Nhập chuỗi: ");
        string s = Console.ReadLine();
        int len = DoDaiChuoi(s);

        int soChuCai = 0, soChuSo = 0, soKyTuDacBiet = 0;

        for (int i = 0; i < len; i++)
        {
            char c = s[i];
            if (char.IsLetter(c))
                soChuCai++;
            else if (char.IsDigit(c))
                soChuSo++;
            else if (c != ' ')
                soKyTuDacBiet++;
        }

        Console.WriteLine($"Số chữ cái: {soChuCai}");
        Console.WriteLine($"Số chữ số: {soChuSo}");
        Console.WriteLine($"Số ký tự đặc biệt: {soKyTuDacBiet}");
    }

    static void EX08()
    {
        Console.Write("Nhập chuỗi: ");
        string s = Console.ReadLine();
        int len = DoDaiChuoi(s);

        int soNguyenAm = 0, soPhuAm = 0;
        string nguyenAm = "aeiouAEIOU";

        for (int i = 0; i < len; i++)
        {
            char c = s[i];
            if (!char.IsLetter(c)) continue;

            if (nguyenAm.IndexOf(c) >= 0)
                soNguyenAm++;
            else
                soPhuAm++;
        }

        Console.WriteLine($"Số nguyên âm: {soNguyenAm}");
        Console.WriteLine($"Số phụ âm: {soPhuAm}");
    }

    static void EX09()
    {
        Console.Write("Nhập chuỗi: ");
        string s = Console.ReadLine();
        Console.Write("Nhập chuỗi con cần kiểm tra: ");
        string sub = Console.ReadLine();

        bool coChua = s.Contains(sub);
        Console.WriteLine(coChua ? "Chuỗi con có tồn tại" : "Chuỗi con không tồn tại");
    }

    static void EX10()
    {
        Console.Write("Nhập chuỗi: ");
        string s = Console.ReadLine();
        Console.Write("Nhập chuỗi con cần tìm: ");
        string sub = Console.ReadLine();

        int viTri = s.IndexOf(sub);

        if (viTri >= 0)
            Console.WriteLine($"Tìm thấy tại vị trí: {viTri}");
        else
            Console.WriteLine("Không tìm thấy chuỗi con");
    }

    static void EX11()
    {
        Console.Write("Nhập một ký tự: ");
        char c = Console.ReadLine()[0];

        if (char.IsLetter(c))
        {
            if (char.IsUpper(c))
                Console.WriteLine($"'{c}' là chữ cái in hoa");
            else
                Console.WriteLine($"'{c}' là chữ cái in thường");
        }
        else
        {
            Console.WriteLine($"'{c}' không phải là chữ cái");
        }
    }

    static void EX12()
    {
        Console.Write("Nhập chuỗi: ");
        string s = Console.ReadLine();
        Console.Write("Nhập chuỗi con cần đếm: ");
        string sub = Console.ReadLine();

        int demSoLan = 0;
        int viTri = 0;

        while (true)
        {
            int tim = s.IndexOf(sub, viTri);
            if (tim < 0) break;

            demSoLan++;
            viTri = tim + 1;
        }

        Console.WriteLine($"Chuỗi con xuất hiện {demSoLan} lần");
    }

    static void EX13()
    {
        Console.Write("Nhập chuỗi: ");
        string s = Console.ReadLine();
        Console.Write("Nhập chuỗi con cần chèn: ");
        string chuoiChen = Console.ReadLine();
        Console.Write("Nhập chuỗi mốc (chèn trước lần xuất hiện đầu tiên): ");
        string moc = Console.ReadLine();

        int viTri = s.IndexOf(moc);

        if (viTri >= 0)
        {
            string ketQua = s.Insert(viTri, chuoiChen);
            Console.WriteLine($"Chuỗi sau khi chèn: {ketQua}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy chuỗi mốc trong chuỗi gốc");
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        EX01();
        EX02();
        EX03();
        EX04();
        EX05();
        EX06();
        EX07();
        EX08();
        EX09();
        EX10();
        EX11();
        EX12();
        EX13();
    }
}