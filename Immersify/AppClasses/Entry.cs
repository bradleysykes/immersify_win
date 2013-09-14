using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Immersify.AppClasses;

namespace Immersify
{
    public class Entry : Folder
    {
        /*Entry class responsible for representing a single entry of language learning.
         User can create these entries upon immersive interaction with speakers of another language. 
         Entries stored in parent Category folder.
         
         Class fields
         * 
         * Folder Category (parent)
         * Time (time entire entry created: distinct from time of entryData creation)
         * 
         */

        private DateTime timeCreated;
        private String language = "None";
        private String name = "None";
        private int id;
        private AudioData audio;
        private TextData text;
        

        public Entry() 
        {
            this.timeCreated = new DateTime();
            this.audio = new AudioData();
            this.text = new TextData();
        }

        public Entry(String language) : this() 
        {
            this.language = language;
        }

        public Entry(String name, String language) : this() 
        {
            this.name = name;
            this.language = language;
        }

        public AudioData getAudio()
        {
            return this.audio;
        }

        public TextData getText()
        {
            return this.text;
        }

        

        private int getHashCode () 
        {
            return timeCreated.GetHashCode();
        }

        public int getId()
        {
            return this.id;
        }

        public String getName()
        {
            return this.name;
        }

        //TO-DO - conditions to make sure name is OK
        public void setName(String newName)
        {
            this.name = newName;
        }




    }
}
