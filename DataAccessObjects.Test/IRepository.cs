﻿//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace KoalaShopLib.Test
//{
//    [TestClass]
//    public class IRepository
//    {
//        IDALController target = null;

//        [TestInitialize]
//        public void Init()
//        {
//            this.target = DALFactory.CreateDALController();
//        }

//        [TestMethod]
//        public void GetAll()
//        {
//            var entities = this.target.CategoryRepo.GetAll();
//            Assert.IsNotNull(entities);
//        }

//        [TestMethod]
//        public void Add()
//        {
//            bool isAdded = this.target.CategoryRepo.Add(new KoalaShopLib.Models.Category() { Name="Test"});

//            Assert.IsTrue(isAdded);
//        }
//    }
//}
