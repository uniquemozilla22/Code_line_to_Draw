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
        public void Variables_Unittesting()
        {
            //equating 
            string given_firstname = "x=10";

            Variables cx = new Variables(given_firstname);

            string[] array_output = cx.error_handling_variables();

            string expected_output = "Varaiable executed";
            Assert.AreEqual(expected_output, array_output[0]);


        }

        [TestMethod]

        public void Method_Testing()
        {

            //passing the non setted method to the application
            string given_input = "name()";

            Method_Execution pc = new Method_Execution(given_input);
            string[] response = pc.error_handling_method_executiion();


            string expected_output = "**There is no such method set **";


            Assert.AreEqual(expected_output, response[0]);




        }

        [TestMethod]

        public void loop_Testing()
        {

            //passing the non setted method to the application
            string given_input = "loop for x";

            Loop_execution pc = new Loop_execution(given_input);
            string[] response = pc.error_handling_loop_execution();


            string expected_output = "**Invalid variable for the loop**";


            Assert.AreEqual(expected_output, response[0]);




        }


    }
}
