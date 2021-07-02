using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace leetcodeCs
{
    [TestClass]
    public class Solution_89
    {
        public IList<int> GrayCode(int n)
        {
            var result = new List<int>();
            if (n == 1) { return new List<int>() { 0, 1 }; }
            var nextResult = GrayCode(n - 1);
            result.AddRange(nextResult.Select(x => x * 2));
            result.AddRange(nextResult.Select(x => x * 2 + 1).Reverse());
            return result;
        }
    }
}
