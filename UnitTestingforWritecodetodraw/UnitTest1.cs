using Microsoft.VisualStudio.TestTools.UnitTesting;
using Write_code_to_draw;
using System.Drawing;
using System.IO;


namespace Write_code_to_draw.UnitTests
{
    [TestClass]
    public class UnitTest1a
    {
        [TestMethod]
        public void Validation_Unittesting()
        {
            string emptyvalue = "";

            Validation v = new Validation(emptyvalue);

            string[] ouput_from_validation = v.error_handling_validation();

            string expected_output = "**Feild is empty**";


            Assert.AreEqual(expected_output, ouput_from_validation[0]);


        }
        [TestMethod]
        public void fill_Unittesting()
        {
            string given_firstname = "rectangle 100x,100x,100x,100x";

            Validation cx = new Validation(given_firstname);

            string[] array_output = cx.error_handling_validation() ;

            string expected_output =  "**Parameters not passed correctly**";
            Assert.AreEqual(expected_output, array_output[0]);

          


        }

    }
}
