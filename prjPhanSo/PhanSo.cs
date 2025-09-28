namespace prjPhanSo
{

    public class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public int getTuSo()
        {
            return this.tuSo; 
        }
        public int getMauSo(){
          return this.mauSo;

        } 

        public PhanSo()
        {
            this.tuSo = 0;
            this.mauSo = 1;
        }

        public PhanSo(int ts, int ms)
        {
            if (mauSo == 0)
                throw new ArgumentException("Mau so khong duoc bang 0");

            this.tuSo = ts;
            this.mauSo = ms;
            RutGon();
        }

        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            this.tuSo = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap mau so: ");
            this.mauSo = int.Parse(Console.ReadLine() ?? "1");

            if (this.mauSo == 0)
                throw new ArgumentException("Mau so khong duoc bang 0");

            RutGon();
        }

        public void Xuat()
        {
            Console.WriteLine($"{tuSo}/{mauSo}");
        }

        public void RutGon()
        {
            int gcd = GCD(Math.Abs(tuSo), Math.Abs(mauSo));
            tuSo /= gcd;
            mauSo /= gcd;

            if (mauSo < 0)
            {
                tuSo = -tuSo;
                mauSo = -mauSo;
            }
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }

        public static PhanSo Cong(PhanSo a, PhanSo b)
        {

            return new PhanSo(a.tuSo * b.mauSo + b.tuSo * a.mauSo, a.mauSo * b.mauSo);
        }

        public static PhanSo Tru(PhanSo a, PhanSo b)
        {

            return new PhanSo(a.tuSo * b.mauSo - b.tuSo * a.mauSo, a.mauSo * b.mauSo);
        }

        public static PhanSo Nhan(PhanSo a, PhanSo b)
        {

            return new PhanSo(a.tuSo * b.tuSo, a.mauSo * b.mauSo);
        }

        public static PhanSo Chia(PhanSo a, PhanSo b)
        {
            if (b.tuSo == 0)
                throw new DivideByZeroException("Khong the chia cho 0");
            return new PhanSo(a.tuSo * b.mauSo, a.mauSo * b.tuSo);
        }

        public static PhanSo Cong(PhanSo a, int n)
        {
            return new PhanSo(a.tuSo + n * a.mauSo, a.mauSo);
        }

        public static PhanSo Tru(PhanSo a, int n)
        {

            return new PhanSo(a.tuSo - n * a.mauSo, a.mauSo);
        }

        public static PhanSo Nhan(PhanSo a, int n)
        {

            return new PhanSo(a.tuSo * n, a.mauSo);
        }

        public static PhanSo Chia(PhanSo a, int n)
        {
            if (n == 0)
                throw new DivideByZeroException("Khong the chia cho 0");
            return new PhanSo(a.tuSo, a.mauSo * n);
        }

        // ---- So sánh ----
        public double GiaTri()
        {
            return (double)tuSo / mauSo;
        }

        public static bool LonHon(PhanSo a, PhanSo b)
        {
            return a.GiaTri() > b.GiaTri();
        }

        public static bool NhoHon(PhanSo a, PhanSo b)
        {

            return a.GiaTri() < b.GiaTri();
        }

        public static bool Bang(PhanSo a, PhanSo b)
        {

            return a.GiaTri() == b.GiaTri();
        }

        public static bool Khac(PhanSo a, PhanSo b)
        {

            return a.GiaTri() != b.GiaTri();
        }

        public bool Bang(PhanSo ps)
        {
            if (ps == null) return false;
            return Bang(this, ps);
        }

    }
}
