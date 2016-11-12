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

namespace LACulTor1._0.ST2
{
    class chapter_Two_5_2
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a1;
        private int a11 = 1;
        private int a12 = 0;
        private int a13 = 0;
        private int a2;
        private int a21 = 0;
        private int a22 = 1;
        private int a23 = 0;
        private int a31 = 0;
        private int a32 = 0;
        private int a33 = 1;
        private int b1;
        private int b11 = 0;
        private int b12 = 0;
        private int b2;
        private int b21 = 0;
        private int b22 = 0;
        private int b31 = 0;
        private int b32 = 0;
        private int c1;
        private int c11 = 0;
        private int c12 = 0;
        private int c2;
        private int c21 = 0;
        private int c22 = 0;
        private int c31 = 0;
        private int c32 = 0;
        private int x11;
        private int x12;
        private int x21;
        private int x22;
        private int x31;
        private int x32;
        private int num, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13;

        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_2_5_2.xml");
            if (isRegeneration)
            {
                this.a1 = this.numberTools.myRandom(3);
                this.a2 = this.numberTools.myRandom(3);
                this.b1 = this.numberTools.myRandom(3);
                this.b2 = this.numberTools.myRandom(3);
                this.c1 = this.random.Next(-3, 4);
                this.c2 = this.random.Next(-3, 4);
                this.b11 = this.random.Next(-6, 7);
                this.b21 = this.random.Next(-6, 7);
                this.b31 = this.random.Next(-6, 7);
                this.b12 = this.random.Next(-6, 7);
                this.b22 = this.random.Next(-6, 7);
                this.b32 = this.random.Next(-6, 7);
                this.x11 = this.random.Next(-6, 7);
                this.x21 = this.random.Next(-6, 7);
                this.x31 = this.random.Next(-6, 7);
                this.x12 = this.random.Next(-6, 7);
                this.x22 = this.random.Next(-6, 7);
                this.x32 = this.random.Next(-6, 7);
                this.c11 = ((this.x11 + (this.a1 * this.x21)) + (this.b1 * this.x31)) + this.b11;
                this.c12 = ((this.x12 + (this.a1 * this.x22)) + (this.b1 * this.x32)) + this.b12;
                this.c21 = (((this.a2 * this.x11) + ((1 + (this.a1 * this.a2)) * this.x21)) + (((this.a2 * this.b1) + this.c1) * this.x31)) + this.b21;
                this.c22 = (((this.a2 * this.x12) + ((1 + (this.a1 * this.a2)) * this.x22)) + (((this.a2 * this.b1) + this.c1) * this.x32)) + this.b22;
                this.c31 = (((this.b2 * this.x11) + (((this.a1 * this.b2) + this.c2) * this.x21)) + (((1 + (this.b2 * this.b1)) + (this.c2 * this.c1)) * this.x31)) + this.b31;
                this.c32 = (((this.b2 * this.x12) + (((this.a1 * this.b2) + this.c2) * this.x22)) + (((1 + (this.b2 * this.b1)) + (this.c2 * this.c1)) * this.x32)) + this.b32;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Param_Cal_2_5_2.xml");
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
                        else if (node2.Name == "b11")
                        {
                            this.b11 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b21")
                        {
                            this.b21 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b31")
                        {
                            this.b31 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b12")
                        {
                            this.b12 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b22")
                        {
                            this.b22 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b32")
                        {
                            this.b32 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "x11")
                        {
                            this.x11 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "x21")
                        {
                            this.x21 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "x31")
                        {
                            this.x31 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "x12")
                        {
                            this.x12 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "x22")
                        {
                            this.x22 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "x32")
                        {
                            this.x32 = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            this.num13 = this.b1 * this.c2;
            this.num = 1 + (this.a1 * this.a2);
            this.num2 = (this.b2 * this.a1) + this.c2;
            this.num3 = (this.a2 * this.b1) + this.c1;
            this.num4 = (1 + (this.b1 * this.b2)) + (this.c1 * this.c2);
            this.num5 = 1 + (this.c1 * this.c2);
            this.num6 = (1 + (this.b1 * this.b2)) - ((this.b1 * this.a2) * this.c2);
            this.num7 = (this.c1 * this.b2) - (this.a2 * ((this.c1 * this.c2) + 1));
            this.num8 = (this.a2 * this.c2) - this.b2;
            this.num9 = (1 + (this.a1 * this.a2)) + (((this.a1 * this.c1) - this.b1) * ((this.a2 * this.c2) - this.b2));
            this.num10 = ((this.b2 - (this.a2 * this.c2)) * this.c1) - this.a2;
            this.num11 = (this.b1 * this.c2) - (this.a1 * (1 + (this.c1 * this.c2)));
            this.num12 = (this.a1 * this.c1) - this.b1;
            this.c11 = ((this.x11 + (this.a1 * this.x21)) + (this.b1 * this.x31)) + this.b11;
            this.c12 = ((this.x12 + (this.a1 * this.x22)) + (this.b1 * this.x32)) + this.b12;
            this.c21 = (((this.a2 * this.x11) + ((1 + (this.a1 * this.a2)) * this.x21)) + (((this.a2 * this.b1) + this.c1) * this.x31)) + this.b21;
            this.c22 = (((this.a2 * this.x12) + ((1 + (this.a1 * this.a2)) * this.x22)) + (((this.a2 * this.b1) + this.c1) * this.x32)) + this.b22;
            this.c31 = (((this.b2 * this.x11) + (((this.a1 * this.b2) + this.c2) * this.x21)) + (((1 + (this.b2 * this.b1)) + (this.c2 * this.c1)) * this.x31)) + this.b31;
            this.c32 = (((this.b2 * this.x12) + (((this.a1 * this.b2) + this.c2) * this.x22)) + (((1 + (this.b2 * this.b1)) + (this.c2 * this.c1)) * this.x32)) + this.b32;

            Console.WriteLine("{0} {1} {2}", this.num9, this.num11, this.num12);
            Console.WriteLine("{0} {1} {2}", this.num10, this.num5, -1 * this.c1);
            Console.WriteLine("{0} {1} {2}", this.num8, -1 * this.c2, 1);

        }


    }
}
