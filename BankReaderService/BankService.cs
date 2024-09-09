namespace BankReaderService
{
    public class BankReader
    {
        // public int ReadDigit(string[] line1, string[] line2, string[] line3)
        // {
        //     if (line3[2] == " ")
        //     {
        //         return 2;
        //     }
        //     else if (line3[0] == " " && line3[1] == " " && line3[2] == "|")
        //     {
        //         if (line1[1] == " ")
        //         {
        //             if(line2[1] == " ")
        //             {
        //                 return 1;
        //             }
        //             else
        //             {
        //                 return 4;
        //             }
        //         }
        //         else
        //         {
        //             if(line2[0] == " ")
        //             {
        //                 return 7;
        //             }
        //             else
        //             {
        //                 return 9;
        //             }
        //         }
        //     }
        //     else if (line3[0] == "|" && line3[1] == "_" && line3[2] == "|")
        //     {
        //         if (line2[1] == " ")
        //         {
        //             return 0;
        //         }
        //         else if (line2[2] == " ")
        //         {
        //             return 6;
        //         }
        //         else
        //         {
        //             return 8;
        //         }
        //     }
        //     else if (line3[0] == " " && line3[1] == "_" && line3[2] == "|")
        //     {
        //         if (line2[2] == " ")
        //         {
        //             return 5;
        //         }
        //         else
        //         {
        //             return 3;
        //         }
        //     }
        //     return -1;
        // }

        public int ReadDigit(List<string[]> lines)
        {
            if (IsOne(lines))
            {
                return 1;
            }
            else if (IsTwo(lines))
            {
                return 2;
            }
            else if(IsThree(lines))
            {
                return 3;
            }
            return -1;
        }

        private bool IsOne(List<string[]> lines)
        {
            var oneText = new List<string[]> {
                new string[] {" ", " ", " "},
                new string[] {" ", " ", "|"},
                new string[] {" ", " ", "|"}
            };
            return ListsAreEqual(lines, oneText);
        }
        private bool IsTwo(List<string[]> lines)
        {
            var twoText = new List<string[]> {
                new string[] {" ", "_", " "},
                new string[] {" ", "_", "|"},
                new string[] {"|", "_", " "}
            };
            return ListsAreEqual(lines, twoText);
        }
        private bool IsThree(List<string[]> lines)
        {
            var threeText = new List<string[]> {
                new string[] {" ", "_", " "},
                new string[] {" ", "_", "|"},
                new string[] {" ", "_", "|"}
            };
            return ListsAreEqual(lines, threeText);
        }
        
        public int[] ReadAccountNumber(List<string[]> lines)
        {
            var accountNumber = new List<int>();

            for (var i = 0; i < lines[0].Length; i += 3)
            {
                var j = i + 3;
                var digitText = new List<string[]> {lines[0][i..j], lines[1][i..j], lines[2][i..j]};
                accountNumber.Add(ReadDigit(digitText));
            }
            
            return accountNumber.ToArray();
        }

        private bool ListsAreEqual(List<string[]> lines, List<string[]> numberLines)
        {
            for (var i = 0; i < lines.Count; i++)
            {
                for(var j = 0; j < lines[0].Length; j++)
                {
                    if (lines[i][j] != numberLines[i][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}