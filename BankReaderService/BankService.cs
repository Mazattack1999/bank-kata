using System.Formats.Asn1;

namespace BankReaderService
{
    public class BankReader
    {
        public int ReadDigit(List<string[]> lines)
        {
            if (IsZero(lines))
            {
                return 0;
            }
            else if (IsOne(lines))
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
            else if(IsFour(lines))
            {
                return 4;
            }
            else if(IsFive(lines))
            {
                return 5;
            }
            else if(IsSix(lines))
            {
                return 6;
            }
            else if(IsSeven(lines))
            {
                return 7;
            }
            else if(IsEight(lines))
            {
                return 8;
            }
            else if(IsNine(lines))
            {
                return 9;
            }
            return -1;
        }

        private bool IsZero(List<string[]> lines)
        {
            var zeroText = new List<string[]> {
                new string[] {" ", "_", " "},
                new string[] {"|", " ", "|"},
                new string[] {"|", "_", "|"}
            };
            return ListsAreEqual(lines, zeroText);
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

        private bool IsFour(List<string[]> lines)
        {
            var fourText = new List<string[]> {
                new string[] {" ", " ", " "},
                new string[] {"|", "_", "|"},
                new string[] {" ", " ", "|"}
            };
            return ListsAreEqual(lines, fourText);
        }

        private bool IsFive(List<string[]> lines)
        {
            var fiveText = new List<string[]> {
                new string[] {" ", "_", " "},
                new string[] {"|", "_", " "},
                new string[] {" ", "_", "|"}
            };
            return ListsAreEqual(lines, fiveText);
        }

        private bool IsSix(List<string[]> lines)
        {
            var sixText = new List<string[]> {
                new string[] {" ", "_", " "},
                new string[] {"|", "_", " "},
                new string[] {"|", "_", "|"}
            };
            return ListsAreEqual(lines, sixText);
        }

        private bool IsSeven(List<string[]> lines)
        {
            var sevenText = new List<string[]> {
                new string[] {" ", "_", " "},
                new string[] {" ", " ", "|"},
                new string[] {" ", " ", "|"}
            };
            return ListsAreEqual(lines, sevenText);
        }

        private bool IsEight(List<string[]> lines)
        {
            var eightText = new List<string[]> {
                new string[] {" ", "_", " "},
                new string[] {"|", "_", "|"},
                new string[] {"|", "_", "|"}
            };
            return ListsAreEqual(lines, eightText);
        }

        private bool IsNine(List<string[]> lines)
        {
            var nineText = new List<string[]> {
                new string[] {" ", "_", " "},
                new string[] {"|", "_", "|"},
                new string[] {" ", " ", "|"}
            };
            return ListsAreEqual(lines, nineText);
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