using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
enum CurrencyType
{
    Pending = 1,
    Processing = 2,
    Shipped = 3,
    Delivered = 4,
    Cancelled= 5,

}
enum CurrencyType1
{
    bike,
    car
}
    


class program
{
    static void EX01()
    {
        Console.Write("tuổi: ");
        double tuoi = double.Parse(Console.ReadLine());
        Console.Write("giờ chiếu: ");
        double giochieu = double.Parse(Console.ReadLine());

        decimal giave = 0;
        if (tuoi > 60 || tuoi < 12)
        {
            giave = 50;
        }
        else
        {
            if (giochieu < 17)
            {
                giave = 80;
            }
            else
            {
                giave = 110;
            }

        }
        Console.WriteLine($"Gia ve cua ban la: {giave}");
    }
    static void EX02()
    {
        Console.Write("nhập chức vụ(ADMIN, MANAGER, EMPLOYEE, GUEST): ");
        string chucvu = Console.ReadLine();

        if (chucvu == "ADMIN")
        {
            Console.WriteLine("Toàn quyền quản trị hệ thống.");
        }
        else if (chucvu == "MANAGER")
        {
            Console.WriteLine("Quyền quản lý nhân sự và xem báo cáo.");
        }
        else if (chucvu == "EMPLOYEE")
        {
            Console.WriteLine("Quyền tạo và chỉnh sửa hồ sơ cá nhân.");
        }
        else
        {
            Console.WriteLine("Chỉ có quyền xem thông tin công khai.");
        }    
    }
    static void EX03()
    {
        Console.Write("nhap so du tai khoan: ");
        decimal sodu = decimal.Parse(Console.ReadLine());
        Console.Write("so tien muon rut: ");
        decimal sotien = decimal.Parse(Console.ReadLine());

        if (sotien <= 0)
        {
            Console.WriteLine("Lỗi, Số tiền rút phải lớn hơn 0");
           

        }
        else if (sotien % 50 != 0)
        {
            Console.WriteLine("Lỗi, Số tiền rút phải là bội số của 50,000 VNĐ");
           
        }
        else if (sotien > sodu)
        {
            Console.WriteLine("Lỗi, Số tiền rút không vượt quá số dư hiện tại");
           
        }
        else if (sotien > 5000)
        {
            Console.WriteLine("Lỗi,  Hạn mức rút tối đa 5,000,000 VNĐ / lần.");
            
        }
        else
        {
            Console.WriteLine($"giao dịch thành công. số dư còn lại {sodu - sotien}");
        }
            

    }
    static void EX04()
    {
        Console.Write("nhập số(0 - 4): ");
        int so = int.Parse(Console.ReadLine());
            

        switch (so)
        {
            case 0:
                Console.WriteLine("[Tổng đài]: quay lai menu chinh");
                break;
            case 1:
                Console.WriteLine("[Tổng đài]: Gặp tổng đài viên tư vấn thẻ");
                break;
            case 2:
                Console.WriteLine("[Tổng đài]: Tra cứu số dư tài khoản");
                break;
            case 3:
                Console.WriteLine("[Tổng đài]: Báo khóa thẻ khẩn cấp");
                break ;
            case 4:
                Console.WriteLine("[Tổng đài]: Tra cứu tỷ giá ngoại tệ");
                break;
            default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại!");
                break;

        }

    }
    static void EX05()
    {
        Console.Write("nhap so km: ");
        double km = double.Parse(Console.ReadLine());


        double sotien = 0;
        if (km < 0)
        {
            Console.WriteLine("khong hop le");
            return;
        }

        if (km > 0 && km <= 1)
        {
            sotien = 15000;
        }
        else if (km >= 2 && km <= 10)
        {
            sotien = 15000 + (km -1) *12000;
        }
        else
        {
            sotien = 15000 + 9 * 12000 + (km - 10) * 10000;
        }
        Console.WriteLine($"tong tien truoc giam: {sotien:N0}");

        double thanhtien = sotien;
        ;
        if (km > 30)
        {
            double khuyenmai = sotien * 0.1;
            thanhtien = sotien - khuyenmai;
            Console.WriteLine($"khuyen mai( 10% ): -{ khuyenmai:N0}  ");
        }
    }
    static void EX06()
    {
        Console.Write("nhập trạng thái đơn hàng(1: Pending, 2: Processing, 3: Shipped, 4: Delivered, 5: Cancelled): ");
        int nhap =int.Parse(Console.ReadLine());
        if (!Enum.IsDefined(typeof(CurrencyType), nhap))
        {
            Console.WriteLine("lua chon khong hop le");
            return;
        }
        CurrencyType luachon = (CurrencyType)nhap;
        switch (luachon)
        {
            case CurrencyType.Pending:
                Console.WriteLine("[Trạng thái]: Chờ xác nhận thanh toán.");
                break;
            case CurrencyType.Processing:
                Console.WriteLine("[Trạng thái]: Đang đóng gói và bàn giao đơn vị vận chuyển.");
                break;
            case CurrencyType.Shipped:
                Console.WriteLine("[Trạng thái]: Đơn hàng đang trên đường giao đến bạn.");
                break;
            case CurrencyType.Delivered:
                Console.WriteLine("[Trạng thái]: Đơn hàng đã hoàn thành. Cảm ơn bạn!");
                break;
            case CurrencyType.Cancelled:
                Console.WriteLine("[Trạng thái]: Đơn hàng đã hủy. Xuất phiếu hoàn tiền.");
                break;
                
        }
    }
    static void EX07()
    {
        Console.Write("nhập chiều cao: ");
        double chieucao = double.Parse(Console.ReadLine());
        Console.Write("nhập cân nặng: ");
        double cannang = double.Parse(Console.ReadLine());
        double BMI = cannang / Math.Pow(chieucao, 2);
        Console.WriteLine($"BMI: {BMI:F2}");

        if (BMI < 18.5)
        {
            Console.WriteLine("Thầy gầy - Nên bổ sung dinh dưỡng.");
        }
        else if (18.5 <= BMI && BMI < 25)
        {
            Console.WriteLine("Cân đối - Tiếp tục duy trì..");
        }
        else if (25 <= BMI && BMI < 30)
        {
            Console.WriteLine("Thừa cân - Nên tăng cường luyện tập.");
        }
        else if(BMI >= 30)
        {
            Console.WriteLine("Béo phì - Cần sự tư vấn từ bác sĩ.");
        }    
    }
    static void EX08()
    {
        Console.WriteLine("nhập loại xe (BIKE hoặc CAR): ");
        string xe = Console.ReadLine().Trim().ToUpper();

        Console.WriteLine("nhập thời gian gửi (1-Ban ngày, 2-Ban đêm): ");
        int time = int.Parse(Console.ReadLine());

        if (xe != "BIKE" && xe != "CAR")
        {
            Console.WriteLine("nhap sai loai xe");
            return;
        }

        if (time != 1 && time != 2)
        {
            Console.WriteLine("nhap sai thoi gian");
            return;
        }

        int phi = 0;
        string tenXe = "";

        switch (xe)
        {
            case "BIKE":
                tenXe = "xe máy";
                phi = (time == 1) ? 5000 : 10000;
                break;

            case "CAR":
                tenXe = "Ô tô";
                phi = (time == 1) ? 30000 : 60000;
                break;
        }

        string banGi = (time == 1) ? "Ban ngày" : "Ban đêm";
        Console.WriteLine($"Phí gửi xe {tenXe} ({banGi}): {phi:N0} VNĐ");
    }
    static void EX09()
    {
        Console.WriteLine("nhập điểm trung bình tích lũy (GPA, hệ 4.0): ");
        double gpa = double.Parse(Console.ReadLine());

        Console.WriteLine("nhập điểm rèn luyện (DRL, hệ 100): ");
        double drl = double.Parse(Console.ReadLine());

        if (gpa >= 3.6 && drl >= 90)
        {
            Console.WriteLine("Kết quả: Học bổng Xuất sắc (Mức 100%)");
        }
        else if (gpa >= 3.2 && drl >= 80)
        {
            string lyDo = "";

            if (gpa < 3.6)
                lyDo = $"Do GPA < 3.6";
            else if (drl < 90)
                lyDo = $"Do DRL < 90";

            Console.WriteLine($"Kết quả: Học bổng Khá/Giỏi (Mức 50%) ({lyDo})");
        }
        else
        {
            Console.WriteLine("Kết quả: Không đạt học bổng");
        }
    }
    static void EX10()
    {
        Console.WriteLine("nhập số tiền (VNĐ): ");
        double soTien = double.Parse(Console.ReadLine());

        Console.WriteLine("nhập mã ngoại tệ (USD, EUR, JPY): ");
        string maNgoaiTe = Console.ReadLine().Trim().ToUpper();

        double tyGia = 0;

        switch (maNgoaiTe)
        {
            case "USD":
                tyGia = 25400;
                break;

            case "EUR":
                tyGia = 27200;
                break;

            case "JPY":
                tyGia = 165;
                break;

            default:
                Console.WriteLine("Mã ngoại tệ không hợp lệ");
                return;
        }

        double ketQua = soTien / tyGia;
        Console.WriteLine($"Số tiền sau quy đổi: {ketQua:N2} {maNgoaiTe}");
    }
    static void Main()
    {
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
    }


}
    
  
   
