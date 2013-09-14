using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Immersify.AppClasses
{
    public class AudioData : Data
    {
        
        Microphone microphone = Microphone.Default;
        byte[] buffer;
        MemoryStream stream = new MemoryStream();
        SoundEffect sound;
        private bool recordingState = false;

        public AudioData() : base()
        {
            
        }

        public override void clearContents() {
            return;
        }

        public void micStuff()
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromMilliseconds(33);
            dt.Tick += delegate { try { FrameworkDispatcher.Update(); } catch { } };
            dt.Start();
            microphone.BufferReady += new EventHandler<EventArgs>(microphone_BufferReady);
        }

    void microphone_BufferReady(object sender, EventArgs e)
        {
            microphone.GetData(buffer);
            stream.Write(buffer, 0, buffer.Length);
        }

        private void startRecording()
        {
            microphone.BufferDuration = TimeSpan.FromMilliseconds(1000);
            buffer = new byte[microphone.GetSampleSizeInBytes(microphone.BufferDuration)];
            microphone.Start();
        }

        private void stopRecording()
        {
            if (microphone.State == MicrophoneState.Started)
            {
                microphone.Stop();
            }
        }

        public void playRecording()
        {
            sound = new SoundEffect(stream.ToArray(), microphone.SampleRate, AudioChannels.Mono);
            sound.Play();
        }


        public void handleRecording()
        {
            this.recordingState = !this.recordingState;
            if (recordingState)
                startRecording();
            else
                stopRecording(); 
            return;
        }


    }
}
