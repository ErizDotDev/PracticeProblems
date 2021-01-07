using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TreasureFinder.Test
{
    public class SolveTests
    {
        int[,] cells = new int[,]
        {
            { 34, 21, 32, 41, 25 },
            { 14, 42, 43, 14, 31 },
            { 54, 45, 52, 42, 23 },
            { 33, 15, 51, 31, 35 },
            { 21, 52, 33, 13, 23 }
        };

        [Fact]
        public void ShouldNotReturnNull()
        {
            Core.TreasureFinder treasureFinder = new Core.TreasureFinder();
            IEnumerable<string> finderLog = treasureFinder.Solve(cells);
            Assert.True(finderLog != null);
        }

        [Fact]
        public void ShouldReturnFinderLogWithContents()
        {
            Core.TreasureFinder treasureFinder = new Core.TreasureFinder();
            IEnumerable<string> finderLog = treasureFinder.Solve(cells);
            Assert.True(finderLog.Count() > 0);
        }

        [Fact]
        public void ShouldReturnCorrectAnswer()
        {
            Core.TreasureFinder treasureFinder = new Core.TreasureFinder();
            IEnumerable<string> finderLog = treasureFinder.Solve(cells);
            Assert.True(finderLog.Last() == "Coordinate in 5, 2: Value = 52");
        }

        [Fact]
        public void ShouldReturnCorrectFinderLogLength()
        {
            Core.TreasureFinder treasureFinder = new Core.TreasureFinder();
            IEnumerable<string> finderLog = treasureFinder.Solve(cells);
            Assert.True(finderLog.Count() == 19);
        }
    }
}
