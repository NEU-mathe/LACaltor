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
    class chapter_Four_5_1
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
        private int b3,m,n;


        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_4_5_1.xml");
            if (isRegeneration)
            {
                this.a12 = this.numberTools.myRandom(4);
                this.a13 = this.numberTools.myRandom(4);
                this.a14 = this.numberTools.myRandom(4);
                this.a21 = this.numberTools.myRandom(4);
                this.a23 = this.numberTools.myRandom(4);
                this.a24 = this.numberTools.myRandom(4);
                this.b1 = this.numberTools.myRandom(4);
                this.b2 = this.numberTools.myRandom(4);
                this.m = this.numberTools.myRandom(3);
                this.n = this.numberTools.myRandom(3);
                this.a22 = (this.a12 * this.a21) + 1;
                this.a31 = this.m + (this.a21 * this.n);
                this.a32 = (this.a12 * this.m) + (this.a22 * this.n);
                this.a33 = (this.a13 * this.m) + (this.a23 * this.n);
                this.a34 = (this.a14 * this.m) + (this.a24 * this.n);
                this.b3 = (this.b1 * this.m) + (this.b2 * this.n);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_4_5_1.xml");
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
                        else if (node2.Name == "m")
                        {
                            this.m = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "n")
                        {
                            this.n = int.Parse(node2.InnerText);
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
                    }
                    catch (Exception)
                    {
                       Console.WriteLine("参数有问题");
                    }
                }
            }

            int num = this.a32 - (this.a31 * this.a12);
            int num2 = this.a33 - (this.a31 * this.a13);
            int num3 = this.a34 - (this.a31 * this.a14);
            int num4 = this.b3 - (this.a31 * this.b1);
            int num5 = this.a23 - (this.a21 * this.a13);
            int num6 = this.a24 - (this.a21 * this.a14);
            int num7 = this.b2 - (this.a21 * this.b1);
            int num8 = this.a13 - (this.a12 * num5);
            int num9 = this.a14 - (this.a12 * num6);
            int num10 = this.b1 - (this.a12 * num7);
            Console.WriteLine("η=(" + num10.ToString() + "," + num7.ToString() + "," + "0" + "," + "0"+")T");
            Console.WriteLine("ξ1=(" + (-num8).ToString() + "," + (-num5).ToString() + "," +"1"+ "," + "0" + ")T");
            Console.WriteLine("ξ2=(" + (-num9).ToString() + "," + (-num6).ToString() + "," + "0" + "," + "1" + ")T");

        }


    }
}
