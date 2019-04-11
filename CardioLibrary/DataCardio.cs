using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {

        // primo script
        public static double battiti_Min (int età)
        {
            int frequenza = 220 - età;
           double battiti_Min = frequenza * 0.7;
            return battiti_Min;
        }

        public static double battiti_Max(int età)
        {
            int frequenza = 220 - età;
            double battiti_Max = frequenza * 0.9;
            return battiti_Max;
        }


        // secondo script
        public static string frequenza_cardiaca(double battiti)
        {
            string risultato = "";
            if (battiti < 60)
            {
                risultato = "bradicardia";
            }

            if(battiti>60 && battiti < 100)
            {
                risultato = "normale";
            }

            if (battiti>100)
            {
                risultato = "tachicardico";
            }

            return risultato;

        }

    }
}
