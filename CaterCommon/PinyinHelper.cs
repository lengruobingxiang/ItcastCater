using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.International.Converters.PinYinConverter;

namespace CaterCommon
{
    public partial class PinyinHelper
    {
        public static string GetPinyinInitial(string chnStr)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in chnStr)
            {
                ChineseChar chnChar = new ChineseChar(c);
                sb.Append(chnChar.Pinyins[0][0]);
            }
            return sb.ToString();
        }
    }
}
