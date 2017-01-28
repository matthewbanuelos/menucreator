using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCreator
{
    public interface IMenuFormatter
    {
        MenuFormatter CreateFormatter(string s);
    }
}
