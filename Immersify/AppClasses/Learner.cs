using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immersify.AppClasses
{
    class Learner
    {
        /*Class represents the user in all interaction with other classes. 
         Responsible for sending requests to Folder and Entry classes. */
        private String name;
        private int id;
        private Dictionary<String, Entry> entries;
        
        
        public Learner(String name) {
            this.name = name;
        }

        public void createNewEntry() {
            Entry newEntry = new Entry();
            entries.Add(newEntry.getName(), newEntry);
            
            //call Entry object methods
            //store Entry in Dictionary when finished
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
