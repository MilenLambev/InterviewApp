﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayNumbers displayNumbers = new DisplayNumbers();
            displayNumbers.DisplayNumbersInRange(1, 100);
        }
    }
}
