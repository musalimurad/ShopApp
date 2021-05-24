﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Helpers
{
    static class Utilities
    {
        public static bool IsEmpty(string [] arr)
        {
            foreach (var item in arr)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    return false;
                }
              
            }
            return true;
        }
    }
}
