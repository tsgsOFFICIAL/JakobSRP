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
        /// Converts a string body to HTML
        /// </summary>
        /// <param name="plainText">String body</param>
        /// <returns>This method returns the converted body, as a string with apropriate HTML tags</returns>
        public static string ConvertBodyToHTML(string plainText)
        {
            return $"{plainText}";
        }
    }
}
