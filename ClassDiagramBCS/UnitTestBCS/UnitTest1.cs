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
            piketFunctionaris.setPiketFunctionaris(true, true, true, false, "Jan de Vries");
            telefoonNummer.setTelefoonNummer("0701234567");
            oproepFunctie.creeerOproepFunctie(capcode);                 //verdeel info van capcode in object
            oproepFunctie.setOmschrijving(capCode.getOmschrijving());   //zet capcode omschrijving in oproep
            
            //Assert
            Assert.IsTrue(actief.getActief(), "Capcode niet actief");
            Assert.AreEqual(true, piketFunctionaris.getActief() && piketFunctionaris.getBeschikbaar(), "Piket functionaris niet actief of niet beschikbaar"); //piketfunctionaris actief en beschikbaar?
            Assert.AreEqual(true, piketFunctionaris.getGebruikSms() || piketFunctionaris.getGebruikEmail(), "Piket functionaris heeft geen SMS en Email communicatie opgegeven");


            /*
            if (piketFunctionaris.getGebruikSms())
            {
                Console.WriteLine("SMS");
            }
            else if (piketFunctionaris.getGebruikEmail())
            {
                Console.WriteLine("Email");
            }
            else
            {
                Assert.Fail("Piket functionaris heeft geen SMS en Email communicatie opgegeven");
            }
            */


            //log
        }

        [TestMethod]
        public void TestCreeerOproepMelding()
        {
            //arrange
            OproepMelding oproepMelding = new OproepMelding();

            //act
            PiketFunctionaris piketFunctionaris = new PiketFunctionaris();
            
            DateTime messageDate = new DateTime();
            oproepMelding.setOproepMelding(messageDate, 5783, "TCO BRW Haaglanden", capcode);

            //assert
            if (piketFunctionaris.getGebruikSms())
            {
                oproepMelding.verstuurBericht(); //verzin hoe sms meekomt
            }
            else if (piketFunctionaris.getGebruikEmail())
            {
                oproepMelding.verstuurBericht(); //verzin hoe email meekomt
            }

            //melding actief, overgaan op uitsturen bericht naar Piket Functionarissen


            //log
        }

        [TestMethod]
        public void TestCommunicatie()
        {
            //bericht beschikbaarheid van Piket functionaris ontvangen, overgaan op eventuele vervolg actie.


            //log            
        }

       // public object iSms { get; set; }
    }
}
