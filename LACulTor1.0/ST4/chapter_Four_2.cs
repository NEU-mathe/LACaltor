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
    class chapter_Four_2
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a11;
        private int a12;
        private int a13;
        private int a21;
        private int a22;
        private int a23;
        private int a31;
        private int a32;
        private int a33;
        private int b1;
        private int b2;
        private int b3;
        private int c11;
        private int c21;
        private int c22;
        private int c31;
        private int c32;
        private int c33;
        private int d11;
        private int d12;
        private int d13;
        private int d22;
        private int d23;
        private int d33;
        private int l, m, n;
        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_4_2.xml");
            if (isRegeneration)
            {
                this.c11 = this.numberTools.myRandom(4);
                this.c22 = this.numberTools.myRandom(4);
                this.c33 = this.numberTools.myRandom(4);
                this.d11 = this.numberTools.myRandom(4);
                this.d22 = this.numberTools.myRandom(4);
                this.d33 = this.numberTools.myRandom(4);
                this.c21 = this.numberTools.myRandom(5);
                this.c31 = this.numberTools.myRandom(5);
                this.c32 = this.numberTools.myRandom(5);
                this.d12 = this.numberTools.myRandom(5);
                this.d13 = this.numberTools.myRandom(5);
                this.d23 = this.numberTools.myRandom(5);
                this.l = this.numberTools.myRandom(9);
                this.m = this.numberTools.myRandom(9);
                this.n = this.numberTools.myRandom(9);
                this.a11 = this.c11 * this.d11;
                this.a12 = this.c11 * this.d12;
                this.a13 = this.c11 * this.d13;
                this.a21 = this.c21 * this.d11;
                this.a31 = this.c31 * this.d11;
                this.a22 = (this.c21 * this.d12) + (this.c22 * this.d22);
                this.a23 = (this.c21 * this.d13) + (this.c22 * this.d23);
                this.a32 = (this.c31 * this.d12) + (this.c32 * this.d22);
                this.a33 = ((this.c31 * this.d13) + (this.c32 * this.d23)) + (this.c33 * this.d33);
                this.b1 = ((this.l * this.a11) + (this.m * this.a21)) + (this.n * this.a31);
                this.b2 = ((this.l * this.a12) + (this.m * this.a22)) + (this.n * this.a32);
                this.b3 = ((this.l * this.a13) + (this.m * this.a23)) + (this.n * this.a33);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_4_2.xml");
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
                        else if (node2.Name == "a23")
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
                        else if (node2.Name == "c11")
                        {
                            this.c11 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c21")
                        {
                            this.c21 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c22")
                        {
                            this.c22 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c31")
                        {
                            this.c31 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c32")
                        {
                            this.c32 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c33")
                        {
                            this.c33 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d11")
                        {
                            this.d11 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d12")
                        {
                            this.d12 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d13")
                        {
                            this.d13 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d22")
                        {
                            this.d22 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d33")
                        {
                            this.d33 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "l")
                        {
                            this.l = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "m")
                        {
                            this.m = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "n")
                        {
                            this.n = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }

            Console.WriteLine("{0} {1} {2}", l, m, n);
        }


    }
}
