﻿using BankReaderService;

namespace BankReaderServiceTests
{
    public class BankReaderServiceTests
    {
        [TestCase(
        new string[] {" ", "_", " "},
        new string[] {"|", " ", "|"},
        new string[] {"|", "_", "|"},
        0
        )]
        [TestCase(
        new string[] {" ", " ", " "},
        new string[] {" ", " ", "|"},
        new string[] {" ", " ", "|"},
        1
        )]
        [TestCase(
        new string[] {" ", "_", " "},
        new string[] {" ", "_", "|"},
        new string[] {"|", "_", " "},
        2
        )]
        [TestCase(
        new string[] {" ", "_", " "},
        new string[] {" ", "_", "|"},
        new string[] {" ", "_", "|"},
        3
        )]
        [TestCase(
        new string[] {" ", " ", " "},
        new string[] {"|", "_", "|"},
        new string[] {" ", " ", "|"},
        4
        )]
        [TestCase(
        new string[] {" ", "_", " "},
        new string[] {"|", "_", " "},
        new string[] {" ", "_", "|"},
        5
        )]
        [TestCase(
        new string[] {" ", "_", " "},
        new string[] {"|", "_", " "},
        new string[] {"|", "_", "|"},
        6
        )]
        [TestCase(
        new string[] {" ", "_", " "},
        new string[] {" ", " ", "|"},
        new string[] {" ", " ", "|"},
        7
        )]
        [TestCase(
        new string[] {" ", "_", " "},
        new string[] {"|", "_", "|"},
        new string[] {"|", "_", "|"},
        8
        )]
        [TestCase(
        new string[] {" ", "_", " "},
        new string[] {"|", "_", "|"},
        new string[] {" ", " ", "|"},
        9
        )]
        public void ReadDigit(string[] line1, string[] line2, string[] line3, int expectedDigit)
        {
            var bankReader = new BankReader();
            var digit = bankReader.ReadDigit(line1, line2, line3);

            Assert.That(digit, Is.EqualTo(expectedDigit));
        }
    }
}