using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakobSRP
{
    public class MessageSender : ISender
    {
        public bool SendMessage(ISender.MessageCarrier type, Message m, bool isHTML)
        {
            try
            {
                if (isHTML)
                    m.Body = MessageConverter.ConvertBodyToHTML(m.Body);

                if (type.Equals(ISender.MessageCarrier.Smtp))
                {
                    // Her implementeres alt koden til at sende via Smtp
                }
                else if (type.Equals(ISender.MessageCarrier.VMessage))
                {
                    // Her implementeres alt koden til at sende via VMessage
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool SendMessageToAll(ISender.MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            try
            {
                if (isHTML)
                    m.Body = MessageConverter.ConvertBodyToHTML(m.Body);

                if (type.Equals(ISender.MessageCarrier.Smtp))
                {
                    // Her implementeres alt koden til at sende via Smtp
                }
                else if (type.Equals(ISender.MessageCarrier.VMessage))
                {
                    // Her implementeres alt koden til at sende via VMessage
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
