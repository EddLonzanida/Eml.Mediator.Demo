﻿using System.Collections;
{
    internal class AllCommandsTestCases : IEnumerable<TestCaseData>
    {
        public IEnumerator<TestCaseData> GetEnumerator()
        {
            return TypeExtensions.GetTestCaseEnumerator<TestCommand>(t => t.IsAssignableTo<ICommand>()
                                                                          && !t.Name.Contains("TestCommandWithNoEngine")
                                                                          && !t.Name.EndsWith("WithMultipleEngine"));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}