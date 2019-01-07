using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookFeatures;
using System.Threading;

namespace FacebookFeatures
{
    public class SendingMessages
    {
        private IMessages eMailMessage;
        private IMessages statusMessage;

        public SendingMessages()
        {
            eMailMessage = new EMailMessage();
            statusMessage = new StatusMessage();
        }

        public void SendStatusMessage()
        {
            statusMessage.SendMessage();
        }

        public void SendEmailMessage()
        {
            eMailMessage.SendMessage();
        }
    }
}
