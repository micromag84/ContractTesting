namespace ContractTesting.Core.Interfaces
{
    public class FileDataRangeProvider : IDataRangeProvider
    {
        public int GetValidRange()
        {
            return 10;
        }
    }
}