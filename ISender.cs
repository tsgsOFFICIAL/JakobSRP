using System;

namespace JakobSRP
{
    public interface ISender
    {
        /// <summary>
        /// MessageCarrier is the type of carrier used to send out the message
        /// </summary>
        public enum MessageCarrier { Smtp, VMessage }
        /// <summary>
        /// This method sends a message
        /// </summary>
        /// <param name="type"></param>
        /// <param name="m"></param>
        /// <param name="isHTML"></param>
        /// <returns>This method returns a boolean value, representing the state of the action. True means it passed, false equals it failed</returns>
        bool SendMessage(MessageCarrier type, Message m, bool isHTML);

        /// <summary>
        /// This method sends a single message to multiple people
        /// </summary>
        /// <param name="type"></param>
        /// <param name="to"></param>
        /// <param name="m"></param>
        /// <param name="isHTML"></param>
        /// <returns>This method returns a boolean value, representing the state of the action. True means it passed, false equals it failed</returns>
        bool SendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML);
    }
}
