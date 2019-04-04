using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
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



    }
}
