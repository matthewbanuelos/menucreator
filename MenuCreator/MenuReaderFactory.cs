using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCreator
{
    public class MenuReaderFactory : IReader
    {
        public MenuReader CreateReader(string readerCountry)
        {
            if (readerCountry.Equals("gb", StringComparison.CurrentCultureIgnoreCase))
            {
                MenuReader xmlReader = new XMLMenuReader();
                return xmlReader;
            }
            else if (readerCountry.Equals("us", StringComparison.CurrentCultureIgnoreCase))
            {
                MenuReader jsonReader = new JSONMenuReader();
                return jsonReader;
            }
            else
            {
                return null;
            }
        }
    }
}
