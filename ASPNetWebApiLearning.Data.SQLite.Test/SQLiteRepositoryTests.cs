using NUnit.Framework;
using System;

namespace ASPNetWebApiLearning.Data.SQLite.Test
{
    [TestFixture]
    public class SQLiteRepositoryTests
    {
        [Test]
        public void SQLite_Constructor_Initialize()
        {
            SQLiteRepository repository = new SQLiteRepository();
            Console.WriteLine("PostgreSQL_Constructor_Initialize");
            Assert.IsNotNull(repository);
        }
    }
}
