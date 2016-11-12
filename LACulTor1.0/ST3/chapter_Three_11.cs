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
    class chapter_Three_11
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
        private int k1;
        private int k2;
        private int k3;
        private int k4;
        private int m, t;
        private string stringnumber;


        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_3_11.xml");
            if (isRegeneration)
            {
                this.a12 = this.numberTools.myRandom(6);
                this.a21 = this.numberTools.myRandom(6);
                this.a31 = this.numberTools.myRandom(6);
                this.a32 = this.numberTools.myRandom(6);
                this.a41 = this.numberTools.myRandom(6);
                this.a42 = this.numberTools.myRandom(6);
                do
                {
                    this.k1 = this.numberTools.myRandom(3);
                    this.k2 = this.numberTools.myRandom(3);
                    this.k3 = this.numberTools.myRandom(3);
                    this.k4 = this.numberTools.myRandom(3);
                }
                while ((this.k1 * this.k4) == (this.k2 * this.k3));
                this.m = this.numberTools.myRandom(3);
                this.a11 = 1;
                this.a13 = this.k1 + (this.k3 * this.a12);
                this.a14 = this.k2 + (this.k4 * this.a12);
                this.t = this.random.Next(0, 2);
                this.a22 = 1 + (this.a21 * this.a12);
                this.a23 = (this.k1 * this.a21) + (this.k3 * this.a22);
                this.a24 = (this.k2 * this.a21) + (this.k4 * this.a22);
                this.a33 = ((this.k1 * this.a31) + (this.k3 * this.a32)) + this.t;
                this.a34 = ((this.k2 * this.a31) + (this.k4 * this.a32)) + (this.m * this.t);
                this.a43 = (this.k1 * this.a41) + (this.k3 * this.a42);
                this.a44 = (this.k2 * this.a41) + (this.k4 * this.a42);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_3_11.xml");
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
                        else if (node2.Name == "k1")
                        {
                            this.k1 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "k2")
                        {
                            this.k2 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "k3")
                        {
                            this.k3 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "k4")
                        {
                            this.k4 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "m")
                        {
                            this.m = int.Parse(node2.InnerText);
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
            if (this.t == 0)
            {
                Console.WriteLine("2 相 a1a2");
                Console.WriteLine("a3=" + this.markChange2(this.k1) + "a1" + this.markChange1(this.k3)+"a2");
                Console.WriteLine("a4=" + this.markChange2(this.k2) + "a1" + this.markChange1(this.k4)+"a2");
            }
            if (this.t == 1)
            {
                Console.WriteLine("3 相 a1a2a3");
                Console.WriteLine("a4=" + this.markChange2(this.k2 - (this.m * this.k1)) + "a1" + this.markChange1(this.k4 - (this.m * this.k3)) + "a2" + this.markChange1(this.m)+ "a3");
            }

        }
        private string markChange1(int randomnumber)
        {
            if (randomnumber < 0)
            {
                if (randomnumber == -1)
                {
                    this.stringnumber = " - ";
                }
                else
                {
                    this.stringnumber = " - " + (-randomnumber).ToString();
                }
            }
            else if (randomnumber > 0)
            {
                if (randomnumber == 1)
                {
                    this.stringnumber = " + ";
                }
                else
                {
                    this.stringnumber = " + " + randomnumber.ToString();
                }
            }
            else if (randomnumber == 0)
            {
                this.stringnumber = " + 0";
            }
            return this.stringnumber;
        }

        private string markChange2(int randomnumber)
        {
            if (randomnumber < 0)
            {
                if (randomnumber == -1)
                {
                    this.stringnumber = " -";
                }
                else
                {
                    this.stringnumber = " -" + (-randomnumber).ToString();
                }
            }
            else if (randomnumber > 0)
            {
                if (randomnumber == 1)
                {
                    this.stringnumber = " ";
                }
                else
                {
                    this.stringnumber = " " + randomnumber.ToString();
                }
            }
            else if (randomnumber == 0)
            {
                this.stringnumber = "0";
            }
            return this.stringnumber;
        }

        private string markChange3(int randomnumber)
        {
            if (randomnumber < 0)
            {
                if (randomnumber == -1)
                {
                    this.stringnumber = " - 1";
                }
                else
                {
                    this.stringnumber = " - " + (-randomnumber).ToString();
                }
            }
            else if (randomnumber > 0)
            {
                if (randomnumber == 1)
                {
                    this.stringnumber = " + 1";
                }
                else
                {
                    this.stringnumber = " + " + randomnumber.ToString();
                }
            }
            else if (randomnumber == 0)
            {
                this.stringnumber = "";
            }
            return this.stringnumber;
        }


    }
}
