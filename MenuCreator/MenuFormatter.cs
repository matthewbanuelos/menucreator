using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCreator
{
    public abstract class MenuFormatter
    {
        public abstract void FormatMenu<T>(string outputFile, T items);
    }
}
