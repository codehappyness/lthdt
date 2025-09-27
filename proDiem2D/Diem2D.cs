namespace proDiem2D
{

    public class Diem2D
    {
        private int x;
        private int y;

        public void Nhap()
        {
            Console.Write("Nhap x:");
            x = int.Parse(s: Console.ReadLine()!);
            Console.Write("Nhap y:");
            y = int.Parse(s: Console.ReadLine()!);
        }

        public void Xuat()
        {
            Console.WriteLine("({0}, {1})", x, y);

        }

        public void DiChuyen(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public double KhoangCach(Diem2D d)
        {
            double t1 = Math.Pow(x - d.x, 2);
            double t2 = Math.Pow(y - d.y, 2);
            double t = Math.Sqrt(t1 + t2);
            return t;
        }

        static public void Nhap(Diem2D[] d, int sl)
        {
            for (int i = 0; i < sl; i++)
            {
                Console.WriteLine("Nhap toa do d[{0}]", i);
                d[i] = new Diem2D();
                d[i].Nhap();
            }
        }

        static public void Xuat(Diem2D[] d, int sl)
        {
            for (int i = 0; i < sl; i++)
            {
                Console.WriteLine("Nhap toa do d[{0}]", i);
                d[i].Xuat();
            }

        }

        static public Diem2D DiemGanO(Diem2D[] d, int sl)
        {

            Diem2D diemO = new Diem2D();
            double[] t = new double[sl];
            for (int i = 0; i < sl; i++)
            {
                t[i] = d[i].KhoangCach(diemO);
            }


            double min = t[0];
            int j = 0;
            for (int i = 1; i < sl; i++)
            {
                if (min > t[i])
                {
                    min = t[i];
                    j = i;
                }

            }

            return d[j];
        }
    }
}

