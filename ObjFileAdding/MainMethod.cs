using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace ObjFileAdding
{
    class MainMethod
    {
        static string Source = Properties.Resources.SourceFolder + "\\PacmanUnitTests.vcxproj";
        #if DEBUG
                static string Destination = Properties.Resources.DestinationFolderDebug;
        #else 
                static string Destination = Properties.Resources.DestinationFolderRelease; 
        #endif



        public static void Main()
        {
            List<string> files=Methods.GetFilesNames(Destination);

            string TextToAdd=Methods.createTextInside(files);

            Methods.ChangeXML(TextToAdd,Source);

            return;
        }
    }
}
