using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballPlayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace FootballPlayers.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer footballPlayer = new FootballPlayer { Id = 1,Name= "Eriksen", Age = 30, ShirtNo = 14 };
        private FootballPlayer footballPlayerneagtiveAge = new FootballPlayer { Id = 2, Name = "Ronaldo", Age = -1, ShirtNo = 7 };
        private FootballPlayer footballPlayername = new FootballPlayer { Id = 3, Name = "A", Age = 30, ShirtNo = 11 };
        private FootballPlayer footballPlayerShirtNo = new FootballPlayer { Id = 4, Name = "Messi", Age = 30, ShirtNo = 111 };
        [TestMethod()]
        public void ToStringTest()
        {
            string str = footballPlayer.ToString();   // act
            Assert.AreEqual("1,Eriksen,30,14", str);  // assert
        }
        [TestMethod()]
        public void ValidateNegativeAgeTest()
        {
           // footballPlayer.ValidateAge();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayerneagtiveAge.ValidateAge());
        }
        [TestMethod()]
        public void ValidatePlayerName()
        {
            //footballPlayer.ValidateName();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayername.ValidateName());
        }
        [TestMethod()]
         public void ValidatePlayerShirtNumber()
        {
           // footballPlayer.ValidateShirtNo();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayerShirtNo.ValidateShirtNo());
           

        }
        //[TestMethod()]
        //public void ValidateTest()
        //{
        //    footballPlayer.Validate();
        //    Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayerneagtiveAge.Validate());
        //    Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayername.Validate());
        //    Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayerShirtNo.Validate());
        //}
           

        [TestMethod()]
        [DataRow(2)]
        [DataRow(100)]
        [DataRow(14593)]
        public void ValidaAgeTest(int age)
        {
            footballPlayer.Age = age ;
            footballPlayer.ValidateAge();
        }
       
        public void ValidaShirtNo(int shirtnumber)
        {
            footballPlayer.ShirtNo= shirtnumber;
            footballPlayer.ValidateShirtNo();
           
        }
        public void ValidateName(string name)
        {
            footballPlayer.Name = name; 
            footballPlayer.ValidateName();  
        }

    }
}