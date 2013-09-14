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
        
        
        public Learner() {
            
        }

        

        public void createNewEntry() { //on create press
            Debug.WriteLine("Hi Bob");
            /*Entry newEntry = new Entry();
            entries.Add(newEntry.getName(), newEntry);*/
            
            //call Entry object methods
            //store Entry in Dictionary when finished
        }

        public void handleCreate()
        {
            createNewEntry();
        }

        public void handleRecordingTitle() //on record button press
        {
            createNewEntry();
            //entry.handleRecording();
        }

        public void handleRecording()
        {
            //entry.handleRecording();
        }

        public void handleFind() { 
            //navigate to folder system
        }

        public void handleQuit()
        {
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
