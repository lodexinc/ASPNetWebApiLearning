using NUnit.Framework;
using System;

namespace ASPNetWebApiLearning.Data.PostgreSQL.Test
{
    [TestFixture]
    public class PostgreSQLRepositoryTests
    {
        [Test]
        public void PostgreSQL_Constructor_Initialize()
        {
            PostgreSQLRepository repository = new PostgreSQLRepository();
            Console.WriteLine("PostgreSQL_Constructor_Initialize");
            Assert.IsNotNull(repository);
        }
    }
}
