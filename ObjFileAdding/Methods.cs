using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ObjFileAdding
{
    class Methods
    {
        public static List<string> GetFilesNames(string Destination)
        {
            string[] files = Directory.GetFiles(Destination, "*.obj", SearchOption.AllDirectories);
            List<string> NameOfFiles = new List<string>(files.Length);
            foreach (string file in files)
                NameOfFiles.Add(Path.GetFileName(file));
            return NameOfFiles;
        }


        public static string createTextInside(List<string> files)
        {
            StringBuilder builder = new StringBuilder("SDL2.lib;SDL2main.lib;SDL2test.lib;");
            foreach (string file in files)
                builder.Append(file).Append(";");
            return builder.ToString();
        }


        public static void ChangeXML(string TextToAdd, string Source)
        {
            XmlDocument document = new XmlDocument();
            document.LoadXml(File.ReadAllText(Source));
            XmlNodeList Link = document.GetElementsByTagName("AdditionalDependencies");
            foreach (XmlNode node in Link)
            {
                node.InnerText = TextToAdd;
            }
            document.Save(Source);
        }
    }
}
