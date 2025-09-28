namespace prHinhChuNhat;

class Program
{
    static void Main(string[] args)
    {
        HinhChuNhat hcn = new HinhChuNhat();
        hcn.Nhap();
        hcn.HienThi();

        Console.WriteLine("Dien tich = " + hcn.DienTich());
        Console.WriteLine("Chu vi = " + hcn.ChuVi());

        Console.ReadLine();
    }
}
