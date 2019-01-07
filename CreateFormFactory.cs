using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookFeatures;

namespace FacebookFeatures
{
    public static class CreateFormFactory
    {
        /// <summary>
        /// This is our factory class
        /// </summary>
        public static Form Create(object i_formName)
        {
            Form specificForm = null;
           /// SendingMessages specificMessages = null;

            string[] myGadgetsName = { "Search posts by date", "Search likes in google", "Save friends list"};

            if (i_formName == myGadgetsName[0])
            {
                specificForm = new FormGajetOne();
            }
            else if (i_formName == myGadgetsName[1])
            {
                specificForm = new FormGajetTwo();
            }
            else if (i_formName == myGadgetsName[2])
            {
                specificForm = new FormGajetThree();
            }
            return specificForm;
        }
    }
}
