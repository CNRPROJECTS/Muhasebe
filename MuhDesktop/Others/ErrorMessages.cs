using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhDesktop.Others
{
    class ErrorMessages
    {
        public enum MessageTypes
        {
            Error = 1,
            Info = 2,
            Warning = 3

        }
        public void ShorErrorMessages(MessageTypes MessageType, string Message)
        {
            switch (MessageType)
            {
                case MessageTypes.Error:
                    MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case MessageTypes.Info:
                    MessageBox.Show(Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case MessageTypes.Warning:
                    MessageBox.Show(Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
           
        }
    }
}
