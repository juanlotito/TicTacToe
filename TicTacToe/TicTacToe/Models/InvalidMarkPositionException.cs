﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class InvalidMarkPositionException : Exception
    {
        public InvalidMarkPositionException(string message) : base(message)
        {

        }
    }
}
