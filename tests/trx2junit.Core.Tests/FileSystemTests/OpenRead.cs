// (c) gfoidl, all rights reserved

using NUnit.Framework;

namespace gfoidl.Trx2Junit.Core.Tests.FileSystemTests
{
    [TestFixture]
    public class OpenRead
    {
        [Test]
        public void Path_given___OK()
        {
            string path = "./data/trx/nunit.trx";
            var sut = new FileSystem();

            using (var actual = sut.OpenRead(path))
                Assert.IsNotNull(actual);
        }
    }
}
