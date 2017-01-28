using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCreator
{
    public class MenuFormatterFactory : IMenuFormatter
    {
        public MenuFormatter CreateFormatter(string s)
        {
            if (s.Equals("plain", StringComparison.CurrentCultureIgnoreCase))
            {
                MenuFormatter plain = new PlainTextFormatter();
                return plain;
            }
            else if (s.Equals("html", StringComparison.CurrentCultureIgnoreCase))
            {
                MenuFormatter html = new HTMLFormatter();
                return html;
            }
            else if (s.Equals("xml", StringComparison.CurrentCultureIgnoreCase))
            {
                MenuFormatter xml = new XMLFormatter();
                return xml;
            }

            return null;
        }
    }
}