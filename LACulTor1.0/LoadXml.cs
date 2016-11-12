using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
//using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace LACulTor1._0
{

    class LoadXml
    {
        static public XmlNode LoadShowParameterXml(string xmlName)
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

    }
}
