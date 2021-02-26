using System;

namespace _2_Method_Uygulaması
{

    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool Otomatik { get; set; }

        public void Start()
        {
            Console.WriteLine($"{this.Marka} {this.Model} çalıştırıldı.");
        }

        public void Stop()
        {
            Console.WriteLine($"{this.Marka} {this.Model} durduruldu.");
        }

        public void Yavasla()
        {
            Console.WriteLine($"{this.Marka} {this.Model} yavaşladı.");
        }

        public void Hizlan()
        {
            Console.WriteLine($"{this.Marka} {this.Model} hızlandı.");
        }

        public void Menu()
        {
            string komut = "";
            do
            {
                Console.WriteLine("1-Start 2-Hızlan 3-Yavaşla 4-Stop Çıkış: Ç");
                Console.Write("Seçiminiz: ");
                komut = Console.ReadLine();

                switch (komut)
                {
                    case "1":
                        this.Start();
                        break;
                    case "2":
                        this.Hizlan();
                        break;
                    case "3":
                        this.Yavasla();
                        break;
                    case "4":
                        this.Stop();
                        break;
                    case "ç":
                        break;
                    default:
                        System.Console.WriteLine("yanlış seçim!");
                        break;
                }

            } while (komut != "ç");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var opel = new Araba();
            opel.Marka = "Opel";
            opel.Model = "Astra";
            opel.Renk = "Beyaz";
            opel.Otomatik = true;

            // opel.Start();
            // opel.Hizlan();
            // opel.Yavasla();
            // opel.Stop();

            opel.Menu();

        }
    }
}
