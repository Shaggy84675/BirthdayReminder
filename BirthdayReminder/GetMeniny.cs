using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayReminder
{
    class GetMeniny
    {
        public static DateTime MeninyDate(string name)
        {
            return SeznamMenin.meno.FirstOrDefault(x => x.Value == name).Key;
        }
    }
}
