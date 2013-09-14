using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immersify.AppClasses
{
    class AudioData : Data
    {
        //field to store audio file

        private bool recordingState = false;

        public AudioData() : base()
        {
            
        }

        public override void clearContents() {
            return;
        }

        public void handleRecording()
        {
            this.recordingState = !this.recordingState;
            if (recordingState) { }
            //call startRecording in Audio
            else { }
            return;

            //call stopRecording

        }


    }
}
