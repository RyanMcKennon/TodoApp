using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoDataAccess;
using Xunit;

namespace TodoTests
{
    public class TodoAppTests
    {
        [Fact]
        public void Test_AddItem()
        {
            var data = new EfDataAccess();
            var actual = data.AddItem("homework", false);

            Assert.True(actual);
        }

        [Fact]
        public void Test_DeleteItem()
        {
            var data = new EfDataAccess();
            var expected = 3;
            var actual = data.DeleteItem(expected);

            Assert.True(actual);
        }

        [Fact]
        public void Test_UpdateItem()
        {
            var data = new EfDataAccess();
            var expected = new List() { ItemID = 2, ItemName = "Homework still not done", Completed = false };
            var actual = data.updateList(expected);

            Assert.True(actual);
        }

        [Fact]
        public void Test_MarkItemComplete()
        {
            var data = new EfDataAccess();
            var expected = 2;
            var actual = data.MarkItemComplete(expected);

            Assert.True(actual);
        }

        [Fact]
        public void Test_GetList()
        {
            var data = new EfDataAccess();
            var actual = data.GetList();

            Assert.NotEmpty(actual);
        }

        [Fact]
        public void Test_GetCompletedItems()
        {
            var data = new EfDataAccess();
            var actual = data.GetCompletedItems();

            Assert.NotEmpty(actual);
        }

        [Fact]
        public void Test_GetUncompletedItems()
        {
            var data = new EfDataAccess();
            var actual = data.GetUncompletedItems();

            Assert.NotEmpty(actual);
        }
    }
}
