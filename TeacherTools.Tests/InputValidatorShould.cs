using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TeacherTools.Utils;

namespace TeacherTools.Tests
{
    [TestFixture]
    public class InputValidatorShould
    {

        [Test]
        public void Return_True_If_Numeric()
        {
            bool isNumeric = InputValidator.IsNumeric("523");
            Assert.IsTrue(isNumeric);
        }

        [Test]
        public void Return_False_IfNot_Numeric()
        {
            bool isNumeric = InputValidator.IsNumeric("AB52ABC5");
            Assert.IsFalse(isNumeric);
        }

        [Test]
        public void Return_True_IfEmpty()
        {
            bool isEmpty = InputValidator.IsEmpty("     ");
            Assert.IsTrue(isEmpty);
        }

        [Test]
        public void Return_False_IfNot_Empty()
        {
            bool isEmpty = InputValidator.IsEmpty("a");
            Assert.IsFalse(isEmpty);
        }
    }

}
