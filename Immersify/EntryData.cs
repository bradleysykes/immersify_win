using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immersify
{
    public abstract class EntryData
    {
        /*EntryData is an abstract class that defines methods and fields for extension by subclasses for audio and text data entries.

        /*Class fields
         * language
         * String description
         * some kind of container to hold actual stuff (text or audio
         */
              
        public EntryData() {
            
        }

        /*Class methods
         * create()
         delete()
         hashCode()
         */

       public abstract void delete();
        //abstract method to clear data without deleting entry


      

    }
}
