namespace prjPhanSo;

class Program
{
    static void Main(string[] args)
    {

        var ps1 = new PhanSo(1, 2);   // 1/2
        var ps2 = new PhanSo(1, 3);   // 1/3

        var tong = PhanSo.Cong(ps1, ps2);  // 5/6
        var hieu = PhanSo.Tru(ps1, ps2);   // 1/6
        var tich = PhanSo.Nhan(ps1, ps2);  // 1/6
        var thuong = PhanSo.Chia(ps1, ps2);// 3/2

        tong.Xuat();   // in ra: 5/6
    }
}

