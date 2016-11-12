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
    class chapter_Four_3_3
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
        private int b3;
        private int b4;
        private string stringnumber;

        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_4_3_3.xml");
            if (isRegeneration)
            {
                this.a12 = this.numberTools.myRandom(3);
                this.a13 = this.numberTools.myRandom(3);
                this.a14 = this.numberTools.myRandom(3);
                this.a21 = this.numberTools.myRandom(3);
                this.a31 = this.numberTools.myRandom(3);
                this.a41 = this.numberTools.myRandom(3);
                this.b3 = this.numberTools.myRandom(2);
                this.b4 = this.numberTools.myRandom(2);
                this.a15 = this.numberTools.myRandom(5);
                this.a25 = this.numberTools.myRandom(5);
                this.a35 = this.numberTools.myRandom(5);
                this.a45 = this.numberTools.myRandom(5);
                this.a11 = 1;
                this.a22 = (this.a21 * this.a12) + 1;
                this.a32 = (this.a31 * this.a12) + 1;
                this.a42 = (this.a41 * this.a12) + 1;
                this.a23 = (this.a21 * this.a13) + this.b3;
                this.a24 = (this.a21 * this.a14) + this.b4;
                this.a33 = ((this.a31 * this.a13) + this.b3) + 1;
                this.a43 = ((this.a41 * this.a13) + this.b3) + 1;
                this.a34 = ((this.a31 * this.a14) + this.b4) + 1;
                this.a44 = ((this.a41 * this.a14) + this.b4) + 2;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_4_3_3.xml");
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
            int num = (this.a45 - this.a35) + ((this.a31 - this.a41) * this.a15);
            int num2 = ((this.a35 - this.a25) + ((this.a21 - this.a31) * this.a15)) - num;
            int num3 = (this.a25 - (this.a21 * this.a15)) - (this.b4 * num);
            int num4 = this.a15 - (this.a14 * num);

            Console.WriteLine("ξ1: {0} {1} {2} {3} -1"
                , (num4 - (this.a12 * num3)) + (((this.a12 * this.b3) - this.a13) * num2)
                , num3 - (this.b3 * num2)
                , num2
                , num);

        }


    }
}
