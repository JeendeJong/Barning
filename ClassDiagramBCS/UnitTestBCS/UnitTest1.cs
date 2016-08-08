using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBCS
{
    [TestClass]
    public class UnitTestReceiveCapcode
    {
        //Code	  Discipline Regio	    Korps/sector Omschrijving	         Short
        //1520089 Ambulance	 Haaglanden GHOR         Piketvoertuig ambulance GHOR PIKET

        //Arrange
        string capcode = "1520089";

        [TestMethod]
        public void TestReceiveCapcode()
        {
            //Arrange
            Oproep oproep = new Oproep();
            Regio regio = new Regio();

            //Act
            regio.setRegio("15");
            oproep.creeerOproep(capcode);

            //Assert
            Assert.AreEqual(oproep.getRegio(), regio.getRegio(), "onjuiste regio, geen oproepfunctie actief");

            //log
        }

        [TestMethod]
        public void TestCreeerOproepFunctie()
        {
            //Arrange
            Capcode capCode = new Capcode();
            Actief actief = new Actief();
            PiketFunctionaris piketFunctionaris = new PiketFunctionaris();
            TelefoonNummer telefoonNummer = new TelefoonNummer();
            OproepFunctie oproepFunctie = new OproepFunctie();

            //Act
            capCode.setCapcode(capcode);
            capCode.setOmschrijving("Piketvoertuig ambulance");
            actief.setActief(true);
            piketFunctionaris.setPiketFunctionaris(true, true, true, "Jan de Vries");
            telefoonNummer.setTelefoonNummer("0701234567");
            oproepFunctie.creeerOproepFunctie(capcode);                 //verdeel info van capcode in object
            oproepFunctie.setOmschrijving(capCode.getOmschrijving());   //zet capcode omschrijving in oproep
            
            //Assert
            Assert.IsTrue(actief.getActief(), "Capcode niet actief");
            Assert.IsTrue(piketFunctionaris.getActief(), "Piket functionaris niet actief");
            Assert.IsTrue(piketFunctionaris.getBeschikbaar(), "Piket functionaris niet beschikbaar");

            //Assert.AreEqual(true, piketFunctionaris.getActief() && piketFunctionaris.getBeschikbaar(), "Piket functionaris niet actief"); //piketfunctionaris actief en beschikbaar?

            //Piketfunctionaris actief, zo ja, welk communicatiekanaal wordt aangesproken
           // if ()

            //log
        }

        [TestMethod]
        public void TestCreeerOproepMelding()
        {
            OproepMelding oproepMelding = new OproepMelding();
            
            //melding actief, overgaan op uitsturen bericht naar Piket Functionarissen


            //log
        }

        [TestMethod]
        public void TestCommunicatie()
        {
            //bericht beschikbaarheid van Piket functionaris ontvangen, overgaan op eventuele vervolg actie.


            //log            
        }
    }
}
