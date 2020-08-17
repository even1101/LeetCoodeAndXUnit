using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode_XUnitTests.TestData
{
    public class TestData
    {
        private static readonly List<object[]> Data7 = new List<object[]>
        {
            new object[] { -123, -321 },
            new object[] { 1230, 321 },
            new object[] { -320, -23 }
        };

        public static IEnumerable<object[]> TestData7 => Data7;
       }
}
