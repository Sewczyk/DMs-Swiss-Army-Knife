﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControlAndData.Ciphers;
using static ControlAndData.Miscellaneous.Constants;

namespace ControlAndData
{
    public class Controller
    {
        List<ICipher> AllCiphers { get; }
        
        public Controller()
        {
            AllCiphers.Add(new CaesarCipher());
        }
        
    }
}
