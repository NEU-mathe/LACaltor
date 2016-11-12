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
    class chapter_Four_8
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a1;
        private int a11;
        private int a12;
        private int a13;
        private int a14;
        private int a2;
        private int a21;
        private int a22;
        private int a23;
        private int a24;
        private int a31;
        private int a32;
        private int a33;
        private int a34;
        private int b1;
        private int b2;
        private int c1;
        private int c2;


        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_4_8.xml");
            if (isRegeneration)
            {
                this.a1 = this.numberTools.myRandom(3);
                this.a2 = this.numberTools.myRandom(3);
                this.b1 = this.numberTools.myRandom(3);
                this.b2 = this.numberTools.myRandom(3);
                this.c1 = this.numberTools.myRandom(3);
                this.c2 = this.numberTools.myRandom(3);
                this.a12 = this.numberTools.myRandom(4);
                this.a22 = this.numberTools.myRandom(4);
                this.a32 = ((2 * this.a22) - this.a12) + 1;
                this.a11 = 1;
                this.a13 = (this.a1 + this.b1) + (this.c1 * this.a12);
                this.a14 = (this.a2 + this.b2) + (this.c2 * this.a12);
                this.a21 = 2;
                this.a23 = (this.a1 + (2 * this.b1)) + (this.c1 * this.a22);
                this.a24 = (this.a2 + (2 * this.b2)) + (this.c2 * this.a22);
                this.a31 = 3;
                this.a33 = (this.a1 + (3 * this.b1)) + (this.c1 * this.a32);
                this.a34 = (this.a2 + (3 * this.b2)) + (this.c2 * this.a32);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_4_8.xml");
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
                        else if (node2.Name == "a1")
                        {
                            this.a1 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a2")
                        {
                            this.a2 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b1")
                        {
                            this.b1 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b2")
                        {
                            this.b2 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c1")
                        {
                            this.c1 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c2")
                        {
                            this.c2 = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            Console.WriteLine("x=(" + this.a11.ToString() + "," + this.a12.ToString() + "," + this.a13.ToString() + "," + this.a14.ToString()+")T+k1(" + (this.a21 - this.a11).ToString() + ","+ (this.a22 - this.a12).ToString() + ","+ (this.a23 - this.a13).ToString()+","+ (this.a24 - this.a14).ToString()+")T+k2("+ (this.a31 - this.a11).ToString()+","+ (this.a32 - this.a12).ToString()+","+ (this.a33 - this.a13).ToString()+","+ (this.a34 - this.a14).ToString()+")T");

        }


    }
}
