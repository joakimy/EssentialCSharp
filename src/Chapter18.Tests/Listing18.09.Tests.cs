﻿
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_09.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod][Ignore]
        public void ValueTaskAsyncReturnTest()
        {
            string expected = "";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });

        }
    }
}