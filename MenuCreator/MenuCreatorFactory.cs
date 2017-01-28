using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCreator
{
    public class MenuCreatorFactory : IMenuCreator
    {
        public MenuGenerator CreateMenu(string s)
        {
            if (s.Equals("diner", StringComparison.CurrentCultureIgnoreCase))
            {
                MenuGenerator dinerGen = new DinerGenerator();
                return dinerGen;
            }
            else if (s.Equals("evening", StringComparison.CurrentCultureIgnoreCase))
            {
                MenuGenerator eveningGen = new EveningOnlyGenerator();
                return eveningGen;
            }
            else if (s.Equals("allday", StringComparison.CurrentCultureIgnoreCase))
            {
                MenuGenerator alldayGen = new AllDayGenerator();
                return alldayGen;
            }

            return null;
        }
    }
}
