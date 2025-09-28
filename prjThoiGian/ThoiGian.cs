
namespace prjThoiGian
{
    public class ThoiGian
    {
        private int gio;
        private int phut;
        private int giay;

        public int getGio(){
          return this.gio;
        }

        public int getPhut(){
          return this.phut;
        }

        public int getGiay(){
          return this.giay;
        }

        public ThoiGian()
        {
            gio =phut = giay= 0;
        }

        public ThoiGian(int gio, int phut, int giay)
        {
            this.gio = gio;
            this.phut = phut;
            this.giay = giay;
            LamTron();
        }

        private void LamTron()
        {
            if (giay >= 60)
            {
                phut += giay / 60;
                giay %= 60;
            }
            if (phut >= 60)
            {
                gio += phut / 60;
                phut %= 60;
            }
            gio %= 24; 
        }

        public void Nhap()
        {
            Console.Write("Nhập giờ: ");
            gio = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhập phút: ");
            phut = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhập giây: ");
            giay = int.Parse(Console.ReadLine() ?? "0");
            LamTron();
        }

        public void Xuat()
        {
            Console.WriteLine($"{gio:D2}:{phut:D2}:{giay:D2}");
        }

        public bool HopLe()
        {
            return (gio >= 0 && gio < 24) && (phut >= 0 && phut < 60) && (giay >= 0 && giay < 60);
        }


        public void Tang()
        {
            giay++;
            LamTron();
        }

        public void Tang(int n)
        {
            giay += n;
            LamTron();
        }

        public void Tang(ThoiGian tg)
        {
            gio += tg.getGio();
            phut += tg.getPhut();
            giay += tg.getGiay();
            LamTron();
        }
    }
}
