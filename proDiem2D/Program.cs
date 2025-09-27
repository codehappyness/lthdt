namespace proDiem2D
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diem2D d1 = new Diem2D();
            // Console.WriteLine("Nhap toa do d1:");
            // d1.Nhap();
            // Console.Write("d1");
            // d1.Xuat();
            //
            // Diem2D d2 = new Diem2D();
            // Console.WriteLine("Nhap toa do d2:");
            // d2.Nhap();
            // Console.Write("d2");
            // d2.Xuat();
            //
            // Console.WriteLine("Khoang cach d1 -> d2: {0}", d1.KhoangCach(d2));
            //
            // d2.DiChuyen(1,1);
            // Console.WriteLine("Khoang cach d1 -> d2: {0}", d1.KhoangCach(d2));

          Diem2D[] d = new Diem2D[10];
          int n = 4;
          Console.WriteLine("Nhap du lieu");
          Diem2D.Nhap(d, n);
          Console.WriteLine("Xuat du lieu");
          Diem2D.Xuat(d, n);

          Console.WriteLine("Diem gan O:");
          Diem2D kq = Diem2D.DiemGanO(d, n);

          kq.Xuat();
        }
    }
}


