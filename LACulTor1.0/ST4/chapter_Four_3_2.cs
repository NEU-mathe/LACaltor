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
    class chapter_Four_3_2
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a11;
        private int a12;
        private int a13;
        private int a14;
        private int a15;
        private int a21;
        private int a22;
        private int a23;
        private int a24;
        private int a25;
        private int a31;
        private int a32;
        private int a33;
        private int a34;
        private int a35;
        private int a41;
        private int a42;
        private int a43;
        private int a44;
        private int a45;
        private int m, n;
        private string stringnumber;

        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_4_3_2.xml");
            if (isRegeneration)
            {
                this.a12 = this.numberTools.myRandom(4);
                this.a13 = this.numberTools.myRandom(4);
                this.a14 = this.numberTools.myRandom(4);
                this.a15 = this.numberTools.myRandom(4);
                this.a21 = this.numberTools.myRandom(4);
                this.a23 = this.numberTools.myRandom(4);
                this.a24 = this.numberTools.myRandom(4);
                this.a25 = this.numberTools.myRandom(4);
                this.a31 = this.numberTools.myRandom(4);
                this.a32 = this.numberTools.myRandom(4);
                this.a34 = this.numberTools.myRandom(4);
                this.a35 = this.numberTools.myRandom(4);
                this.m = this.numberTools.myRandom(3);
                this.n = this.numberTools.myRandom(3);
                this.a11 = 1;
                this.a22 = (this.a12 * this.a21) + 1;
                this.a33 = ((this.a13 * this.a31) + ((this.a32 - (this.a31 * this.a12)) * (this.a23 - (this.a21 * this.a13)))) + 1;
                this.a41 = (this.a11 * this.m) + (this.a21 * this.n);
                this.a42 = (this.a12 * this.m) + (this.a22 * this.n);
                this.a43 = (this.a13 * this.m) + (this.a23 * this.n);
                this.a44 = (this.a14 * this.m) + (this.a24 * this.n);
                this.a45 = (this.a15 * this.m) + (this.a25 * this.n);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_4_3_2.xml");
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
                        else if (node2.Name == "a15")
                        {
                            this.a15 = int.Parse(node2.InnerText);
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
                        else if (node2.Name == "a25")
                        {
                            this.a25 = int.Parse(node2.InnerText);
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
                        else if (node2.Name == "a35")
                        {
                            this.a35 = int.Parse(node2.InnerText);
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
                        else if (node2.Name == "a45")
                        {
                            this.a45 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "n")
                        {
                            this.m = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "m")
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

            int num = this.a23 - (this.a21 * this.a13);
            int num2 = this.a24 - (this.a21 * this.a14);
            int num3 = this.a25 - (this.a21 * this.a15);
            int num4 = this.a32 - (this.a31 * this.a12);
            int num5 = this.a33 - (this.a31 * this.a13);
            int num6 = this.a34 - (this.a31 * this.a14);
            int num7 = this.a35 - (this.a31 * this.a15);
            int num8 = this.a42 - (this.a41 * this.a12);
            int num9 = this.a43 - (this.a41 * this.a13);
            int num10 = this.a44 - (this.a41 * this.a14);
            int num11 = this.a45 - (this.a41 * this.a15);
            int num12 = this.a13 - (this.a12 * num);
            int num13 = this.a14 - (this.a12 * num2);
            int num14 = this.a15 - (this.a12 * num3);
            int num15 = num6 - (num4 * num2);
            int num16 = num7 - (num4 * num3);
            int num17 = num13 - (num12 * num15);
            int num18 = num14 - (num12 * num16);
            int num19 = num2 - (num * num15);
            int num20 = num3 - (num * num16);

            Console.WriteLine("ξ1: {0} {1} {2} 1 0", -num17, -num19, -num15);
            Console.WriteLine("ξ2: {0} {1} {2} 0 1", -num18, -num20, -num16);

        }


    }
}
