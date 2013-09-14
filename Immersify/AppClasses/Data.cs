using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Immersify.AppClasses;

namespace Immersify
{
    public abstract class Data
    {
        /*Data is an abstract class that defines methods and fields for extension by subclasses for audio and text data entries.

        /*Class fields
         * language
         * String description
         * some kind of container to hold actual stuff (text or audio
         */

        private DateTime timeCreated;
        private String name;
        private String description;
              
        public Data() {
            timeCreated = new DateTime();
        }

        public int getHashCode()
        {
            return this.timeCreated.GetHashCode();
        }

        public void handleRecording() { }


        /*Class methods
         * create()
         delete()
         hashCode()
         */

        public abstract void clearContents();
        //abstract method to clear data without deleting entry


      

    }
}
