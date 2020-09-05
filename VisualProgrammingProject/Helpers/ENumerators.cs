using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingProject.Helpers
{

    public enum Cash
    {
        [Description("100")]
        Answer1 = 1,
        [Description("200")]
        Answer2 = 2,
        [Description("300")]
        Answer3 = 3,
        [Description("500")]
        Answer4 = 4,
        [Description("1000")]
        Answer5 = 5,
        [Description("2000")]
        Answer6 = 6,
        [Description("4000")]
        Answer7 = 7,
        [Description("8000")]
        Answer8 = 8,
        [Description("16000")]
        Answer9 = 9,
        [Description("32000")]
        Answer10 = 10,
        [Description("64000")]
        Answer11 = 11,
        [Description("125000")]
        Answer12 = 12,
        [Description("250000")]
        Answer13 = 13,
        [Description("500000")]
        Answer14 = 14,
        [Description("1000000")]
        Answer15 = 15
    }

    public class Enumerators {

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }

    }
}
