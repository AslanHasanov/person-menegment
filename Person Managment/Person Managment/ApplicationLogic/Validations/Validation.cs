﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Managment.ApplicationLogic.Validations
{
    internal class Validation
    {
        public static bool IsValidTextLenght(string text,int start, int end)
        {
            return text.Length>start && text.Length<=end;
        }

    }
}
