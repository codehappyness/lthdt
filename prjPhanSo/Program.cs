namespace prjPhanSo;

class Program
{
    static void Main(string[] args)
    {

        var ps1 = new PhanSo(1, 2);   // 1/2
        Console.WriteLine("Gia tri phan so 1");
        Console.WriteLine(ps1.ToString());
        var ps2 = new PhanSo(1, 3);   // 1/3
        Console.WriteLine("Gia tri phan so 2");
        Console.WriteLine(ps2.ToString());

        var tong = ps1.Cong(ps2);  // 5/6

        var hieu = ps1.Tru(ps2);   // 1/6
        Console.WriteLine("Tru 2 phan so");
        Console.WriteLine(hieu.ToString());
        var tich = ps1.Nhan(ps2);  // 1/6
        Console.WriteLine("Tich 2 phan so");
        Console.WriteLine(tich.ToString());
        var thuong = ps1.Chia(ps2);// 3/2
        Console.WriteLine("Thuong 2 phan so");
        Console.WriteLine(thuong.ToString());

        Console.WriteLine("Tong 2 phan so");
        Console.WriteLine(tong.ToString());
    }
}

