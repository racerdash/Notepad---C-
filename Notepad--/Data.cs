using System;
using System.Collections.Generic;
using System.Text;

namespace Notepad__
{
    internal class Data
    { 
        public static int searchString(string source, string toFind, int currentPos, bool isChecked)
        {
            int posCursor = 0; 

            if (isChecked == true)
            {
                posCursor = source.IndexOf(toFind, currentPos);
            }
            else
            {
                posCursor = source.LastIndexOf(toFind, currentPos);
            }

            return posCursor;
        }
    }
}
