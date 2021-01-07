using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureFinder.Core
{
    public class TreasureFinder
    {
        public IEnumerable<string> Solve(int[,] cells)
        {
            List<string> finderLog = new List<string>();
            bool targetCellIsFound = false;

            int xCoordinate = 0;
            int yCoordinate = 0;
            int cellValue = cells[xCoordinate, yCoordinate];
                        
            finderLog.Add(GetMessage(xCoordinate, yCoordinate, cellValue));

            while (targetCellIsFound == false)
            {
                if (CoordinateIsEqualsCellValue(xCoordinate, yCoordinate, cellValue))
                {
                    targetCellIsFound = true;
                    break;
                }

                xCoordinate = cellValue / 10 - 1;
                yCoordinate = cellValue % 10 - 1;
                cellValue = cells[xCoordinate, yCoordinate];
                finderLog.Add(GetMessage(xCoordinate, yCoordinate, cellValue));
            }

            return finderLog;
        }

        private string GetMessage(int x, int y, int cellValue)
        {
            return $"Coordinate in {x + 1}, {y + 1}: Value = {cellValue}";
        }

        private bool CoordinateIsEqualsCellValue(int x, int y, int cellValue)
        {
            int computedCellValue = GetComputedCellValue(x, y);
            if (computedCellValue == cellValue)
            {
                return true;
            }

            return false;
        }

        private int GetComputedCellValue(int x, int y)
        {
            return (x + 1) * 10 + (y + 1);
        }
    }
}
