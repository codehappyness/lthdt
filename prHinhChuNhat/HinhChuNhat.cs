namespace prHinhChuNhat
{

    class HinhChuNhat
    {
        private double a;
        private double b;

        public HinhChuNhat()
        {
            a = 0;
            b = 0;
        }

        public HinhChuNhat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }


        public void Nhap()
        {
            Console.Write("Nhap chieu dai a:");
            a = double.Parse(Console.ReadLine()!);

            Console.Write("Nhap chieu rong b:");
            b = double.Parse(Console.ReadLine()!);
        }

        public void HienThi()
        {
            Console.WriteLine($"Chieu dai: {a}, Chieu rong: {b}");
        }

        public double DienTich()
        {
            return a * b;
        }

        public double ChuVi()
        {
            return (a + b) * 2;
        }
    }
}
