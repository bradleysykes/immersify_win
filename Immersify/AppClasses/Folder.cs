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
        private Map<Folder> childFolders;
        private Folder parentFolder;
        private String description;
        private String name;
        private int id;

        public Folder(){ //constructor
            id++;
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

        public int hashCode() {
            //implement function that will 1) generate unique int for each folder and 2) generate same int for same folder
            //used for Map
            return 0;
        }

        public void setDescription(String newDescription){
            this.description = newDescription;
        }


        public void move() { } //implement

        public void copy() { } //implement

        public Folder getSubFolder(String subFolderName) {
            return new Folder();
        }

        public void addNewSubFolder() {
        }

        






    }
}
