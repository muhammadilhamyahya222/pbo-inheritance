namespace Capek
{
    // LAPTOP
    class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;

        public Laptop(string merk, string tipe, Vga vga, Processor processor)
        {
            this.merk = merk;
            this.tipe = tipe;
            this.vga = vga;
            this.processor = processor;
        }

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {this.merk} {this.tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {this.merk} {this.tipe} mati");
        }
    }

    class ASUS : Laptop
    {
        public ASUS(string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor)
        {
            this.tipe = tipe;
            this.vga = vga;
            this.processor = processor;
        }
    }

    class ROG : ASUS
    {
        public ROG(Vga vga, Processor processor) : base("ROG", vga, processor)
        {
            this.vga = vga;
            this.processor = processor;
        }
    }
    class Vivobook : ASUS
    {
        public Vivobook(Vga vga, Processor processor) : base("Vivobook", vga, processor)
        {
            this.vga = vga;
            this.processor = processor;
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi !!");
        }
    }

    class ACER : Laptop
    {
        public ACER(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor)
        {
            this.tipe = tipe;
            this.vga = vga;
            this.processor = processor;
        }

    }

    class Swift : ACER
    {
        public Swift(Vga vga, Processor processor) : base("Swift", vga, processor)
        {
            this.vga = vga;
            this.processor = processor;
        }
    }
    class Predator : ACER
    {
        public Predator(Vga vga, Processor processor) : base("Predator", vga, processor)
        {
            this.vga = vga;
            this.processor = processor;
        }

        public void BermainGame()
        {
            Console.WriteLine($"Laptop {this.merk} {this.tipe} sedang memainkan game");
        }
    }

    class LENOVO : Laptop
    {
        public LENOVO(string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor)
        {
            this.tipe = tipe;
            this.vga = vga;
            this.processor = processor;

        }
    }

    class IdeaPad : LENOVO
    {
        public IdeaPad(Vga vga, Processor processor) : base("IdeaPad", vga, processor)
        {
            this.vga = vga;
            this.processor = processor;
        }
    }
    class Legion : LENOVO
    {
        public Legion(Vga vga, Processor processor) : base("Legion", vga, processor)
        {
            this.vga = vga;
            this.processor = processor;
        }
    }

    // PROCESSOR
    class Processor
    {
        public string merk, tipe;

        public Processor(string merk, string tipe)
        {
            this.merk = merk;
        }
    }

    class Intel : Processor
    {
        public Intel(string tipe) : base("Intel", tipe)
        {
            this.tipe = tipe;
        }
    }

    class Corei3 : Intel
    {
        public Corei3() : base("Core i3")
        {

        }

    }
    class Corei5 : Intel
    {
        public Corei5() : base("Core i5")
        {

        }
    }
    class Corei7 : Intel
    {
        public Corei7() : base("Core i7")
        {

        }
    }

    class AMD : Processor
    {
        public AMD(string tipe) : base("AMD", tipe)
        {
            this.tipe = tipe;
        }
    }

    class Ryzen : AMD
    {
        public Ryzen() : base("RAYZEN")
        {

        }
    }
    class Athlon : AMD
    {
        public Athlon() : base("ATHLON")
        {

        }
    }

    class Vga
    {
        public string merk;

        public Vga(string merk)
        {
            this.merk = merk;
        }
    }

    class Nvidia : Vga
    {
        public Nvidia() : base("Nvidia")
        {

        }
    }

    class Amd : Vga
    {
        public Amd() : base("AMD")
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // VGA
            Amd amd = new Amd();
            Nvidia nvdia = new Nvidia();
            
            // Processor
            Corei5 corei5 = new Corei5();
            Corei7 corei7 = new Corei7();
            Ryzen ryzen = new Ryzen();


            Laptop laptop1 = new Vivobook(nvdia, corei5);
            Laptop laptop2 = new IdeaPad(amd, ryzen);
            Predator predator = new Predator(amd, corei7);

            // Soal No. 1
            //laptop2.LaptopDinyalakan();
            //laptop2.LaptopDimatikan();

            // Soal No. 2
            //laptop1.NyalakanLampu();

            // Soal No. 3
            Console.WriteLine($"Merk VGA = {laptop1.vga.merk}, Merk Processor = {laptop1.processor.merk}, Tipe Processor = {laptop1.processor.tipe}");

            // Soal No. 4
            //predator.BermainGame();

            // Soal No. 5
            //ACER acer = new Predator(amd, corei7);
            //acer.BermainGame();
        }
    }
}