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
		public static double battiti_Min(int età)
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

			if (battiti > 60 && battiti < 100)
			{
				risultato = "normale";
			}

			if (battiti > 100)
			{
				risultato = "tachicardico";
			}

			return risultato;



		}


		//  terzo script
		public static double CalorieBruciate(string sesso, double Frequenza_Cardiaca, double peso, int anni, double tempo)

		{
			double calorie_bruciate = 0;
			if (sesso == "M")
			{
				calorie_bruciate = ((anni * 0.2017) + (peso * 0.199) + (Frequenza_Cardiaca * 0.6309) - 55, 0969) * tempo / 4.184;

			}
			if (sesso == "F")
			{
				calorie_bruciate = ((anni * 0.074) + (peso * 0.126) + (Frequenza_Cardiaca * 0.4472) - 20, 4022) * tempo / 4.184;

			}

			return calorie_bruciate;
		}





		public static double SpesaEnergetica(string attività, double km_percorsi, double peso_corporeo)
		{
			Double risultato = 0;
			if (attività ==”corsa”)
{
				Risultato = (0.9 * km_percorsi) * peso_corporeo;
			}
			if (attività ==”camminata”)
{
				Risultato = (0.50 * km_percorsi) * peso_corporeo;
			}
			Return risultato;
		}







	}
}
