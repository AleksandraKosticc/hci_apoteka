using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using hci_apoteka.Forms;

namespace hci_apoteka
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public enum Languages
        {
            Serbian,
            English           
        }

        private static Languages language;

        private static ResXResourceSet languageResxSet; //ResX file containing language file

        public static ResXResourceSet LanguageResxSet { get => languageResxSet; set => languageResxSet = value; }
        public static Languages Language { get => language; set => language = value; }
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FormStart());
        }

 
        public static void SwitchLanguage(Program.Languages language)
        {
            string languageCode = null;

            Language = language;

            if (language == Languages.Serbian)
            {
                languageCode = "sr-la";
            }
            else if(language == Languages.English)
            {
                languageCode = "en";
            }
           
            try
            {
                LanguageResxSet = new ResXResourceSet(@"Languages/" + languageCode + @".resx");
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}