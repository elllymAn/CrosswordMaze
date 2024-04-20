namespace wordSqlLibrary
{
    public class WordModel
    {
        //public int Id { get; set; }
        public string Word { get; set; }
        //public string Query { get; set; }
        //public string Topic { get; set; }
        //public int Difficulty { get; set; }
        public string Query { get; set; }
        public string TestData
        {
            get
            {
                return "";//Id.ToString() + " " + Word + " " + Topic + " " + Difficulty.ToString();
            }
        }
    }
}
