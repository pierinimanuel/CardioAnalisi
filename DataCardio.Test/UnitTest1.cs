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







    } 
}
