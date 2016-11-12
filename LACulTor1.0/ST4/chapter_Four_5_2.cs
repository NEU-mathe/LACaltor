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
    class chapter_Four_5_2
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

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
        private int b1;
        private int b2;
        private int b3;
        private int c1;
        private int c2;
        private int c3;


        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_4_5_2.xml");
            if (isRegeneration)
            {
                this.a12 = this.numberTools.myRandom(3);
                this.a13 = this.numberTools.myRandom(3);
                this.a14 = this.numberTools.myRandom(3);
                this.a21 = this.numberTools.myRandom(3);
                this.a24 = this.numberTools.myRandom(3);
                this.a31 = this.numberTools.myRandom(3);
                this.a34 = this.numberTools.myRandom(3);
                this.b1 = this.numberTools.myRandom(2);
                this.b2 = this.numberTools.myRandom(2);
                this.b3 = this.numberTools.myRandom(2);
                this.c1 = this.numberTools.myRandom(2);
                this.c2 = this.numberTools.myRandom(2);
                this.c3 = this.numberTools.myRandom(2);
                this.a22 = (this.a12 * this.a21) + 1;
                this.a32 = (this.a31 * this.a12) + this.c1;
                this.a23 = (this.a21 * this.a13) + this.c2;
                this.a33 = ((this.a31 * this.a13) + (this.c1 * this.c2)) + 1;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_4_5_2.xml");
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        if (node2.Name == "a12")
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
                        else if (node2.Name == "c1")
                        {
                            this.c1 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c2")
                        {
                            this.c2 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c3")
                        {
                            this.c3 = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }

            int num = (this.a34 - (this.c1 * this.a24)) + (((this.c1 * this.a21) - this.a31) * this.a14);
            int num2 = (this.b3 - (this.c1 * this.b2)) + (((this.c1 * this.a21) - this.a31) * this.b1);
            int num3 = (this.a24 - (this.a21 * this.a14)) - (this.c2 * num);
            int num4 = (this.b2 - (this.a21 * this.b1)) - (this.c2 * num2);
            Console.WriteLine("η=(" + ((this.b1 - (this.a13 * num2)) - (this.a12 * num4)).ToString()+"," + num4.ToString() + "," + num2.ToString() + "," + "0"+")T");
            Console.WriteLine("ξ1=(" + ((this.a14 - (this.a13 * num)) - (this.a12 * num3)).ToString() + "," + num3.ToString() + "," + num.ToString() + "," + "-1" + ")T");
        }


    }
}
