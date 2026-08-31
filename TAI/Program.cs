using System;
using System.Globalization;
using System.Linq.Expressions;

class EX01()
{
    static void ex01()
    {
        Console.WriteLine("BAI TAP 1");
        Console.Write("nhap chi so cu: ");
        decimal cscu = decimal.Parse(Console.ReadLine());
        Console.Write("nhap chi so moi: ");
        decimal csmoi = decimal.Parse(Console.ReadLine());

        if (csmoi <= cscu)
        {
            Console.WriteLine("chuong trinh khong hoat dong ");
            return;
        }

        decimal sokwh = csmoi - cscu;
        decimal tiendien = 0;

        if (sokwh <= 50)
        {
            tiendien = sokwh * 1.806m;
        }
        else if (sokwh > 50 && sokwh <= 100)
        {
            tiendien = sokwh * 1.866m;
        }
        else if (sokwh > 100 && sokwh <= 200)
        {
            tiendien = sokwh * 2.167m;
        }
        else if (sokwh > 200 && sokwh <= 300)
        {
            tiendien = sokwh * 2.729m;
        }
        else
        {
            tiendien = sokwh * 3.050m;
        }
        decimal thuevat = tiendien * 0.08m;
        decimal tongtien = tiendien + thuevat;
        Console.WriteLine("----ket qua----");
        Console.WriteLine("so dien tieu thu = " + sokwh.ToString("F1"));
        Console.WriteLine("tien dien chua thue = " + tiendien.ToString("F1"));
        Console.WriteLine("thue vat = " + thuevat.ToString("F1"));
        Console.WriteLine("tong thanh toan = " + tongtien.ToString("F1"));


    }
    static void ex02()
    {
        Console.WriteLine("BAI TAP 2");
        Console.Write("nhap chieu cao: ");
        double chieucao = double.Parse(Console.ReadLine());
        Console.Write("nhap can nang: ");
        double cannang = double.Parse(Console.ReadLine());
        double BMI = cannang / Math.Pow(chieucao,2) ;
        string phanloai;

        if (BMI <= 18.5)
        {
            phanloai = "gay (thieu can)";
        }

        else if (18.5 <= BMI && BMI < 25)
        {
            phanloai = "binhthuong (ly tuong)";
        }
        else if (23.0 <= BMI && BMI < 25.0)
        {
            phanloai = "thuacan (tien beo phi)";
        }
        else
        {
            phanloai = "beo phi";
        }
        double toithieu = 18.5 * Math.Pow(chieucao, 2);
        double toida = 22.9 * Math.Pow(chieucao, 2);
        Console.WriteLine("----ket qua----");
        Console.WriteLine("chi so BMI cua ban: " + Math.Round(BMI,2)); 
        Console.WriteLine("phan loai suc khoe: " + phanloai);
        Console.WriteLine("khuyen dung: " +"can nang ly tuong cua ban nen tu "+Math.Round(toithieu,2) +" den "+Math.Round(toida,2) );
    }
    enum CurrentcyType
    {
        USD,
        EUR,
        PJY,
        GBP
    }
    static void ex03()
    {
        Console.WriteLine("BAI TAP 3");
        const decimal tygiaUSD = 25.400m;
        const decimal tygiaEUR = 27.200m;
        const decimal tygiaJPY = 165m;
        const decimal tygiaGBP = 32.100m;

        Console.Write("nhap so tien can doi: ");
        decimal sotien = decimal.Parse(Console.ReadLine());

        Console.Write("chon ngoai te( 1 - USD 2 -EUR 3 - JPY 4 - GBP): ");
        int luachon = int .Parse(Console.ReadLine());
        decimal phidichvu = sotien * 0.005m;
        decimal tienthat = sotien - phidichvu;

        decimal tygia = 0;
        string kyhieu = "";

        if (luachon == 1)
        {
            tygia = 25.400m;
            kyhieu = "USD";
        }
        else if (luachon == 2)
        {
            tygia = 27.200m;
            kyhieu = "EUR";
        }
        else if (luachon == 3)
        {
            tygia = 165m;
            kyhieu = "JPY";

        }
        else if (luachon == 4)
        {
            tygia = 32.100m;
            kyhieu = "GBP";
        }
        else
        {
            Console.WriteLine("lua chon khong hop le");
            return;
        }

        decimal sotienquydoi = tienthat * 1 / tygia;
        Console.WriteLine("ket qua");
        Console.WriteLine("phi dich vu (0.5%): "+ phidichvu.ToString("F1"));
        Console.WriteLine("so tien VN tinh doi: "+ tienthat.ToString("F1"));
        Console.WriteLine("so tien " + kyhieu + " nhan duoc :" + sotienquydoi.ToString("F1"));

    }
    static void ex04()
    {
        Console.Write("BÀI TẬP 4");
        Console.Write("nhap ngay sinh (dd/MM/yyyy): ");
        string chuoingaysinh = Console.ReadLine();
        DateTime ngaysinh;
        bool hople = DateTime.TryParseExact(
            chuoingaysinh,
            "dd,MM,yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out ngaysinh
        );
        if (!hople)
        {
            Console.WriteLine("ngay sinh khong dung dinh dang");
            return;
        }
        DateTime homnay = DateTime.Now.Date;
        int tuoi = homnay.Year - ngaysinh.Year;
        if ( homnay.Month < ngaysinh.Month || homnay.Month == ngaysinh.Month&&homnay.Day<ngaysinh.Day )
        {
            tuoi--;
        }
        TimeSpan songaydasong = homnay - ngaysinh;
        DateTime sinhnhatieptheo = new DateTime(homnay.Year,ngaysinh.Month,ngaysinh.Day);
        if(homnay > sinhnhatieptheo)
        {
            sinhnhatieptheo = sinhnhatieptheo.AddYears(1);

        }
        TimeSpan sonngayconlai = sinhnhatieptheo - homnay;

        Console.WriteLine("ket qua");
        Console.WriteLine("so tuoi hien tai: "+ tuoi);
        Console.WriteLine( "ban da song tong cong: "+songaydasong+" ngay");
    }
    
    static void ex05()
    {
        Console.WriteLine("BÀI TẬP 5");
        Console.Write("csharp(4 TC): ");
        double tccsharp = double .Parse(Console.ReadLine());
        int csharp = 4;
        Console.Write("toan(3 TC): ");
        double toan = double .Parse(Console.ReadLine());
        int toanrr = 3;  
        Console.Write("tienganh(2 TC): ");
        double tienganh = double .Parse(Console.ReadLine());
        int ta = 2;
        
        double tongtc = csharp + toanrr + tienganh;
        double diemtb = (tccsharp + toan + tienganh)/3;
        double diemtbts = (tccsharp*csharp + toan* toanrr + tienganh*ta) / tongtc;
        char diemchu =' ';
        double thang4=0;
        string xeploai = "";

        if (diemtbts >= 8.5)
        {
            diemchu = 'A';
            thang4 = 4;
            xeploai = "xuatxac/gioi";
        }
        else if (diemtbts >= 7 && diemtbts <= 8.4)
        {
            diemchu = 'B';
            thang4 = 3;
            xeploai = "kha";
        }
        else if (diemtbts >= 5.5 && diemtbts <= 6.9)
        {
            diemchu = 'C';
            thang4 = 2;
            xeploai = "tb";
        }
        else if (diemtbts >= 4.0 && diemtbts <= 5.4)
        {
            diemchu = 'D';
            thang4 = 1;
            xeploai = "yeu";
        }
        else if (diemtbts <4)
        {
            diemchu = 'F';
            thang4 = 0;
            xeploai = "kem";
        
        }

        Console.WriteLine($"Diem TB Thang 10: {diemtb:F2}");
        Console.WriteLine($"Diem Chu Quy Doi: {diemchu}");
        Console.WriteLine($"Diem GPA Thang 4: {thang4:F2}");
        Console.WriteLine($"Xep Loai Hoc Luc: {xeploai}");





    }
          








    static void Main()
    {
        ex01();
        ex02();
        ex03();
        ex04();
        ex05();
    }
}
        
   
