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
    class chapter_Three_10
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a1;
        private int a2;
        private int a3;
        private int b2;
        private int b3;
        private int c2;
        private int c3;
        private int d;
        private int val2;
        private string stringnumber;

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
                    this.stringnumber = " - " + randomnumber.ToString();
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
                    this.stringnumber = " -" + randomnumber.ToString();
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
                    this.stringnumber = " - " + randomnumber.ToString();
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

        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_3_10.xml");
            if (isRegeneration)
            {
                this.a1 = this.numberTools.myRandom(4);
                this.a2 = this.numberTools.myRandom(4);
                this.a3 = this.numberTools.myRandom(4);
                this.b2 = this.numberTools.myRandom(4);
                this.b3 = this.numberTools.myRandom(4);
                this.c2 = this.numberTools.myRandom(4);
                this.c3 = this.numberTools.myRandom(4);
                this.d = this.numberTools.myRandom(4);
                string str = this.markChange2(this.a1);
                string str4 = this.markChange2(this.b2);
                string str6 = this.markChange2(this.c2);
                string str2 = this.markChange1(this.a2);
                string str3 = this.markChange1(this.a3);
                string str5 = this.markChange1(this.b3);
                string str7 = this.markChange1(this.c3);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_3_10.xml");
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
                        else if (node2.Name == "a3")
                        {
                            this.a3 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b2")
                        {
                            this.b2 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b3")
                        {
                            this.b3 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c2")
                        {
                            this.c2 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c3")
                        {
                            this.c3 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d")
                        {
                            this.d = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            val2 = (this.a1 * this.d) * ((this.b2 * this.c3) - (this.b3 * this.c2));
            Console.WriteLine("{0}", this.val2);

        }


    }
}

