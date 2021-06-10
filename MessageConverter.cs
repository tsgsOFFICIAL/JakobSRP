using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakobSRP
{
    public abstract class MessageConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string ConvertBodyToHTML(string plainText)
        {
            return $"{plainText}";
        }
    }
}
