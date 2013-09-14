using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework;
using Immersify.AppClasses;

namespace Immersify
{
    public partial class EntryView : PhoneApplicationPage
    {

        private Learner learner = new Learner();
        public EntryView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            learner.handlePlayRecording();
        }

        private void textBox_Click(object sender, RoutedEventArgs e)
        {
            String str = YLANG.Text;
        }
    }
}