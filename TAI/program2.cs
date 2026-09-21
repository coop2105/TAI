//using System;
//using System.Text;

//namespace _26C1INF50900505_CSLT.session05
//{

//    internal class Program
//    {

//        public static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            Console.InputEncoding = Encoding.UTF8;

//            Ex_03.Run();
//            Ex_04.Run();
//        }
//    }

//    internal class Ex_03
//    {

//        public static void Run()
//        {
//            Console.WriteLine("""
//                                ________  .__                 ________                       
//                \______ \ |__| ____  ____    /  _____/_____    _____   ____  
//                 |    |  \|  |/ ___\/ __ \  /   \  ___\__  \  /     \_/ __ \ 
//                 |    `   \  \  \__\  ___/  \    \_\  \/ __ \|  Y Y  \  ___/ 
//                /_______  /__|\___  >___  >  \______  (____  /__|_|  /\___  >
//                        \/        \/    \/          \/     \/      \/     \/ 
//                """);
//            dice_game();
//        }

//        public static void dice_game()
//        {
//            long tien = 1000_000;
//            int soLanChoi = 0;
//            int soLanThua = 0;
//            int soLanDacBiet = 0;
//            bool continuePlaying = true;

//            do
//            {
//                soLanChoi++;

//                long tienDatCuoc = DocTienCuoc(tien);
//                (int dice1, int dice2, int sum) = GieoSucSac();
//                string guess = DocLuaChonDoan();

//                Console.WriteLine($"Ket qua gieo suc sac: {dice1} + {dice2} = {sum}");

//                (bool isWin, bool isSpecial) = KiemTraKetQua(guess, sum);

//                if (isWin)
//                {
//                    if (isSpecial)
//                    {
//                        soLanDacBiet++;
//                        tien += tienDatCuoc * 3;
//                        Console.WriteLine($"Ban thang dac biet! Tong so tien hien tai: {tien} dong.");
//                    }
//                    else
//                    {
//                        tien += tienDatCuoc;
//                        Console.WriteLine($"Ban thang! Tong so tien hien tai: {tien} dong.");
//                    }
//                }
//                else
//                {
//                    tien -= tienDatCuoc;
//                    soLanThua++;
//                    Console.WriteLine($"Ban thua! Tong so tien hien tai: {tien} dong.");
//                }

//                continuePlaying = HoiChoiTiep() && tien > 0;

//            } while (continuePlaying);

//            InThongKe(soLanChoi, soLanThua, soLanDacBiet);
//        }

//        static long DocTienCuoc(long tien)
//        {
//            long tienDatCuoc = 0;
//            Console.Write($"Ban co {tien} dong. Ban dat bao nhieu? ");
//            do
//            {
//                bool ok = long.TryParse(Console.ReadLine(), out long result);
//                if (ok && result <= tien && result > 1000)
//                {
//                    tienDatCuoc = result;
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Vui long nhap mot so hop le hoac so tien dat " +
//                        $"cuoc khong duoc vuot qua so tien hien co {tien}. Hoac tren 1000 dong");
//                    Console.Write("Ban dat bao nhieu? ");
//                }
//            } while (true);
//            return tienDatCuoc;
//        }

//        static (int, int, int) GieoSucSac()
//        {
//            Random rand = new Random();
//            int dice1 = rand.Next(1, 7);
//            int dice2 = rand.Next(1, 7);
//            return (dice1, dice2, dice1 + dice2);
//        }

//        static string DocLuaChonDoan()
//        {
//            string guess;
//            do
//            {
//                Console.Write("Ban doan tai (T), xiu (X) hay luc (L)? ");
//                guess = Console.ReadLine().ToLower();
//                if (guess != "t" && guess != "x" && guess != "l")
//                {
//                    Console.WriteLine("Vui long nhap T, X hoac L.");
//                }
//                else
//                {
//                    break;
//                }
//            } while (true);
//            return guess;
//        }

//        static (bool, bool) KiemTraKetQua(string guess, int sum)
//        {
//            bool isWin = false;
//            bool isSpecial = false;
//            if (guess == "t" && sum > 6)
//            {
//                isWin = true;
//            }
//            else if (guess == "x" && sum < 6)
//            {
//                isWin = true;
//            }
//            else if (guess == "l" && sum == 6)
//            {
//                isWin = true;
//                isSpecial = true;
//            }
//            return (isWin, isSpecial);
//        }

//        static bool HoiChoiTiep()
//        {
//            Console.Write("\nBan co muon choi tiep khong? (C/K): ");
//            string input = Console.ReadLine();
//            return input.ToLower() != "k";
//        }

//        static void InThongKe(int soLanChoi, int soLanThua, int soLanDacBiet)
//        {
//            Console.WriteLine($"\nTro choi ket thuc!");
//            Console.WriteLine($"Tong so lan choi: {soLanChoi}");
//            Console.WriteLine($"Tong so lan thang: {soLanChoi - soLanThua - soLanDacBiet}");
//            Console.WriteLine($"Tong so lan thua: {soLanThua}");
//            Console.WriteLine($"Tong so lan thang dac biet: {soLanDacBiet}");
//        }
//    }

//    internal class Ex_04
//    {

//        public static void Run()
//        {
//            Console.WriteLine("""
//                _________ ______      _____ 
//                \_   ___ \\____ \    /  _  \ 
//                /    \  \/|  |_> >  /  /_\  \
//                \     \___|    |    \   |  |  \
//                 \______  /__|      \____|__  /
//                        \/                  \/ 
//                """);
//            guess_number_game();
//        }

//        public static void guess_number_game()
//        {
//            long tien = 1000_000;
//            int soLanChoi = 0;
//            int soLanThua = 0;

//            bool continuePlaying = true;
//            do
//            {
//                soLanChoi++;

//                long tienDatCuoc = DocTienCuoc(tien);
//                (int soLanDoan, double heSoThuong) = DocMucDoKho();

//                bool isWin = ChoiVan(soLanDoan);

//                if (isWin)
//                {
//                    long tienThuong = (long)(tienDatCuoc * heSoThuong);
//                    tien += tienThuong;
//                    Console.WriteLine($"Ban thang! Duoc thuong {tienThuong} dong. Tong so tien hien tai: {tien} dong.");
//                }
//                else
//                {
//                    tien -= tienDatCuoc;
//                    soLanThua++;
//                    Console.WriteLine($"Ban thua! Tong so tien hien tai: {tien} dong.");
//                }

//                if (tien <= 0)
//                {
//                    Console.WriteLine("\nBan da het tien! Tro choi ket thuc.");
//                    continuePlaying = false;
//                }
//                else
//                {
//                    continuePlaying = HoiChoiTiep();
//                }

//            } while (continuePlaying);

//            InThongKe(soLanChoi, soLanThua);
//        }

//        static long DocTienCuoc(long tien)
//        {
//            long tienDatCuoc = 0;
//            Console.Write($"Ban co {tien} dong. Ban dat bao nhieu? ");
//            do
//            {
//                bool ok = long.TryParse(Console.ReadLine(), out long result);
//                if (ok && result <= tien && result > 1000)
//                {
//                    tienDatCuoc = result;
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Vui long nhap mot so hop le hoac so tien dat " +
//                        $"cuoc khong duoc vuot qua so tien hien co {tien}. Hoac tren 1000 dong");
//                    Console.Write("Ban dat bao nhieu? ");
//                }
//            } while (true);
//            return tienDatCuoc;
//        }

//        static (int, double) DocMucDoKho()
//        {
//            do
//            {
//                Console.Write("Chon muc do (1: De - 9 luot doan, 2: Trung binh - 6 luot doan, 3: Kho - 4 luot doan): ");
//                bool ok = int.TryParse(Console.ReadLine(), out int level);
//                if (ok)
//                {
//                    switch (level)
//                    {
//                        case 1: return (9, 0.5);
//                        case 2: return (6, 1.0);
//                        case 3: return (4, 3.0);
//                    }
//                }
//                Console.WriteLine("Vui long nhap 1, 2 hoac 3.");
//            } while (true);
//        }

//        static bool ChoiVan(int soLanDoan)
//        {
//            Random rand = new Random();
//            int soCanDoan = rand.Next(1, 101);

//            for (int luot = 1; luot <= soLanDoan; luot++)
//            {
//                int doan = DocSoDoan(luot, soLanDoan);

//                if (doan == soCanDoan)
//                {
//                    Console.WriteLine($"Chinh xac! So can tim la {soCanDoan}.");
//                    return true;
//                }
//                else if (doan < soCanDoan)
//                {
//                    Console.WriteLine("So can tim LON HON so ban vua doan.");
//                }
//                else
//                {
//                    Console.WriteLine("So can tim NHO HON so ban vua doan.");
//                }
//            }

//            Console.WriteLine($"Ban da het luot doan! So can tim la {soCanDoan}.");
//            return false;
//        }

//        static int DocSoDoan(int luot, int tongSoLuot)
//        {
//            do
//            {
//                Console.Write($"Luot {luot}/{tongSoLuot} - Ban doan so nao (1-100)? ");
//                bool ok = int.TryParse(Console.ReadLine(), out int doan);
//                if (ok && doan >= 1 && doan <= 100)
//                {
//                    return doan;
//                }
//                Console.WriteLine("Vui long nhap mot so tu 1 den 100.");
//            } while (true);
//        }

//        static bool HoiChoiTiep()
//        {
//            Console.Write("\nBan co muon choi tiep khong? (C/K): ");
//            string input = Console.ReadLine();
//            return input.ToLower() != "k";
//        }

//        static void InThongKe(int soLanChoi, int soLanThua)
//        {
//            Console.WriteLine($"\nTro choi ket thuc!");
//            Console.WriteLine($"Tong so lan choi: {soLanChoi}");
//            Console.WriteLine($"Tong so lan thang: {soLanChoi - soLanThua}");
//            Console.WriteLine($"Tong so lan thua: {soLanThua}");
//        }
//    }
//}
