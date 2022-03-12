namespace BaiTapSinhVien
{
    internal class Handing
    {
        private static List<SinhVien> listSinhVien = new List<SinhVien>();
        private static List<SinhVien> tempList = new List<SinhVien>();
        public static int number = 0;
        public static int width = 55;


        public static void program11() //Xuất thông tin người viết chương trình
        {
            centerWrite(17); Console.WriteLine("Chương trình số 11");
            centerWrite(12);
            Console.WriteLine("Trần Phú Đạt");
            centerWrite(27);
            Console.WriteLine("Address: Phu Yen - Viet Nam");
            centerWrite(24);
            Console.WriteLine("College: FPT Polytechnic");
            centerWrite(19);
            Console.WriteLine("Contact: 0985950723");
            centerWrite(29);
            Console.WriteLine("Contact: cctalk1114@gmail.com");
            centerWrite(46);
            Console.WriteLine("Facebook: https://www.facebook.com/Jayzneverzz");
            notification1();
        }

        public static void program10()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 10");
            if (listSinhVien.Count == 0)
            {
                notificationNoDataBase();
            }
            else
            {
                Console.WriteLine($"Số sinh viên học lực Xuất sắc: {countRank("Xuất sắc")}");
                Console.WriteLine($"Số sinh viên học lực Giỏi: {countRank("Giỏi")}");
                Console.WriteLine($"Số sinh viên học lực Khá: {countRank("Khá")}");
                Console.WriteLine($"Số sinh viên học lực Trung bình: {countRank("Trung bình")}");
                Console.WriteLine($"Số sinh viên học lực Yếu: {countRank("Yếu")}");
            }
            notification1();
        }

        public static void program9()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 9");
            if (listSinhVien.Count == 0)
            {
                notificationNoDataBase();//Thông báo khi không có dữ liệu
            }
            else
            {
                FilterpointOver5();//Kiểm tra điểm > trung bình của sinh viên
                OutputFilter();//xuất dánh sách sau khi lọc
            }
            notification1();
        }

        public static void program8()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 8");
            if (listSinhVien.Count == 0)
            {
                notificationNoDataBase();//Thông báo khi không có dữ liệu
            }
            else
            {
                centerWrite(28);
                //Điểm trung bình cả lớp sau tính toán
                Console.WriteLine($"Điểm trung bình của lớp = {allPoints()}");
            }
            notification1();
        }

        public static void program7()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 7");
            if (listSinhVien.Count == 0)
            {
                notificationNoDataBase();//Thông báo khi không có dữ liệu
            }
            else
            {
                sortPointDown();
                OutputGoodStudent(5);
            }
            notification1();
        }

        public static void program6()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 6");
            if (listSinhVien.Count == 0)
            {
                notificationNoDataBase();//Thông báo khi không có dữ liệu
            }
            else
            {
                Console.WriteLine("\n1. Sắp xếp giảm dần\n2. Sắp xếp tăng dần\n");
                int choices = Convert.ToInt32(Console.ReadLine());

                switch (choices)
                {
                    case 1:
                        {
                            sortPointDown();
                            break;
                        }
                    case 2:
                        {
                            sortPointUp();
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }
            notification1();
        }

        public static void program5()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 5");
            if (listSinhVien.Count == 0)
            {
                notificationNoDataBase();//Thông báo khi không có dữ liệu
            }
            else
            {
                Filternumber();
            }
            notification1();
        }

        public static void program4()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 4");
            if (listSinhVien.Count == 0)
            {
                notificationNoDataBase();//Thông báo khi không có dữ liệu
            }
            else
            {
                Filterrank();//Lọc xếp loại sinh viên
                OutputFilter();//Xuất thông tin sau khi lọc
            }
            notification1();//Thông báo nhấn 1 phím bất kì
        }

        public static void program3()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 3");
            if (listSinhVien.Count == 0)
            {
                notificationNoDataBase();
            }
            else
            {
                Filterpoint();//Set filter point trong khoảng min, max
                OutputFilter();//Xuất ra filter point
            }
            notification1();
        }

        public static void program2()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 2");
            if (listSinhVien.Count == 0)
            {
                notificationNoDataBase();
            }
            else
            {
                Output();//Xuất list sinh viên
            }
            notification1();
        }

        public static void program1()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 1");
            Input();//Nhập list sinh viên
            notification1();
        }

        /*Xử lý mã số của sinh viên*/
        #region Number
        public static void Filternumber()
        {
            centerWrite(24); Console.Write("Nhập mã số sinh viên: ");
            string? numberInput = (Console.ReadLine());
            bool check = false;
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                if (listSinhVien[i].getNumber == Convert.ToInt32(String.Format("{0:0000}", numberInput)))
                {
                    check = true;
                    listSinhVien[i].output(i + 1);
                    UpdateSinhVien(i);
                    Console.WriteLine("Sau cập nhật:_______");
                    listSinhVien[i].output(i + 1);
                }
            }
            if (check == false)
            {
                centerWrite(43); Console.WriteLine($"Không có sinh viên mã số {numberInput} trong danh sách ");
            }
        }
        public static void UpdateSinhVien(int i) //Cập nhật thông tin sinh viên
        {
            string text = @"
[[==================================================]]
||               1. Cập nhật tên                    ||
||               2. Cập nhật điểm                   ||
||               3. Cập nhật email                  ||
||__________________________________________________||
||               0. Thoát chương trình              ||
[[==================================================]]";
            Console.WriteLine(text);
            bool updateIn4 = true;
            do
            {
                int choice;
                try
                {
                    centerWrite(29); Console.WriteLine("Nhập thông tin cần cập nhật: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    choice = 5;
                }

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"Tên cũ: {listSinhVien[i].getName}");
                            Console.Write("Nhập tên mới: ");
                            listSinhVien[i].getName = Console.ReadLine();
                            Console.WriteLine("Hoàn thành cập nhật");

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Điểm cũ: {listSinhVien[i].getPoint}");
                            Console.Write("Nhập điểm mới: ");

                            try
                            {
                                listSinhVien[i].getPoint = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (System.Exception)
                            {
                                listSinhVien[i].getPoint = 11;
                            }

                            Console.WriteLine("Hoàn thành cập nhật");

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Gmail: {listSinhVien[i].getEmail}");
                            Console.Write("Nhập điểm mới: ");
                            listSinhVien[i].getEmail = Console.ReadLine();
                            Console.WriteLine("Hoàn thành cập nhật");

                            break;
                        }
                    case 0:
                        {
                            updateIn4 = false;
                            break;
                        }
                    default:
                        {
                            notificationError();
                            break;
                        }
                }

            }
            while (updateIn4 == true);
        }
        #endregion

        /*Xử lý nhập xuất trên Console*/
        #region In&Out
        public static void Input()
        {
            for (int i = 0; ; i++)
            {
                SinhVien sv = new SinhVien();
                number += 1;
                sv.input(number);
                listSinhVien.Add(sv);
                Console.WriteLine();
                Console.Write("Bạn có muốn nhập tiếp không?  (y/n): ");
                String? n = Console.ReadLine();
                if (n == "n" || n == "N")
                {
                    break;
                }
            }
        }
        public static void Output()//xuất ra danh sách sinh viên
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                listSinhVien[i].output(i + 1);
            }
        }
        public static void OutputGoodStudent(int numberStudent)
        {
            for (int i = 0; i < numberStudent; i++)
            {
                listSinhVien[i].output(i + 1);
            }
        }
        public static void OutputFilter()//Xuất list tạm đã xữ lý ra ngoài
        {
            for (int i = 0; i < tempList.Count; i++)
            {
                tempList[i].output(i + 1);
            }
        }
        #endregion

        /*Xử lý điểm của sinh viên*/
        #region Point
        public static void Filterpoint()//Lọc xếp loại điểm số
        {
            /*
            Có thể dùng sort point để giảm thời gian filter point
            bằng cách bỏ qua các giá trị có điểm bằng < điểm min
            Sẽ cố thực hiện trong tương lai
            */
            tempList.Clear();//Làm mới tempList
            Console.Write("Nhập min: ");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập max: ");
            double max = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                if (listSinhVien[i].getPoint >= min && listSinhVien[i].getPoint <= max)
                {
                    tempList.Add(listSinhVien[i]);
                }
            }
        }
        public static void FilterpointOver5()//Lọc xếp loại điểm số
        {
            /*
            Có thể dùng sort point để giảm thời gian filter point
            bằng cách bỏ qua các giá trị có điểm bằng < điểm min
            Sẽ cố thực hiện trong tương lai
            */
            tempList.Clear();//Làm mới tempList
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                if (listSinhVien[i].getPoint > allPoints())
                {
                    tempList.Add(listSinhVien[i]);
                }
            }
        }
        public static double allPoints()
        {
            Double point = 0;
            double count = 0;
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                point += listSinhVien[i].getPoint;
                count += 1;
            }
            Double average_Point = point / count;
            return average_Point;
        }
        #endregion

        /*Xử lý việc xếp loại sinh viên*/
        #region Rank 
        public static void Filterrank()//Lọc xếp loại học lực
        {
            tempList.Clear();
            Console.WriteLine("\n1. Xuất sắc\n2. Giỏi\n3. Khá\n4. Trung bình\n5. Yếu");
            Byte rank;
            do
            {
                try
                {
                    centerWrite(6); Console.Write("Nhập: ");
                    rank = Convert.ToByte(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    rank = 6;
                }
            }
            while (rank > 5);
            switch (rank)
            {
                case 1:
                    {
                        string keyWordRank = "Xuất sắc";
                        handleRank(keyWordRank);
                        break;
                    }
                case 2:
                    {
                        string keyWordRank = "Giỏi";
                        handleRank(keyWordRank);
                        break;
                    }
                case 3:
                    {
                        string keyWordRank = "Khá";
                        handleRank(keyWordRank);
                        break;
                    }
                case 4:
                    {
                        string keyWordRank = "Trung bình";
                        handleRank(keyWordRank);
                        break;
                    }
                case 5:
                    {
                        string keyWordRank = "Yếu";
                        handleRank(keyWordRank);
                        break;
                    }
                default:
                    {
                        Handing.notificationError();
                        break;
                    }
            }
        }
        //nếu rank == list sinhvien.getrank thì cho nó vào templist để xuất ra
        //sử dụng templist tăng bảo mật
        public static void handleRank(string rank)
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                if (rank == listSinhVien[i].getRank)
                {
                    tempList.Add(listSinhVien[i]);
                }
            }
        }
        public static int countRank(string rank)
        {
            int count = 0;
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                if (rank == listSinhVien[i].getRank)
                {
                    count += 1;
                }
            }
            return count;
        }
        #endregion

        //Sắp xếp điểm 
        #region SortPoint
        //Sắp xếp điểm tăng dần
        public static void sortPointUp()
        {
            tempList.Clear();
            tempList.Add(listSinhVien[0]);
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                for (int j = 0; j < listSinhVien.Count; j++)
                {
                    if (listSinhVien[i].getPoint < listSinhVien[j].getPoint)
                    {
                        tempList[0] = listSinhVien[i];
                        listSinhVien[i] = listSinhVien[j];
                        listSinhVien[j] = tempList[0];
                    }
                }
            }
            centerWrite(45); Console.WriteLine("Danh sách sinh viên tăng dần sắp xếp hoàn tất");
        }
        //Sắp xếp điểm giảm dần
        public static void sortPointDown()
        {
            tempList.Clear();
            tempList.Add(listSinhVien[0]);

            for (int i = 0; i < listSinhVien.Count; i++)
            {
                for (int j = 0; j < listSinhVien.Count; j++)
                {
                    if (listSinhVien[i].getPoint > listSinhVien[j].getPoint)
                    {
                        tempList[0] = listSinhVien[i];
                        listSinhVien[i] = listSinhVien[j];
                        listSinhVien[j] = tempList[0];
                    }
                }
            }
            centerWrite(45); Console.WriteLine("Danh sách sinh viên giảm dần sắp xếp hoàn tất");
        }
        #endregion

        /*Xử lý giao diện và thông báo cho chương trình*/
        #region UI
        public static byte menu()
        {
            Console.Clear();
            string menu = "";
            Console.ForegroundColor = ConsoleColor.Yellow;

            menu = @"
[[==================================================]] 
||   _   .-')       ('-.       .-') _               ||    
||  ( '.( OO )_   _(  OO)     ( OO ) )              ||
||   ,--.   ,--.)(,------.,--./ ,--,' ,--. ,--.     ||
||   |   `.'   |  |  .---'|   \ |  |\ |  | |  |     ||
||   |         |  |  |    |    \|  | )|  | | .-')   ||
||   |  |'.'|  | (|  '--. |  .     |/ |  |_|( OO )  ||
||   |  |   |  |  |  .--' |  |\    |  |  | | `-' /  ||
||   |  |   |  |  |  `---.|  | \   | ('  '-'(_.-'   ||
||   `--'   `--'  `------'`--'  `--'   `-----'      ||
||--------------------------------------------------||
||    1. Nhập danh sách học viên                    ||
||    2. Xuất danh sách học viên                    ||
||    3. Tìm học viên theo khoảng điểm              ||
||    4. Tìm học viên theo học lực                  ||
||    5. Cập nhật thông tin sinh viên theo mã số    ||
||    6. Sắp xếp học viên theo điểm                 ||
||    7. Xuất 5 học viên có điểm cao nhất           ||
||    8. Tính điểm trung bình của lớp               ||
||    9. Danh sách học viên > điểm trung bình lớp   ||
||   10. Tổng hợp số học viên theo học lực          ||
||   11. Thông tin người thực hiện                  ||
||__________________________________________________||
||    0. Thoát chương trình                         ||
[[==================================================]]";
            Console.WriteLine(menu);
            Console.ResetColor();

            centerWrite(6); Console.Write("Nhập: ");

            byte choices = Convert.ToByte(Console.ReadLine());
            return choices;
        }

        public static void endingProgram()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;//Đổi màu
            string text = "";
            text = @"    
[[==================================================]]
||     (     (                                      ||
||     )\ )  )\ )  *   )                 (          ||
||    (()/( (()/(` )  /(                 )\ (       ||
||     /(_)) /(_))( )(_))___ `  )    (  ((_))\ )    ||
||    (_))_|(_)) (_(_())|___|/(/(    )\  _ (()/(    ||
||    | |_  | _ \|_   _|    ((_)_\  ((_)| | )(_))   ||
||    | __| |  _/  | |      | '_ \)/ _ \| || || |   ||
||    |_|   |_|    |_|      | .__/ \___/|_| \_, |   ||
||                          |_|             |__/    ||
[[==================================================]]";
            Console.WriteLine(text);
            Console.ResetColor();
            notification1();
        }

        public static void notification1()
        {
            Console.SetCursorPosition((width - 32) / 2, Console.CursorTop);
            Console.Write("Nhấn bất kì phím nào để tiếp tục");
            Console.ReadKey();
        }
        public static void centerWrite(int x)
        {
            Console.SetCursorPosition((width - x) / 2, Console.CursorTop);//Di chuyển vị trí con trỏ chuột

        }

        public static void notificationError()
        {
            Console.SetCursorPosition((width - 13) / 2, Console.CursorTop);//13 là độ dài chuỗi "Lỗi nhập liệu"
            Console.WriteLine("Lỗi nhập liệu");
            notification1();
        }
        public static void notificationNoDataBase()
        {
            Console.SetCursorPosition((width - 31) / 2, Console.CursorTop);//13 là độ dài chuỗi "Lỗi nhập liệu"
            Console.WriteLine("Chưa có cơ sở dữ liệu sinh viên");
            notification1();
        }
        #endregion

    }
}