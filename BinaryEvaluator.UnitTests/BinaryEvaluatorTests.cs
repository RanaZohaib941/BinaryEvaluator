using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryEvaluator; // Adjust the namespace as necessary

namespace BinaryEvaluator.UnitTests
{
    [TestClass]
    public class BinaryEvaluatorTests
    {
       
        // Tests for ValidateBinaryString
        [TestMethod]
        public void ValidateBinaryString_EqualZerosAndOnes_ReturnsGood()
        {
            string binaryString = "1100";

            string result = BinaryEvaluatorClass.ValidateBinaryString(binaryString);

            Assert.AreEqual(Constants.Good, result);
        }

        [TestMethod]
        public void ValidateBinaryString_MoreZerosThanOnes_ReturnsBad()
        {
            string binaryString = "0001";

            string result = BinaryEvaluatorClass.ValidateBinaryString(binaryString);

            Assert.AreEqual(Constants.Bad, result);
        }

        [TestMethod]
        public void ValidateBinaryString_MoreOnesThanZeros_ReturnsBad()
        {
            string binaryString = "1110";

            string result = BinaryEvaluatorClass.ValidateBinaryString(binaryString);

            Assert.AreEqual(Constants.Bad, result);
        }

        [TestMethod]
        public void ValidateBinaryString_ValidBinaryStringWithEqualBits_ReturnsGood()
        {
            string binaryString = "101010";

            string result = BinaryEvaluatorClass.ValidateBinaryString(binaryString);

            Assert.AreEqual(Constants.Good, result);
        }

        // Tests for IsBinaryString
        
        [TestMethod]
        public void IsBinaryString_ContainsNonBinaryCharacter_ReturnsFalse()
        {
            string input = "10102";

            bool result = BinaryEvaluatorClass.IsBinaryString(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsBinaryString_EmptyString_ReturnsFalse()
        {
            string input = "";

            bool result = BinaryEvaluatorClass.IsBinaryString(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsBinaryString_NullString_ReturnsFalse()
        {
            string? input = null;

            bool result = BinaryEvaluatorClass.IsBinaryString(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsBinaryString_ValidBinaryStringWithDifferentLength_ReturnsTrue()
        {
            string input = "111000";

            bool result = BinaryEvaluatorClass.IsBinaryString(input);

            Assert.IsTrue(result);
        }
    }
}
