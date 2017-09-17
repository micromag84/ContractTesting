﻿using ContractTesting.Core.Interfaces;

namespace ContractTesting.Core
{
    public class FileDataRangeProvider : IDataRangeProvider
    {
        public int GetValidRange()
        {
            return 10;
        }
    }
}