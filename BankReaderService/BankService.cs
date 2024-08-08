namespace BankReaderService
{
    public class BankReader
    {
        public int ReadDigit(string[] line1, string[] line2, string[] line3)
        {
            if (line3[2] == " ")
            {
                return 2;
            }
            else if (line3[0] == " " && line3[1] == " " && line3[2] == "|")
            {
                if (line1[1] == " ")
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
            else if (line3[0] == "|" && line3[1] == "_" && line3[2] == "|")
            {
                if (line2[1] == " ")
                {
                    return 0;
                }
                else if (line2[2] == " ")
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
            else if (line3[0] == " " && line3[1] == "_" && line3[2] == "|")
            {
                if (line2[2] == " ")
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
            else if (line3[0] == " " && line3[1] == " " && line3[2] == "|")
            {
                if (line1[1] == " ")
                {
                    return 4;
                }
                else 
                {
                    return 9;
                }
            }
            return -1;
        }
    }
}