// (c) gfoidl, all rights reserved

using System.Collections.Generic;

namespace gfoidl.Trx2Junit.Core.Models.JUnit;

public sealed class JUnitTest : Test
{
    public List<JUnitTestSuite> TestSuites { get; set; } = new();
}
