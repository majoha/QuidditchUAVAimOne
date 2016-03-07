using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tutorial_31___AR_Drone
{

    class checkForUpdates
    {
        private System.Xml.XmlTextReader reader;

        public checkForUpdates()
        {

            Version newVersion = null;
            Version curVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            string url = "";
            string elementName = "";

            try
            {

                string xmlurl = "http://oufc1234.weebly.com/uploads/7/5/1/5/75157909/updatetest.xml";
                //string xmlurl = "http://localhost:8080/updateTest.xml";

                reader = new System.Xml.XmlTextReader(xmlurl);

                reader.MoveToContent();


                if ((reader.NodeType == System.Xml.XmlNodeType.Element) && (reader.Name == "myApp"))
                {

                    while (reader.Read())
                    {

                        if (reader.NodeType == System.Xml.XmlNodeType.Element)
                        {
                            elementName = reader.Name;
                        } else
                        {

                            if (reader.NodeType == System.Xml.XmlNodeType.Text && reader.HasValue)
                            {

                                switch (elementName)
                                {

                                    case "version":
                                        newVersion = new Version(reader.Value);
                                        break;
                                    case "url":
                                        url = reader.Value;
                                        break;

                                }
                            }
                        }
                    }
                }
            } catch (Exception)
            {
                Console.WriteLine("FAILED");

            } finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            if (curVersion.CompareTo(newVersion) < 0)
            {

                string title = "New version available!";
                string question = "Would you like to download?";

                if (DialogResult.Yes == MessageBox.Show(question, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process.Start(url);
                }
            }

        }
    }
}
