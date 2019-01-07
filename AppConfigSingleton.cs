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
    public sealed class AppConfigSingleton
    {
        private static volatile AppConfigSingleton instante;

        public static AppConfigSingleton Instante
        {
            get
            {
                if (instante == null)
                {
                    instante = new AppConfigSingleton();
                }

                return instante; 
            } 
        }

        public string AccessToken { get; set; }

        public bool CheckBoxChecked { get; set; }

        public bool ItsLogIn { get; set; }

        public object DeserialzeInstante()
        {
            object data;
            XmlSerializer serializer = new XmlSerializer(typeof(AppConfigSingleton));
            try
            {
                using (TextReader reader = new StreamReader(StaticMethods.Database.SerializeFileName()))
                {
                    var ReaderData = serializer.Deserialize(reader);
                    data = ReaderData as AppConfigSingleton;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return data;
        }
    }
}
