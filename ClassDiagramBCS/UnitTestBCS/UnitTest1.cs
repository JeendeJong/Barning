using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBCS
{
    [TestClass]
    public class UnitTestReceiveCapcode
    {
        //Code	  Regio Discipline  Korps/sector    Omschrijving	         Short
        //1520089 15    2           
        //   0089       Ambulance	Haaglanden GHOR Piketvoertuig ambulance GHOR PIKET

        //Act
        string capcode = "1520089";

        [TestMethod]
        public void TestReceiveCapcode()
        {
            //Arrange
            Oproep oproep = new Oproep();
            Regio regio = new Regio();

            //Act
            oproep.creeerOproep(capcode);
            regio.setRegio("15");

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
            piketFunctionaris.setPiketFunctionaris(true, true, true, false, false, false, "Jan de Vries");
            telefoonNummer.setTelefoonNummer("0701234567");
            oproepFunctie.activeerOproepMelding(capcode);                 //verdeel info van capcode in object
            oproepFunctie.setOmschrijving(capCode.getOmschrijving());   //zet capcode omschrijving in oproep
            oproepFunctie.setActive(true);
            
            //Assert
            Assert.IsTrue(actief.getActief(), "Capcode niet actief");
            Assert.AreEqual(true, piketFunctionaris.getActief() && piketFunctionaris.getBeschikbaar(), "Piket functionaris niet actief of niet beschikbaar"); //piketfunctionaris actief en beschikbaar?
            Assert.AreEqual(true, piketFunctionaris.getGebruikSms() || piketFunctionaris.getGebruikEmail() || piketFunctionaris.getGebruikApp() || piketFunctionaris.getGebruikTextToSpeech(), "Piket functionaris heeft geen SMS, Email, App of TextToSpeech communicatie opgegeven");

            //Als: capcode actief, piketfunctionaris actief en beschikbaar en gebruik van een communicatie -> oproepFunctie actief = true;
            if (oproepFunctie.getActief())
            {
                oproepFunctie.activeerOproepMelding(capcode);
            }

            //log
        }

        [TestMethod]
        public void TestCreeerOproepMelding()
        {
            //arrange
            OproepMelding oproepMelding = new OproepMelding();
            PiketFunctionaris piketFunctionaris = new PiketFunctionaris();
            DateTime messageDate = new DateTime();

            //act
            oproepMelding.setOproepMelding(messageDate, 5783, "TCO BRW Haaglanden", capcode);  //SMS
            piketFunctionaris.setPiketFunctionaris(true, true, true, true, true, true, "Jan de Vries");
            oproepMelding.verstuurBericht();

            //assert
            Assert.AreEqual(true, piketFunctionaris.getGebruikSms(), "Geen SMS communicatie");
            Assert.AreEqual(true, piketFunctionaris.getGebruikEmail(), "Geen Email communicatie");
            Assert.AreEqual(true, piketFunctionaris.getGebruikApp(), "Geen App communicatie");
            Assert.AreEqual(true, piketFunctionaris.getGebruikTextToSpeech(), "Geen TextToSpeech communicatie");

            //log
        }

        [TestMethod]
        public void TestRetourbericht()
        {
            //arrange
            OproepMelding oproepMelding = new OproepMelding();
            DateTime messageDate = new DateTime();
            SmsReacties smsReacties = new SmsReacties();

            //act
            oproepMelding.setOproepMelding(messageDate, 5783, "TCO BRW Haaglanden", capcode);  //SMS
            smsReacties.setReactie(messageDate, 4040, "beschikbaar", "haagseweg 13");

            //assert
            Assert.IsTrue(smsReacties.getBericht() == "beschikbaar" || 
                          smsReacties.getBericht() == "niet_beschikbaar" ||
                          smsReacties.getBericht() == "vertraagd", "onjuist SMS bericht piket functionaris: " + smsReacties.getBericht());
        }   
    }
}
