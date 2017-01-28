using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCreator
{
    public abstract class MenuReader
    {
        public abstract T ReadMenu<T>();
    }
}
