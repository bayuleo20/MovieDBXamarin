using MovieDBSecond.ViewModels;
using NUnit.Framework;
using System;

namespace UnitTest
{
    [TestFixture]
    public class Test
    {
        Boolean isTest = true;
        [Test]
        public void TestCase()
        {
            //Arrange
            

            var vm = new MovieDetailViewModel(isTest);
            //vm.Number1 = 2;
            //vm.Number2 = 3;

            //Act
            //vm.ButtonCalculate.Execute(null);
            vm.Perkalian(2, 2);

            //Assert
            //Assert.IsTrue(5 == 5, "Salah");
            Assert.AreNotEqual(5, vm.Result);
        }
    }
}
