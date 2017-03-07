using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Leanwork.CodePack.Tests.Extensions
{
    [TestClass]
    public class CollectionExtensions_Should
    {
        [TestMethod]
        public void Find_and_remove_successfully()
        {            
            //arrange
            var items = new List<string>() { "1", "a", "@", "2", "b", "#", "3", "c" };

            //act
            var result = items.FindAndRemove(x => x == "@");

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Find_and_remove_unsuccessfully()
        {
            //arrange
            var items = new List<string>() { "1", "a", "@", "2", "b", "#", "3", "c" };

            //act
            var result = items.FindAndRemove(x => x == "@@");

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Find_and_remove_an_object_successfully()
        {
            //arrange
            var id = Guid.NewGuid();

            var items = new List<ColItem>()
            {
                new ColItem(),
                new ColItem(),
                new ColItem(id),
                new ColItem(),
                new ColItem()
            };

            //act
            var result = items.FindAndRemove(x => x.Id == id);

            //assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void Find_and_remove_an_object_unsuccessfully()
        {
            //arrange
            var id = Guid.NewGuid();

            var items = new List<ColItem>()
            {
                new ColItem(),
                new ColItem(),
                new ColItem(),
                new ColItem(),
                new ColItem()
            };

            //act
            var result = items.FindAndRemove(x => x.Id == id);

            //assert
            Assert.IsFalse(result);
        }
    }

    public class ColItem
    {
        public Guid Id { get; set; }

        public ColItem()
        {
            Id = Guid.NewGuid();
        }

        public ColItem(Guid id)
        {
            Id = id;
        }
    }
}
