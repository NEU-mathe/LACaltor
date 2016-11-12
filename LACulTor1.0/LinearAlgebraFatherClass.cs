namespace SuperClass
{
    //using MathMLControl;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Text;
    //using System.Windows.Forms;
    using System.Xml;

    public abstract class LinearAlgebraFatherClass
    {
        public XmlNode LoadShowParameterXml(string xmlName)
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load("ParameterXml/" + xmlName);
                foreach (XmlNode node in document.ChildNodes)
                {
                    if (node.Name.Equals("Parameter"))
                    {
                        return node;
                    }
                }
            }
            catch (Exception)
            {
            }
            return null;
        }

        public void SaveParameterXml(string fileName, Dictionary<string, string> parameter)
        {
            try
            {
                FileStream w = new FileStream("ParameterXml/" + fileName, FileMode.Create);
                XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8)
                {
                    Formatting = Formatting.Indented
                };
                writer.WriteStartDocument();
                writer.WriteStartElement("Parameter");
                foreach (KeyValuePair<string, string> pair in parameter)
                {
                    writer.WriteElementString(pair.Key, pair.Value);
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
            catch (Exception)
            {
            }
        }

        public abstract void SaveParameterXml_Children();
        public void saveStudentAnwser(string fileName, Dictionary<string, string> Simpleanwser, Dictionary<string, string> MathControlAnwser)
        {
            try
            {
                FileStream w = new FileStream("StudentAnwser/" + fileName, FileMode.Create);
                XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8)
                {
                    Formatting = Formatting.Indented
                };
                writer.WriteStartDocument();
                writer.WriteStartElement("Anwser");
                if (Simpleanwser != null)
                {
                    foreach (KeyValuePair<string, string> pair in Simpleanwser)
                    {
                        writer.WriteElementString(pair.Key, pair.Value);
                    }
                }
                if (MathControlAnwser != null)
                {
                    foreach (KeyValuePair<string, string> pair in MathControlAnwser)
                    {
                        writer.WriteStartElement(pair.Key);
                        writer.WriteCData(pair.Value);
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
            catch (Exception)
            {
            }
        }

        public abstract void SaveStudentAnwser_Children();
        public string ShowCorrectAnwser(string AnswerPic)
        {
            try
            {
                return AnswerPic;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string ShowCorrectAnwser(string showAnwserXml, Dictionary<string, string> replaceString)
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load("ShowAnwserXml/" + showAnwserXml);
                XmlDocument document2 = new XmlDocument();
                string innerText = null;
                foreach (XmlNode node in document.FirstChild.ChildNodes)
                {
                    innerText = node.InnerText;
                }
                XmlNodeList elementsByTagName = document2.GetElementsByTagName("Parameter");
                foreach (XmlNode node in document.FirstChild)
                {
                    foreach (KeyValuePair<string, string> pair in replaceString)
                    {
                        string oldValue = "#" + pair.Key + "#";
                        innerText = innerText.Replace(oldValue, pair.Value);
                    }
                }
                return innerText;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

