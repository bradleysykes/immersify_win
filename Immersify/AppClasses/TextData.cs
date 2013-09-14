using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immersify.AppClasses
{
    class TextData : Data
    {

        private String nativeText;
        private String foreignText;
        private static readonly String initialText = "Enter text";

        public TextData() : base()
        {
            this.nativeText = initialText;
            this.foreignText = initialText;
        }

        public void inputNativeText()
        {
            this.nativeText = getStringInput();
        }
        
        public override void clearContents() {
            return;
        }


        public void inputForeignText(String text)
        {
            this.foreignText = getStringInput();
        }

        public String getStringInput()
        {
            String text = "";
            //solicit text input from user, store in variable and return
            return text;
        }

 




    }
}
