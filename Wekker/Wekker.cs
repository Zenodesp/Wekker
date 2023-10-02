using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wekker
{
    internal class Wekkertje
    {
        delegate int AlarmTijden(int input);

        delegate string WekkerModus(char optie);


        

        public static void wekkerGeluid()
        {
            Console.Beep(5000, 2000);
            
        }

        public static string wekkerblink(string text)
        {
            text = "blink";
            return text;
        }

        public static string wekkertekst(string text)
        {
            text = "ALARM! UIT BED!";
            return text;
        }

    }
}
