using System;
using System.Collections.Generic;

class Program
{
    static void EX01()
    {
        int[][] arr = new int[4][];
        arr[0] = new int[] { 1, 1, 1, 1, 1 };
        arr[1] = new int[] { 2, 2 };
        arr[2] = new int[] { 3, 3, 3, 3 };
        arr[3] = new int[] { 4, 4 };

        HienThiJaggedArray(arr);
    }

    static void HienThiJaggedArray(int[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[][] EX02_TaoJaggedArray()
    {
        Console.Write("\nNhập số dòng: ");
        int soDong = int.Parse(Console.ReadLine());

        int[][] arr = new int[soDong][];

        for (int i = 0; i < soDong; i++)
        {
            Console.Write($"Nhập số cột cho dòng {i}: ");
            int soCot = int.Parse(Console.ReadLine());
            arr[i] = new int[soCot];

            for (int j = 0; j < soCot; j++)
            {
                Console.Write($"  arr[{i}][{j}] = ");
                arr[i][j] = int.Parse(Console.ReadLine());
            }
        }

        return arr;
    }

    static void EX02_TimMax(int[][] arr)
    {
        Console.WriteLine("\nSố lớn nhất mỗi dòng:");
        int maxToanMang = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length == 0) continue;

            int maxDong = arr[i][0];
            for (int j = 1; j < arr[i].Length; j++)
            {
                if (arr[i][j] > maxDong)
                    maxDong = arr[i][j];
            }

            Console.WriteLine($"Dòng {i}: số lớn nhất = {maxDong}");

            if (maxDong > maxToanMang)
                maxToanMang = maxDong;
        }

        Console.WriteLine($"Số lớn nhất toàn mảng: {maxToanMang}");
    }

    static void EX02_SapXepTangDan(int[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Array.Sort(arr[i]);
        }

        Console.WriteLine("\nMảng sau khi sắp xếp tăng dần mỗi dòng:");
        HienThiJaggedArray(arr);
    }

    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static void EX02_InSoNguyenTo(int[][] arr)
    {
        Console.WriteLine("\nCác số nguyên tố trong mảng:");
        bool coSoNguyenTo = false;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (LaSoNguyenTo(arr[i][j]))
                {
                    Console.WriteLine($"arr[{i}][{j}] = {arr[i][j]} là số nguyên tố");
                    coSoNguyenTo = true;
                }
            }
        }

        if (!coSoNguyenTo)
            Console.WriteLine("Không có số nguyên tố nào trong mảng.");
    }

    static void EX02_TimViTri(int[][] arr)
    {
        Console.Write("\nNhập số cần tìm: ");
        int soCanTim = int.Parse(Console.ReadLine());

        bool timThay = false;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] == soCanTim)
                {
                    Console.WriteLine($"Tìm thấy tại arr[{i}][{j}]");
                    timThay = true;
                }
            }
        }

        if (!timThay)
            Console.WriteLine($"Không tìm thấy số {soCanTim} trong mảng.");
    }

    static void EX02()
    {
        int[][] arr = EX02_TaoJaggedArray();

        Console.WriteLine("\nMảng vừa nhập:");
        HienThiJaggedArray(arr);

        bool thoat = false;
        while (!thoat)
        {
            Console.WriteLine("\nMenu EX02");
            Console.WriteLine("1. Tìm số lớn nhất mỗi dòng và toàn mảng");
            Console.WriteLine("2. Sắp xếp tăng dần mỗi dòng");
            Console.WriteLine("3. In các số nguyên tố");
            Console.WriteLine("4. Tìm vị trí của 1 số");
            Console.WriteLine("0. Quay lại menu chính");
            Console.Write("Chọn: ");

            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    EX02_TimMax(arr);
                    break;
                case "2":
                    EX02_SapXepTangDan(arr);
                    break;
                case "3":
                    EX02_InSoNguyenTo(arr);
                    break;
                case "4":
                    EX02_TimViTri(arr);
                    break;
                case "0":
                    thoat = true;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }
    }

    static string[][] members = new string[14][];

    static void EX03_KhoiTaoMacDinh()
    {
        string[][] duLieuMau = new string[][]
        {
            new string[] { "G1-01", "Nguyen Van A", "5" },
            new string[] { "G1-02", "Tran Thi B",   "3" },
            new string[] { "G1-03", "Le Van C",     "8" },
            new string[] { "G1-04", "Pham Thi D",   "2" },
            new string[] { "G1-05", "Hoang Van E",  "6" },

            new string[] { "G2-01", "Vu Thi F",     "4" },
            new string[] { "G2-02", "Do Van G",     "9" },
            new string[] { "G2-03", "Bui Thi H",    "1" },

            new string[] { "G3-01", "Ngo Van I",    "7" },
            new string[] { "G3-02", "Dang Thi K",   "3" },
            new string[] { "G3-03", "Ly Van L",     "10" },
            new string[] { "G3-04", "Trinh Thi M",  "5" },
            new string[] { "G3-05", "Mai Van N",    "6" },
            new string[] { "G3-06", "Phan Thi O",   "2" },
        };

        members = duLieuMau;
    }

    static void EX03_NhapTuBanPhim()
    {
        int[] soLuongMoiNhom = { 5, 3, 6 };
        int chiSo = 0;

        for (int g = 0; g < soLuongMoiNhom.Length; g++)
        {
            Console.WriteLine($"\nNhập thông tin nhóm {g + 1} ({soLuongMoiNhom[g]} thành viên)");

            for (int i = 0; i < soLuongMoiNhom[g]; i++)
            {
                Console.Write($"  ID thành viên {i + 1}: ");
                string id = Console.ReadLine();

                Console.Write("  Họ tên: ");
                string ten = Console.ReadLine();

                Console.Write("  Số công việc hoàn thành: ");
                string congViec = Console.ReadLine();

                members[chiSo] = new string[] { id, ten, congViec };
                chiSo++;
            }
        }
    }

    static void EX03_InDanhSach()
    {
        Console.WriteLine("\nDanh sách tất cả thành viên:");
        Console.WriteLine($"{"ID",-8}{"Họ tên",-20}{"Số CV hoàn thành",-15}");

        for (int i = 0; i < members.Length; i++)
        {
            if (members[i] == null) continue;
            Console.WriteLine($"{members[i][0],-8}{members[i][1],-20}{members[i][2],-15}");
        }
    }

    static void EX03_TimTheoID()
    {
        Console.Write("\nNhập ID cần tìm: ");
        string id = Console.ReadLine();

        bool timThay = false;

        for (int i = 0; i < members.Length; i++)
        {
            if (members[i] == null) continue;

            if (members[i][0].Equals(id, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"ID: {members[i][0]}");
                Console.WriteLine($"Họ tên: {members[i][1]}");
                Console.WriteLine($"Số công việc hoàn thành: {members[i][2]}");
                timThay = true;
                break;
            }
        }

        if (!timThay)
            Console.WriteLine($"Không tìm thấy thành viên có ID: {id}");
    }

    static void EX03_ThanhVienXuatSac()
    {
        int chiSoMax = -1;
        int maxCongViec = int.MinValue;

        for (int i = 0; i < members.Length; i++)
        {
            if (members[i] == null) continue;

            int congViec = int.Parse(members[i][2]);
            if (congViec > maxCongViec)
            {
                maxCongViec = congViec;
                chiSoMax = i;
            }
        }

        if (chiSoMax == -1)
        {
            Console.WriteLine("Chưa có dữ liệu thành viên.");
            return;
        }

        Console.WriteLine("\nThành viên hoàn thành nhiều công việc nhất:");
        Console.WriteLine($"ID: {members[chiSoMax][0]}");
        Console.WriteLine($"Họ tên: {members[chiSoMax][1]}");
        Console.WriteLine($"Số công việc hoàn thành: {members[chiSoMax][2]}");
    }

    static void EX03()
    {
        Console.WriteLine("1. Dùng dữ liệu mẫu có sẵn");
        Console.WriteLine("2. Nhập dữ liệu từ bàn phím");
        Console.Write("Chọn: ");
        string khoiTao = Console.ReadLine();

        if (khoiTao == "2")
            EX03_NhapTuBanPhim();
        else
            EX03_KhoiTaoMacDinh();

        bool thoat = false;
        while (!thoat)
        {
            Console.WriteLine("\nMenu EX03");
            Console.WriteLine("1. In danh sách tất cả thành viên");
            Console.WriteLine("2. Tìm thông tin thành viên theo ID");
            Console.WriteLine("3. In thành viên hoàn thành nhiều công việc nhất");
            Console.WriteLine("0. Quay lại menu chính");
            Console.Write("Chọn: ");

            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    EX03_InDanhSach();
                    break;
                case "2":
                    EX03_TimTheoID();
                    break;
                case "3":
                    EX03_ThanhVienXuatSac();
                    break;
                case "0":
                    thoat = true;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        EX01();
        EX02();
        EX03();
    }
}