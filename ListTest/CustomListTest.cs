﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustList;

namespace ListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]    //ADDING ITEMS TESTS
        public void Add_AddItemToEmptyList_ItemToIndexZero() 
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            //act
            testList.Add(4);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        
        }

        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrements() 
        {
            //arrange
            CustomListTest<string> testList = new CustomList<string>();
            string expected = 1;
            string actual;

            //act
            testList.Add("Bankhead Bounce");
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddItemToListWithItemsAlreadyInIt_NewItemsGoesToLastIndex() 
        {
            //arrange
            CustomList<bool> testList = new CustomList<bool>();
            bool expected = true;
            bool actual;

            //act
            testList.Add(false);
            testList.Add(true);
            testList.Add(true);
            testList.Add(false);

            //assert
            Assert.AreEqual(expected, actual);
        
        }

        [TestMethod]
        public void Add_AddMultipleItemsWithCount_CountResult() 
        {
            //arrange
            CustomList<double> testList = new CustomList<double>();
            double expected = 4;
            double actual;

            //act
            testList.Add(22);
            testList.Add(12);
            testList.Add(66);
            testList.Add(77);



            //assert
            Assert.AreEqual(expected, actual);
        
        }

        [TestMethod]
        public void Add_AddItemToMaxedOutList_CapacityIncrease() 
        {
            //arrange
            CustomList<int> testList = new CustomList<>(int);
            int expected = 8;       //array duplicates
            int actual;

            //act
            testList.Add(22);
            testList.Add(12);
            testList.Add(66);
            testList.Add(77);

            testList.Add(88);
            testList.Add(99);


            //assert
            Assert.AreEqual(expected, actual);
        
        }

        [TestMethod]        //REMOVAL TESTS
        public void Remove_RemoveItemFromFullList_ItemIndexZero()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            testList.Add(22);
            testList.Add(12);
            testList.Add(66);
            testList.Add(77);

            //act
            testList.Remove(22);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_RemoveItemFromListOfItems_CountIncrements()
        {
            //arrange
            CustomListTest<string> testList = new CustomList<string>();
            string expected = "3";
            string actual;
           
            testList.Add("Twerk");
            testList.Add("Bankhead Bounce");
            testList.Add("MC Hammer");
            testList.Add("Chi-town Slide");
            
            //act
            testList.Remove("Twerk");
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_RemoveItemFromFromListOfItems_ItemInIndexOneGoesToIndexZero()
        {
            //arrange
            CustomList<bool> testList = new CustomList<bool>();
            bool expected = true;
            bool actual;

            testList.Add(false);
            testList.Add(true);
            testList.Add(true);
            testList.Add(false);

            //act
            testList.Remove(true);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_RemoveItemFromListOfMultipleItems_CountDecreasesFromAmountTotal()
        {
            //arrange
            CustomList<double> testList = new CustomList<double>();
            double expected = 3;
            double actual;

            testList.Add(52);
            testList.Add(23);
            testList.Add(84);
            testList.Add(28);

            //act
            testList.Remove(52);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_RemoveItemFromListOfMultipleItems_CapacityRemainsTheSameForFutureItemsToAdd()
        {
            //arrange
            CustomList<float> testList = new CustomList<float>();
            float expected = 6;
            float actual;

            testList.Add(22);
            testList.Add(12);
            testList.Add(66);
            testList.Add(77);

            testList.Add(88);
            testList.Add(99);

            //act
            testList.List.Remove(22);
            actual = testList.Capacity;



            //assert
            Assert.AreEqual(expected, actual);

        }


    }
}
