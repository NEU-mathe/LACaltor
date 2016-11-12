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
using test_one;

namespace LACulTor1._0.ST5
{
    class chapter_Five_4
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a = 0;
        private List<int> a1 = new List<int>();
        private int b = 0;
        private List<int> b1 = new List<int>();
        private int fMb = 0;
        private int Ta = 0;

        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_5_4.xml");
            if (!isRegeneration)
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_5_4.xml");
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        if (node2.Name == "a")
                        {
                            this.a = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b")
                        {
                            this.b = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            this.fMb = -this.b;
            this.Ta = this.a;
            string ans = "";
            ans += "λ1=";
            ans += "0".ToString();
            ans += " ";
            ans += "λ2=";
            ans += "0".ToString();
            ans += " ";
            ans += "λ3=";
            ans += a.ToString();
            ans += " ";
            ans += "λ4=";
            ans += b.ToString();
            ans += "\r\n";
            Console.Write(ans);
        }


    }
}
