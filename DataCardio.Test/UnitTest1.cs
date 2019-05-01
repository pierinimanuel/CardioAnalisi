using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(14, 206, 144.2, 185.4)]        // età,frequenza,battiti minimi,battiti massimi
        [DataRow(17, 203, 142.1, 182.7)]                    // per i battiti minimi frequenza * 0.7
        [DataRow(25, 195, 136.5, 175.5)]                   // per i battiti massimi frequenza * 0.9
        [DataRow(30, 190, 133, 171)]
        [DataRow(50, 170, 119, 153)]
        public void TestMethod1(int età, int frequenza, double battiti_Min_aspettati, double battiti_Max_aspettati)
        {

            double battiti_Min_calcolati = CardioLibrary.DataCardio.battiti_Min(età);
            Assert.AreEqual(battiti_Min_calcolati, battiti_Min_aspettati);

            double battiti_Max_calcolati = CardioLibrary.DataCardio.battiti_Max(età);
            Assert.AreEqual(battiti_Max_calcolati, battiti_Max_aspettati);
        }


        [DataTestMethod]                // valori di frequenza cardiaca
        [DataRow(59, "bradicardia")]                  // battiti
        [DataRow(70, "normale")]                    
        [DataRow(110, "tachicardia")]                   
        public void TestMethod2(double battiti, string battiti_aspettati)
        {
            string battiti_calcolati = CardioLibrary.DataCardio.frequenza_cardiaca(battiti);
            Assert.AreEqual(battiti_aspettati, battiti_calcolati);
        }


		//  3 script

		[DataTestMethod]
		[DataRow("M", 30, 45, 59)] //sesso, frequenza cardiaca media, peso, anni, durata sessione
        [DataRow("F", 30, 45, 59)]
         public void TestCalorieBruciate(string sesso, double Frequenza_Cardiaca, double peso, int anni, double tempo, double calorie_bruciate_aspettate)

		{
			calorie_bruciate = CardioLibrary.DataCardio.CalorieBruciate(sesso, Frequenza_Cardiaca, peso, anni, tempo);

			Assert.AreEqual(calorie_bruciate_aspettate, calorie_bruciate);
		}


		// Script 4
		[DataTestMethod]
		[DataRow("corsa", 8, 70, 730)]   //  tipologia attività, km percorsi, peso corporeo, spesa energetica
		[DataRow("camminata", 5, 80, 700)] // tipologia attività, km percorsi, peso corporeo, spesa energetica
		public void TestSpesaEnergetica(string attività, double km_percorsi, double peso_corporeo, double spesa_energetica_aspettata)
		{
			Double spesa_energetica = CardioLibrary.DataCardio.SpesaEnergetica(attività, peso_corporeo, km_percorsi);
			Assert.AreEqual(spesa_energetica, spesa_energetica_aspettata);

		}

		// Script 5 media giornaliera dei battiti cardiaci
		[DataTestMethod]
		[DataRow(73, 120, 100, 92)] //  battiti a riposo battiti massimi, battiti di recupero, media giornaliera
		[DataRow(70, 127, 102, 96)]

		public void TestBattitiGiornalieri(double battti_riposo, double battiti_massimi, double battti_recupero, double battti_giornalieri_aspettati)
		{
			battiti_giornalieri = CardioLibrary.DataCardio.BattitiGiornalieri(battti_riposo, battiti_massimi, battti_recupero);
			Assert.AreEqual(battiti_giornalieri, battti_giornalieri_aspettati);

		}


		// Script 5 variabiltà del battito cardiaco
		[DataTestMethod]
		[DataRow(55, 58, 60, 58, 54, 9)] // giorno1, giorno2 ,giorno3 ,giorno4, giorno5, variabilità del battito
		[DataRow(54, 56, 58, 55, 52, 7)]
		public void TestVariabilitaBattito(double battiti_1, double battiti_2, double battiti_3, double battiti_4, double battiti_5, double variabilità_battito_aspetatto)
		{
			double variabilità_battito = CardioLibrary.DataCardio.VariabilitaBattito(battiti_1, battiti_2, battiti_3, battiti_4, battiti_5);
			Assert.AreEqual (variabilità_battito,variabilità_battito_aspetatto);
		}

	}
}
