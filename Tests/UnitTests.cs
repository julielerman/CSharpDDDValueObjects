using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueObjectSample;

namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CanCreateNewPersonFullName()
        {
            var pfn = PersonFullName.Create("julie", "lerman");
            Assert.AreEqual("julie lerman", pfn.FullName);
        }

        [TestMethod]
        public void CanCreateNewPersonFullNameRecord()
        {
            var pfnr = PersonFullNameRecord.Create("julie", "lerman");
            Assert.AreEqual("julie lerman", pfnr.FullName);
        }

        [TestMethod]
        public void CanValidateTwoPFNEquality()
        {
            var pfn1 = PersonFullName.Create("julie", "lerman");
            var pfn2 = PersonFullName.Create("julie", "lerman");

            Assert.AreEqual(pfn1, pfn2);
        }


        [TestMethod]
        public void CanValidateTwoPFNREquality()
        {
            var pfnr1 = PersonFullNameRecord.Create("julie", "lerman");
            var pfnr2 = PersonFullNameRecord.Create("julie", "lerman");

            Assert.AreEqual(pfnr1, pfnr2);
        }

        [TestMethod]
        public void CanValidateTwoPFNEqualitywithEquals()
        {
            var pfn1 = PersonFullName.Create("julie", "lerman");
            var pfn2 = PersonFullName.Create("julie", "lerman");

            Assert.IsTrue(pfn1.Equals(pfn2));
        }


        [TestMethod]
        public void CanValidateTwoPFNREqualitywithEquals()
        {
            var pfnr1 = PersonFullNameRecord.Create("julie", "lerman");
            var pfnr2 = PersonFullNameRecord.Create("julie", "lerman");

            Assert.IsTrue(pfnr1.Equals( pfnr2));
        }

        [TestMethod]
        public void CanValidateTwoPFNEqualityOperator()
        {
            var pfn1 = PersonFullName.Create("julie", "lerman");
            var pfn2 = PersonFullName.Create("julie", "lerman");

            Assert.IsTrue(pfn1 == pfn2);
        }

        [TestMethod]
        public void CanValidateTwoPFNREqualityOperator()
        {
            var pfnr1 = PersonFullNameRecord.Create("julie", "lerman");
            var pfnr2 = PersonFullNameRecord.Create("julie", "lerman");

            Assert.IsTrue(pfnr1 == pfnr2);
        }

        [TestMethod]
        public void CanDetectTwoPFNNonEquality()
        {
            var pfn1 = PersonFullName.Create("Julie", "lerman");
            var pfn2 = PersonFullName.Create("julie", "lerman");

            Assert.AreNotEqual(pfn1, pfn2);
        }

        [TestMethod]
        public void CanDetectTwoPFNRNonEquality()
        {
            var pfnr1 = PersonFullNameRecord.Create("Julie", "lerman");
            var pfnr2 = PersonFullNameRecord.Create("julie", "lerman");

            Assert.AreNotEqual(pfnr1, pfnr2);
        }

        [TestMethod]
        public void CanDetectTwoPFNNonEqualityOperator()
        {
            var pfn1 = PersonFullName.Create("Julie", "lerman");
            var pfn2 = PersonFullName.Create("julie", "lerman");

            Assert.IsFalse(pfn1 == pfn2);
        }

        [TestMethod]
        public void CanDetectTwoPFNRNonEqualityOperator()
        {
            var pfnr1 = PersonFullNameRecord.Create("Julie", "lerman");
            var pfnr2 = PersonFullNameRecord.Create("julie", "lerman");

            Assert.IsFalse(pfnr1 == pfnr2);
        }
        [TestMethod]
        public void CanCreateAuthor()
        {
            var author=new Author("Julie", "Lerman");

            Assert.AreEqual("Julie Lerman", author.Name.FullName);
        }

        [TestMethod]
        public void CanFixAuthorName()
        {
            var author = new Author("Julie", "lerman");
            author.FixAuthorName("Julie", "Lerman");
            Assert.AreEqual("Julie Lerman", author.Name.FullName);
        }

        [TestMethod]
        public void CanGenerateNewFamilyMemberName()
        {
            var author = new Author("Julie", "Lerman");
            var newname=author.Name.FamilyMemberWithSameSurname("Sampson");
            Assert.AreEqual("Sampson Lerman",newname.FullName);
        }
    }
}