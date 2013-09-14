using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immersify
{
    public abstract class Folder
    {
        /*Abstract class defining shared fields and methods of subclasses Language, Category, and Entry.
         * 
         
         * 


        Class fields
         List of child folders
         Folder parent
         String description
         int id (possible hashCode)
         */

        private Folder parentFolder;
        private String description;
        private int id;

        public Folder(){ //constructor

        }

        /*Class methods
         add()
         remove()
         hashCode()
         compareTo()
         equals()
         move() or copy()
         */

        public String getDescription(){
            return this.description;
        }

        public void setDescription(String newDescription){
            this.description = newDescription;
        }


        public void move() { }

        public void add() { }

        






    }
}
