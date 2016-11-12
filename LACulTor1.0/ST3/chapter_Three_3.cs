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

namespace LACulTor1._0.ST3
{
    class chapter_Three_3
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a;
        private int a11;
        private int a12;
        private int a13;
        private int a21;
        private int a22;
        private int a23;
        private int a31;
        private int a32;
        private int a33;
        private int b;
        private int c;
        private int d;

        public void Generate_T(string number, bool isRegeneration)
        {
            if (isRegeneration)
            {
                this.a = this.numberTools.myRandom(3);
                this.b = this.numberTools.myRandom(3);
                this.c = this.numberTools.myRandom(3);
                this.d = this.numberTools.myRandom(3);
                this.a11 = 2 * this.a;
                this.a21 = -this.a;
                this.a31 = -5;
                this.a12 = 2 + ((2 * this.a) * this.b);
                this.a22 = -1 - (this.a * this.b);
                this.a32 = this.a - (5 * this.b);
                this.a13 = (1 + (2 * this.c)) + ((2 * this.a) * this.d);
                this.a23 = (2 - this.c) - (this.a * this.d);
                this.a33 = (this.a * this.c) - (5 * this.d);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_3_3.xml");
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        if (node2.Name == "a11")
                        {
                            this.a11 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a12")
                        {
                            this.a12 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a13")
                        {
                            this.a13 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a21")
                        {
                            this.a21 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a22")
                        {
                            this.a22 = int.Parse(node2.InnerText);
                        }
                        if (node2.Name == "a23")
                        {
                            this.a23 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a31")
                        {
                            this.a31 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a32")
                        {
                            this.a32 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a33")
                        {
                            this.a33 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a")
                        {
                            this.a = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b")
                        {
                            this.b = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c")
                        {
                            this.c = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d")
                        {
                            this.d = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }

            Console.WriteLine("beta1: {0} {1} {2}", this.a11, this.a21, this.a31);
            Console.WriteLine("beta2: 2 -1 {0}", this.a);
            Console.WriteLine("beta3: 1 2 0");

        }


    }
}
