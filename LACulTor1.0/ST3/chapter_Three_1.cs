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
    class chapter_Three_1
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a;
        private int a11;
        private int a12;
        private int a13;
        private int a14;
        private int a21;
        private int a22;
        private int a23;
        private int a24;
        private int a31;
        private int a32;
        private int a33;
        private int a34;
        private int b;
        private int c;
        private int ans1, ans2, ans3, ans4;

        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_3_1.xml");
            if (isRegeneration)
            {
                this.a = this.numberTools.myRandom(5);
                this.b = this.numberTools.myRandom(5);
                this.c = this.numberTools.myRandom(5);
                this.a11 = this.numberTools.myRandom(5);
                this.a12 = this.numberTools.myRandom(5);
                this.a13 = this.numberTools.myRandom(5);
                this.a14 = this.numberTools.myRandom(5);
                this.a21 = this.numberTools.myRandom(5);
                this.a22 = this.numberTools.myRandom(5);
                this.a23 = this.numberTools.myRandom(5);
                this.a24 = this.numberTools.myRandom(5);
                this.a31 = this.numberTools.myRandom(5);
                this.a32 = this.numberTools.myRandom(5);
                this.a33 = this.numberTools.myRandom(5);
                this.a34 = this.numberTools.myRandom(5);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_3_1.xml");
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
                        else if (node2.Name == "a14")
                        {
                            this.a14 = int.Parse(node2.InnerText);
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
                        else if (node2.Name == "a24")
                        {
                            this.a24 = int.Parse(node2.InnerText);
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
                        else if (node2.Name == "a34")
                        {
                            this.a34 = int.Parse(node2.InnerText);
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
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }

            ans1 = ((this.a * this.a11) + (this.b * this.a21)) + (this.c * this.a31);
            ans2 = ((this.a * this.a12) + (this.b * this.a22)) + (this.c * this.a32);
            ans3 = ((this.a * this.a13) + (this.b * this.a23)) + (this.c * this.a33);
            ans4 = ((this.a * this.a14) + (this.b * this.a24)) + (this.c * this.a34);

            Console.WriteLine("{0}", ans1);
            Console.WriteLine("{0}", ans2);
            Console.WriteLine("{0}", ans3);
            Console.WriteLine("{0}", ans4);

        }


    }
}
