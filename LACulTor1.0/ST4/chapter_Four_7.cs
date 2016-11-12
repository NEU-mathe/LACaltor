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

namespace LACulTor1._0.ST4
{
    class chapter_Four_7
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a1;
        private int a2;
        private int a3;
        private int b1;
        private int b2;
        private int b3;
        private int b4;


        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_4_7.xml");
            if (isRegeneration)
            {
                this.a1 = this.numberTools.myRandom(9);
                this.a2 = this.numberTools.myRandom(9);
                this.a3 = this.numberTools.myRandom(9);
                this.b1 = this.numberTools.myRandom(9);
                this.b2 = this.numberTools.myRandom(9);
                this.b3 = this.numberTools.myRandom(9);
                this.b4 = this.numberTools.myRandom(9);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_4_7.xml");
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        if (node2.Name == "a1")
                        {
                            this.a1 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a2")
                        {
                            this.a2 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a3")
                        {
                            this.a3 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b1")
                        {
                            this.b1 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b2")
                        {
                            this.b2 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b3")
                        {
                            this.b3 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b4")
                        {
                            this.b4 = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }

            Console.WriteLine("x=(" + this.b1.ToString() + ","+ this.b2.ToString() + "," + this.b3.ToString() + "," + this.b4.ToString() + ")T+k("+ this.a1.ToString() + "," + this.a2.ToString() + "," + this.a3.ToString()+"-1)T");

        }


    }
}
