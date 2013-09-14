using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Immersify.AppClasses
{
    public class Learner
    {
        /*Class represents the user in all interaction with other classes. 
         Responsible for sending requests to Folder and Entry classes. */
        private String name;
        private int id;
        private Dictionary<String, Entry> entries;
        private bool recordingState = false;
        private Entry entry;
        
        
        public Learner() {
            
        }

        

        public Entry createNewEntry() { //on create press
            return new Entry();
            //entries.Add(newEntry.getName(), newEntry);
            //call Entry object methods
            //store Entry in Dictionary when finished
        }

        public void handleCreate()
        {
            entry = createNewEntry();
        }

        public void handleRecordingTitle() //on record button press
        {
            entry = createNewEntry();
            Data audio = entry.getAudio();
            audio.handleRecording();
        }

        public void textGrab()
        {
            entry.getText();
        }

        public void handlePlayRecording()
        {
            entry.getAudio().playRecording();
        }

        public void handleRecording()
        {
            //entry.handleRecording();
        }

        public void handleFind() { 
            //navigate to folder system
        }




       
        public Entry getEntry(String key)
        {
            Entry notFound = null;
            if (entries.TryGetValue(key, out notFound))
                return entries[key];
            else
                return notFound;
        }



       
    
    }
}
