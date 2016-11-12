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
    class chapter_Three_8
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

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
        private int a41;
        private int a42;
        private int a43;
        private int a44;
        private int h, k, m, n, s, t;
        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_3_8.xml");
            if (isRegeneration)
            {
                this.a11 = this.numberTools.myRandom(6);
                this.a21 = this.numberTools.myRandom(6);
                this.a31 = this.numberTools.myRandom(6);
                this.a41 = this.numberTools.myRandom(6);
                this.a32 = this.numberTools.myRandom(6);
                this.a42 = this.numberTools.myRandom(6);
                this.a12 = 2 * this.a11;
                this.a22 = (2 * this.a21) + 1;
                do
                {
                    this.m = this.numberTools.myRandom(3);
                    this.n = this.numberTools.myRandom(3);
                    this.k = this.numberTools.myRandom(3);
                    this.h = this.numberTools.myRandom(3);
                }
                while ((this.m * this.k) == (this.n * this.h));
                this.s = this.random.Next(0, 2);
                this.t = this.random.Next(0, 2);
                this.a13 = (this.a11 * this.m) + (this.a12 * this.n);
                this.a23 = (this.a21 * this.m) + (this.a22 * this.n);
                this.a33 = ((this.a31 * this.m) + (this.a32 * this.n)) + this.t;
                this.a43 = ((this.a41 * this.m) + (this.a42 * this.n)) + (2 * this.t);
                this.a14 = (this.a11 * this.h) + (this.a12 * this.k);
                this.a24 = (this.a21 * this.h) + (this.a22 * this.k);
                this.a34 = ((this.a31 * this.h) + (this.a32 * this.k)) + (2 * this.t);
                this.a44 = (((this.a41 * this.h) + (this.a42 * this.k)) + (4 * this.t)) + this.s;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_3_8.xml");
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
                        else if (node2.Name == "a23")
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
                        else if (node2.Name == "a41")
                        {
                            this.a41 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a42")
                        {
                            this.a42 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a43")
                        {
                            this.a43 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a44")
                        {
                            this.a44 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "m")
                        {
                            this.m = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "n")
                        {
                            this.n = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "h")
                        {
                            this.h = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "k")
                        {
                            this.k = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "s")
                        {
                            this.s = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "t")
                        {
                            this.t = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            if ((this.s == 0) && (this.t == 0))
            {
                Console.WriteLine("2");
            }
            else if (this.s != this.t)
            {
                Console.WriteLine("3");
            }
            else if ((this.s == 1) && (this.t == 1))
            {
                Console.WriteLine("3");
            }

        }


    }
}
