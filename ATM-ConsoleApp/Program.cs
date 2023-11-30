namespace ATM_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Rastgele 1000 ile 100000 arasında kullanıcı bakiyesi oluşturuldu, bakiye değişkenine atandı.
            Random random = new Random();
            int bakiye = random.Next(1000, 100000);
            Console.WriteLine("********************");
            Console.WriteLine("Mevcut bakiyeniz: " + bakiye);
            bool devamEt = true;

            //Kullanıcının yapacağı işlemler
            while (devamEt)
            {
                Console.WriteLine("********************");
                Console.WriteLine($"1) Para Çekme\n2) Para Yatırma\n3) Bakiye Görüntüleme\n4) Çıkış");
                Console.WriteLine("******************");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçin:");
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        bakiye = ParaCekme(bakiye);
                        break;
                    case 2:
                        bakiye = ParaYatır(bakiye);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("*********************");
                        Console.WriteLine($"Mevcut bakiyeniz: {bakiye}");
                        Console.WriteLine("*********************");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\nİyi günler dileriz.");
                        devamEt = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("*********************");
                        Console.WriteLine("Lütfen geçerli bir değer giriniz!");
                        break;
                }
            }
        }

        // Para cekmek için kullanılan metod, bakiye parametresi almaktadır.
        public static int ParaCekme(int bakiye)
        {
            Console.Clear();
            Console.Write("Lütfen hesabınızdan çekmek istediğiniz para miktarını girin:");
            int c_para = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (c_para > bakiye)
            {
                Console.WriteLine("*******************");
                Console.WriteLine("Bakiyeniz yetersiz!");
                Console.WriteLine("*******************");
            }
            else
            {
                bakiye -= c_para;
                Console.WriteLine($"Çekilen para tutarı: {c_para}, yeni bakiye: {bakiye}");
            }
            return bakiye;
        }

        //Para yatırmak için kullanılan metod, bakiye parametresi almaktadır.
        public static int ParaYatır(int bakiye)
        {
            Console.Clear();
            Console.Write("Lütfen yatırmak istediğiniz miktarı girin:");
            int y_para = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            bakiye += y_para;
            Console.WriteLine($"Yatırılan para tutarı: {y_para}, yeni bakiye: {bakiye}");
            return bakiye;
        }
    }
}
