using Wekker;

internal class Program
{
    private static void Main(string[] args)
    {

        WekkerModus callback;

        Timer timer = new Timer(wm1);
        
        

        char keuze = '0';
        do
        {

            
            Console.WriteLine("WEKKERINSTELLINGEN");
            Console.WriteLine("------------------");
            Console.WriteLine("0 Instellen compleet");
            Console.WriteLine("1 Alarmtijd instellen");
            Console.WriteLine("2 stop alarm - sluimerknop");
            Console.WriteLine("3 wekkeralarm-tekstmodus aan/uit");
            Console.WriteLine("4 wekkeralarm-knippermodus aan/uit");
            Console.WriteLine("5 wekkeralarm-geluidsmodus aan/uit");
            Console.Write("Geef je keuze in en druk [Enter]: ");
            keuze = Console.ReadLine()[0];
            Console.WriteLine();

            switch(keuze)
            {

                case '0':
                    break;

                case '1':
                    Console.WriteLine("Geef de tijd in waarop je een alarm wil instellen.");
                    int timeInt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Geef de tijd in waarop je de sluimerstand wil activeren.");
                    int timeInt2 = Convert.ToInt32(Console.ReadLine());
                    //timer.Interval = TimeSpan.FromSeconds(3).TotalSeconds;
                    timer.Change(timeInt2, timeInt);
                    break;

                case '2':
                   // timer.Stop();
                   timer.Dispose();
                    Console.WriteLine("Timer afgezet.");
                    break;

                case '3':

                    callback = new WekkerModus(Wekkertje.wekkertekst);
                    break;

                case '4':
                    callback = new WekkerModus(Wekkertje.wekkerblink);
                   
                    break;

                case '5':
                   // callback = new WekkerModus(Wekkertje.wekkerGeluid);
                    break;

                default: 
                    break;
            }
        } while (keuze != '0');

        
    }

    private static void wm1(object? state)
    {

        WekkerModus callback;
    }

    delegate string WekkerModus(string text);
}

