using System;
using System.IO;
using System.Windows.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Diagnostics;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Immersify.Resources;
using Immersify.AppClasses;

namespace Immersify
{
    public partial class MainPage : PhoneApplicationPage
    {

        Microphone microphone = Microphone.Default;
        byte[] buffer;
        MemoryStream stream = new MemoryStream();
        SoundEffect sound;


        public Learner learner = new Learner();
        
        


  
		
		    public MainPage()
        {
            InitializeComponent();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();

            // Timer to simulate the XNA Game Studio game loop (Microphone is from XNA Game Studio)
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromMilliseconds(33);
            dt.Tick += delegate { try { FrameworkDispatcher.Update(); } catch { } };
            dt.Start();
            microphone.BufferReady += new EventHandler<EventArgs>(microphone_BufferReady);
        }
		
		 public void createNewEntry_Click(object sender, RoutedEventArgs e)
        {
            learner.createNewEntry();
            NavigationService.Navigate(new Uri("/EntryView.xaml", UriKind.Relative));

        }

        void microphone_BufferReady(object sender, EventArgs e)
        {
            microphone.GetData(buffer);
            stream.Write(buffer, 0, buffer.Length);
        }

        private void recordButton_Click(object sender, RoutedEventArgs e)
        {
            microphone.BufferDuration = TimeSpan.FromMilliseconds(1000);
            buffer = new byte[microphone.GetSampleSizeInBytes(microphone.BufferDuration)];
            microphone.Start();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            if (microphone.State == MicrophoneState.Started)
            {
                microphone.Stop();
            }
        }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            sound = new SoundEffect(stream.ToArray(), microphone.SampleRate, AudioChannels.Mono);
            sound.Play();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            

        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}