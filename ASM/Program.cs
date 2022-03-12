namespace BaiTapSinhVien
{
    class Program
    {

        public static byte choices;
        public static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;//Để nhập tiếng việt
            Console.OutputEncoding = System.Text.Encoding.Unicode;//Để xuất tiếng việt
            do
            {
                try
                {
                    choices = Handing.menu();
                }
                catch (System.Exception)
                {
                    choices = 13;
                }
                switch (choices)
                {
                    case 1:
                        {
                            Handing.program1();
                            break;
                        }
                    case 2:
                        {
                            Handing.program2();
                            break;
                        }
                    case 3:
                        {
                            Handing.program3();
                            break;
                        }
                    case 4:
                        {
                            Handing.program4();
                            break;
                        }
                    case 5:
                        {
                            Handing.program5();
                            break;
                        }
                    case 6:
                        {
                            Handing.program6();
                            break;
                        }
                    case 7:
                        {
                            Handing.program7();
                            break;
                        }
                    case 8:
                        {
                            Handing.program8();
                            break;
                        }
                    case 9:
                        {
                            Handing.program9();
                            break;
                        }
                    case 10:
                        {
                            Handing.program10();
                            break;
                        }
                    case 11:
                        {
                            Handing.program11();
                            break;
                        }
                    case 0:
                        {
                            Handing.endingProgram();
                            System.Environment.Exit(0);//Thoát chương trình
                            break;
                        }
                    default:
                        {
                            Handing.notificationError();//Xuất thông báo nhập lỗi
                            break;
                        }
                }
            } while (choices != 0);
        }
    }
}

/*
test Program: 1

Trần Hoàng
10
TranHoang@gmail.com
y
Trần Đạt
8
TranDat@gmail.com
y
Thùy Dương
6
ThuyDuong@gmail.com
y
ThuyDuong
5
ThuyDuong@gmail.com
y
ThuyDuong
2
ThuyDuong@gmail.com
y
Trần Phú Đạt
9
TranHoang@gmail.com
y
Trần Sơn
7
TranDat@gmail.com
y
Thúy Hạnh
7.8
ThuyDuong@gmail.com
y
ThuyDuong
4
ThuyDuong@gmail.com
y
Thùy Dương
3
ThuyDuong@gmail.com
n

*/