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
                    if(line2[1] == " ")
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
                else
                {
                    if(line2[0] == " ")
                    {
                        return 7;
                    }
                    else
                    {
                        return 9;
                    }
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
            return -1;
        }

        public int[] ReadAccountNumber(string[] line1, string[] line2, string[] line3)
        {
            var accountNumber = new List<int>();

            for (var i = 0; i < line1.Length; i += 3)
            {
                var j = i + 3;
                accountNumber.Add(ReadDigit(line1[i..j], line2[i..j], line3[i..j]));
            }
            
            return accountNumber.ToArray();
        }
    }
}