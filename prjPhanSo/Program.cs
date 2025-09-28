namespace prjPhanSo;

class Program
{
    static void Main(string[] args)
    {

        var ps1 = new PhanSo(1, 2);   // 1/2
        Console.WriteLine("Gia tri phan so 1");
        ps1.Xuat();
        var ps2 = new PhanSo(1, 3);   // 1/3
        Console.WriteLine("Gia tri phan so 2");
        ps2.Xuat();

        var tong = ps1.Cong(ps2);  // 5/6

        var hieu = ps1.Tru(ps2);   // 1/6
        Console.WriteLine("Tru 2 phan so");
        hieu.Xuat();
        var tich = ps1.Nhan(ps2);  // 1/6
        Console.WriteLine("Tich 2 phan so");
        tich.Xuat();
        var thuong = ps1.Chia(ps2);// 3/2
        Console.WriteLine("Thuong 2 phan so");
        thuong.Xuat();

        Console.WriteLine("Tong 2 phan so");
        tong.Xuat();   // in ra: 5/6
    }
}

