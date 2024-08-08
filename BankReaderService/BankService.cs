namespace BankReaderService
{
    public class BankReader
    {
        public int ReadDigit(string[] line1, string[] line2, string[] line3)
        {
            if (line1[1] == "_")
            {
                if (line2[1] == "_")
                {

                }
                else
                {
                    if (line2[0] == "|")
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
            else
            {
                if (line1[0] == " ")
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
            return -1;
        }
    }
}