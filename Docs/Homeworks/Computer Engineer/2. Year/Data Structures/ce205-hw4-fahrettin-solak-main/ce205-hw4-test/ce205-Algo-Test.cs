﻿ using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce205_hw4_algo;

namespace ce205_hw4_test
{
    [TestClass]
    public class ce205_Algo_Test
    {
        /*******************************- AVLTree -***********************************/
        [TestMethod]
        public void AVLTreeInsertion()
        {
            AVLTree tree = new AVLTree();
            tree.insert(1, "Proin semper fermentum lorem. Vivamus vulputate auctor.");
            tree.insert(2, "Donec pharetra eros sagittis, mattis eros quis.");
            tree.insert(3, "Pellentesque dignissim tincidunt quam ut pulvinar. Aliquam.");

            Assert.AreEqual("Donec pharetra eros sagittis, mattis eros quis.", tree.root.data);
        }
        [TestMethod]
        public void AVLTreeDeletion()
        {
            AVLTree tree = new AVLTree();
            tree.insert(1, "Proin semper fermentum lorem. Vivamus vulputate auctor.");
            tree.insert(2, "Donec pharetra eros sagittis, mattis eros quis.");
            tree.insert(3, "Pellentesque dignissim tincidunt quam ut pulvinar. Aliquam.");
            tree.delete(2);

            Assert.AreEqual(0, tree.search(2));
        }
        [TestMethod]
        public void AVLTreeSearch()
        {
            AVLTree tree = new AVLTree();
            tree.insert(1, "Proin semper fermentum lorem. Vivamus vulputate auctor.");
            tree.insert(2, "Donec pharetra eros sagittis, mattis eros quis.");
            tree.insert(3, "Pellentesque dignissim tincidunt quam ut pulvinar. Aliquam.");

            Assert.AreEqual(1, tree.search(1));
        }

        /*******************************- RedBlackTree -***********************************/
        [TestMethod]
        public void RedBlackTreeInsertion()
        {
            RedBlackTree tree = new RedBlackTree();
            tree.Insert(1, "Proin semper fermentum lorem. Vivamus vulputate auctor.");
            tree.Insert(2, "Donec pharetra eros sagittis, mattis eros quis.");
            tree.Insert(3, "Pellentesque dignissim tincidunt quam ut pulvinar. Aliquam.");

            Assert.AreEqual("Donec pharetra eros sagittis, mattis eros quis.", tree.root.data);
        }
        [TestMethod]
        public void RedBlackTreeDeletion()
        {
            RedBlackTree tree = new RedBlackTree();
            tree.Insert(1, "Proin semper fermentum lorem. Vivamus vulputate auctor.");
            tree.Insert(2, "Donec pharetra eros sagittis, mattis eros quis.");
            tree.Insert(3, "Pellentesque dignissim tincidunt quam ut pulvinar. Aliquam.");
            tree.Delete(2);

            Assert.AreEqual("Proin semper fermentum lorem. Vivamus vulputate auctor.", tree.root.left.data);
        }
        [TestMethod]
        public void RedBlackTreeSearch()
        {
            RedBlackTree tree = new RedBlackTree();
            tree.Insert(1, "Proin semper fermentum lorem. Vivamus vulputate auctor.");
            tree.Insert(2, "Donec pharetra eros sagittis, mattis eros quis.");
            tree.Insert(3, "Pellentesque dignissim tincidunt quam ut pulvinar. Aliquam.");

            Assert.AreEqual(0, tree.Search(1));
        }

        /*******************************- HashingChaining -***********************************/
        [TestMethod]
        public void HashingwithChainingInsert()
        {
            HashingChaining hash = new HashingChaining(100);
            hash.HashingChainingInsert(1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            hash.HashingChainingInsert(2, "Aenean nec metus porta, feugiat quam ac, aliquet diam.");
            hash.HashingChainingInsert(3, "Vivamus eu odio sed lacus tincidunt mattis quis sed urna.");
            hash.HashingChainingInsert(4, "Duis sit amet odio et enim blandit mollis in vel dui.");

            Assert.AreEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", hash.table[1].First.Value.data);
        }

        /*******************************- OpenAdressing -***********************************/
        [TestMethod]
        public void HashingwithOpenAddressingLinearProbingTest()
        {
            OpenAddressing hash = new OpenAddressing(100);
            hash.OpenAddressingLinearProbingInsert(1, "Nunc faucibus metus ac nunc lacinia pretium.");
            hash.OpenAddressingLinearProbingInsert(2, "Nunc semper augue id leo tempor dictum.");
            hash.OpenAddressingLinearProbingInsert(3, "Aliquam posuere diam velit, id scelerisque neque.");

            Assert.AreEqual("Nunc faucibus metus ac nunc lacinia pretium.", hash.table[1].data);
        }
        [TestMethod]
        public void HashingwithOpenAddressingQuadraticProbingTest()
        {
            OpenAddressing hash = new OpenAddressing(100);
            hash.OpenAddressingQuadraticProbingInsert(1, "Duis ut velit at sapien pretium ultricies.");
            hash.OpenAddressingQuadraticProbingInsert(2, "Vivamus in velit lacus. Sed mattis, tortor.");
            hash.OpenAddressingQuadraticProbingInsert(3, "Duis vel lectus nunc. Phasellus eget molestie.");

            Assert.AreEqual("Duis vel lectus nunc. Phasellus eget molestie.", hash.table[3].data);
        }
        [TestMethod]
        public void HashingwithOpenAddressingDoubleProbingTest()
        {
            OpenAddressing hash = new OpenAddressing(100);
            hash.OpenAddressingDoubleProbingInsert(1, "Aenean malesuada, nunc id facilisis auctor, sem.");
            hash.OpenAddressingDoubleProbingInsert(2, "Aenean rutrum erat eget purus eleifend, vitae.");
            hash.OpenAddressingDoubleProbingInsert(3, "Cras mauris nulla, rhoncus a vulputate quis.");

            Assert.AreNotEqual("Cras mauris nulla, rhoncus a vulputate quis qultar.", hash.table[1].data);
        }
    }
}
