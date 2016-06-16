using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBCS
{
    [TestClass]
    public class UnitTestReceiveCapcode
    {
        [TestMethod]
        public void TestReceiveCapcode()
        {
            //Arrange
            string capcode = "1505791";

            Oproep oproep = new Oproep();
            Regio regio = new Regio();

            //Act
            regio.setRegio("15");
            oproep.creeerOproep(capcode);

            if (oproep.getRegio() == regio.getRegio())
            {
                OproepFunctie oproepFunctie = new OproepFunctie();
                
                //als actief ->                
                if (oproepFunctie.actieveOproepFunctie(capcode))
                {
                    OproepMelding oproepMelding = new OproepMelding();
                }




            }
            else
            {
                //log
                throw new Exception("onjuiste regio, geen oproepfunctie actief");
            }


            //Assert
           // Assert.IsTrue();

        }
    }
}
