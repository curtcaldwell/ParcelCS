using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcel.Controllers;
using Parcel.Models;

namespace Parcel.Tests
{
  [TestClass]
  public class ParcelTest
  {
    [TestMethod]
    public void Volume_Returns_True()
    {
      //Arrange
      int _width = 2;
      int _height = 2;
      int _length = 2;
      int _volume = ParcelVariable.GetVolume();
      ParcelVariable newParcelVariable = new ParcelVariable(_volume);



      //Act


      //Assert
      Assert.AreEqual(8, _volume);
    }
  }
}
