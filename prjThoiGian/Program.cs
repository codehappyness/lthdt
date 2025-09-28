namespace prjThoiGian;

class Program
{
    static void Main(string[] args)
    {
        ThoiGian t1 = new ThoiGian(23, 59, 50);
        t1.Xuat();

        t1.Tang();
        t1.Xuat();

        t1.Tang(15);
        t1.Xuat();

        ThoiGian tg2 = new ThoiGian(1, 30, 20);
        t1.Tang(tg2);
        t1.Xuat();
    }
}

