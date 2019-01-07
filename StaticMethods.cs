using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookFeatures
{
    public static class StaticMethods
    {
        public static class Database
        {
            public static string SerializeFileName()
            {
                return "XmlSerializeData.xml";
            }

            public static string FriendsListFileName()
            {
                return "Friends List.txt";
            }
        }

        public static class MessageView
        {
            public static void AutomaticallyLogin(User i_LoggedInUser)
            {
                    MessageBox.Show(i_LoggedInUser.Name + " Welcome!, You Are in automatically login");
            }

            public static void LoginSuccessfully()
            {
                MessageBox.Show("You logedin Successfully");
            }

            public static void LogoutSuccessfully()
            {
                MessageBox.Show("You Successful Logout From facebook");
            }
            
            public static void LoginFirst()
            {
                MessageBox.Show("You need to login first");
            }

            public static void AutomaticallyModeloginfirst()
            {
                MessageBox.Show("To log in automatically, You need to login first");
            }

            public static void RemamberMe()
            {
                MessageBox.Show("Better To Login First!");
            }

            public static void SelectedPost()
            {
                LoginFirst();
            }

            public static void ChosePost()
            {
                MessageBox.Show("Please Chose Post First");
            }

            public static void NoFrinds()
            {
                MessageBox.Show("No Frinds to retrieve :(");
            }

            public static void NoLiked()
            {
                MessageBox.Show("No Frinds to retrieve :(");
            }
            public static void Nobirthdaytoday()
            {
                MessageBox.Show("Your friend does not have a birthday today");
            }
        }
    }
}
