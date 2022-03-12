namespace BaiTapSinhVien
{
    internal class SinhVien
    {
        private int Number { get; set; }//Mã sinh viên
        private string? Name { get; set; }
        /*Phân tích tên sinh viên thành họ và tên
        private string? firstName;
        private string? lastName;
        */
        private double Point { get; set; }//Điểm
        private string? Rank { get; set; }//Xếp loại
        private string? Email { get; set; }//Email
        //Hàm tạo trống
        public SinhVien()
        {

        }
        //Hàm tạo cho trường hợp cần nhập bằng Exel hay đại loại
        public SinhVien(string? name, Double point, string? email)
        {
            this.Name = name;
            this.Point = point;
            this.Email = email;
        }
        public int getNumber
        {
            get
            {
                return this.Number;
            }
            set
            {
                this.Number = value;
            }
        }
        public string? getName
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public double getPoint
        {
            get
            {
                return this.Point;
            }
            set
            {
                try
                {
                    if (value > 0 && value < 10)
                    {
                        this.Point = value;
                    }
                    else
                    {
                        Console.WriteLine("Điểm nhập lỗi");
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Điểm nhập lỗi");
                    throw;
                }
            }
        }
        public string? getRank
        {
            get
            {
                return this.Rank;
            }
        }
        public string? getEmail
        {
            get
            {
                return this.Email;
            }
            set
            {
                this.Email = value;
            }
        }
        public void input(int number)
        {
            Console.WriteLine($"Nhập thông tin sinh viên {number}");
            this.Number = number;//Mã số tăng theo i+1
            Console.Write("Nhập tên: ");
            this.Name = Console.ReadLine();
            do
            {
                Console.WriteLine("0 < Điểm < 10");
                Console.Write("Nhập Điểm: ");
                this.Point = Convert.ToDouble(Console.ReadLine());
            } while (this.Point < 0 || this.Point > 10);
            handleRank();//Xếp loại sinh viên
            Console.Write("Nhập Email: ");
            this.Email = Console.ReadLine();
        }
        public void output(int i)
        {
            Console.WriteLine($"\nThông tin sinh viên {i}");
            //Làm cho nó giống với mã số sinh viên trường mình
            Console.WriteLine($"Mã số: PS {String.Format("{0:0000}", this.Number)} ");
            Console.WriteLine($"Họ và tên: {this.Name} ");
            Console.WriteLine($"Điểm: {this.Point} ");
            Console.WriteLine($"Xếp loại: {this.Rank}");
            Console.WriteLine($"Email: {this.Email} ");
        }
        private void handleRank()
        {
            if (this.Point < 5)
            {
                this.Rank = "Yếu";
            }
            else if (this.Point < 6.5)
            {
                this.Rank = "Trung bình";
            }
            else if (this.Point < 7.5)
            {
                this.Rank = "Khá";
            }
            else if (this.Point < 9)
            {
                this.Rank = "Giỏi";
            }
            else
            {
                this.Rank = "Xuất sắc";
            }
        }

    }
}

