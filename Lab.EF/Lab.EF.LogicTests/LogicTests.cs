using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.EF.Logic;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Data.Entity;
using Lab.EF.Data;
using Castle.Core.Configuration;

namespace Lab.EF.Logic.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ShipperAddTest()
        {
            var data = new List<Shipper>
            {
                new Shipper
                {
                    ShipperID = 1,
                    CompanyName = "ABC"
                }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Shipper>>();
            mockSet.As<IQueryable<Shipper>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Shipper>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Shipper>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Shipper>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.Shippers).Returns(mockSet.Object);

            ShippersLogic shippersLogic = new ShippersLogic(mockContext.Object);

            shippersLogic.Add(new Shipper
            {
                ShipperID = 2,
                CompanyName = "ABC"
            });
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ShipperFindTest()
        {
            var data = new List<Shipper>
            {
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Shipper>>();
            mockSet.As<IQueryable<Shipper>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Shipper>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Shipper>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Shipper>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.Shippers).Returns(mockSet.Object);

            ShippersLogic shippersLogic = new ShippersLogic(mockContext.Object);

            shippersLogic.Find(1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ShipperGetAllTest()
        {
            var data = new List<Shipper>
            {
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Shipper>>();
            mockSet.As<IQueryable<Shipper>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Shipper>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Shipper>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Shipper>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.Shippers).Returns(mockSet.Object);

            ShippersLogic shippersLogic = new ShippersLogic(mockContext.Object);

            shippersLogic.GetAll();
        }



        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CategoryAddTest()
        {
            var data = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "ABC"
                }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Category>>();
            mockSet.As<IQueryable<Category>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.Categories).Returns(mockSet.Object);

            CategoriesLogic categoriesLogic = new CategoriesLogic(mockContext.Object);

            categoriesLogic.Add(new Category
            {
                CategoryID = 2,
                CategoryName = "ABC"
            });
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CategoryFindTest()
        {
            var data = new List<Category>
            {
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Category>>();
            mockSet.As<IQueryable<Category>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.Categories).Returns(mockSet.Object);

            CategoriesLogic categoriesLogic = new CategoriesLogic(mockContext.Object);

            categoriesLogic.Find(1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CategoryGetAllTest()
        {
            var data = new List<Category>
            {
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Category>>();
            mockSet.As<IQueryable<Category>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.Categories).Returns(mockSet.Object);

            CategoriesLogic categoriesLogic = new CategoriesLogic(mockContext.Object);

            categoriesLogic.GetAll();
        }
    }
}