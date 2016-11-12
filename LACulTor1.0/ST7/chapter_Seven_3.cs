using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST7
{
    class chapter_Seven_3
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private string a;
        private string b;
        private string c;
        private string d;
        private Dictionary<string, string> keys = new Dictionary<string, string>();
        private int m = 0;
        private int n = 0;
        private int s = 0;
        private Dictionary<string, string> savestring = new Dictionary<string, string>();
        private string strNum;
        private int t = 0;
        private int w = 0;
        private int x = 0;
        private int y = 0;
        private int z = 0;

        private string TintTostring(int intNum)
        {
            if (intNum < 0)
            {
                if (intNum == -1)
                {
                    this.strNum = " -";
                }
                else
                {
                    this.strNum = intNum.ToString();
                }
            }
            else if (intNum >= 0)
            {
                if (intNum == 1)
                {
                    this.strNum = "";
                }
                else
                {
                    this.strNum = intNum.ToString();
                }
            }
            return this.strNum;
        }
        private string TopintTostring(int intNum)
        {
            if (intNum < 0)
            {
                if (intNum == -1)
                {
                    this.strNum = " -";
                }
                else
                {
                    this.strNum = intNum.ToString();
                }
            }
            else if (intNum > 0)
            {
                if (intNum == 1)
                {
                    this.strNum = "";
                }
                else
                {
                    this.strNum = intNum.ToString();
                }
            }
            return this.strNum;
        }
        private string MintTostring(int intNum)
        {
            if (intNum < 0)
            {
                if (intNum == -1)
                {
                    this.strNum = " - ";
                }
                else
                {
                    this.strNum = intNum.ToString();
                }
            }
            else if (intNum >= 0)
            {
                if (intNum == 1)
                {
                    this.strNum = " + ";
                }
                else
                {
                    this.strNum = " + " + intNum.ToString();
                }
            }
            return this.strNum;
        }
        private string intTostring(int intNum)
        {
            if (intNum < 0)
            {
                if (intNum == -1)
                {
                    this.strNum = " - ";
                }
                else
                {
                    this.strNum = intNum.ToString();
                }
            }
            else if (intNum > 0)
            {
                if (intNum == 1)
                {
                    this.strNum = " + ";
                }
                else
                {
                    this.strNum = " + " + intNum.ToString();
                }
            }
            return this.strNum;
        }
        private string BintTostring(int intNum)
        {
            if (intNum < 0)
            {
                this.strNum = intNum.ToString();
            }
            else if (intNum > 0)
            {
                this.strNum = " + " + intNum.ToString();
            }
            else if (intNum == 0)
            {
                this.strNum = "";
            }
            return this.strNum;
        }
        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_7_3.xml");
            if (isRegeneration)
            {
                this.x = this.numberTools.myRandom(9);
                this.y = this.numberTools.myRandom(9);
                this.z = this.numberTools.myRandom(9);
                this.w = this.numberTools.myRandom(9);
                this.s = this.numberTools.myRandom(4);
                this.t = this.numberTools.myRandom(4);
                this.n = this.numberTools.myRandom(4);
                this.m = this.numberTools.myRandom(4);
                if (this.w > 0)
                {
                    this.a = (this.m * this.x) + "+" + this.w;
                    this.b = ((this.n * this.y) + (this.s * this.z)) + "+" + this.w;
                    this.c = (this.t * this.z) + "+" + this.w;
                    this.d = this.w.ToString();
                }
                else
                {
                    this.a = (this.m * this.x).ToString() + this.w;
                    this.b = ((this.n * this.y).ToString() + (this.s * this.z)) + this.w;
                    this.c = (this.t * this.z).ToString() + this.w;
                    this.d = this.w.ToString();
                }
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_7_3.xml");
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        if (node2.Name == "a")
                        {
                            this.a = node2.InnerText;
                        }
                        else if (node2.Name == "b")
                        {
                            this.b = node2.InnerText;
                        }
                        else if (node2.Name == "c")
                        {
                            this.c = node2.InnerText;
                        }
                        else if (node2.Name == "w")
                        {
                            this.w = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "s")
                        {
                            this.s = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "t")
                        {
                            this.t = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "n")
                        {
                            this.n = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "m")
                        {
                            this.m = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "x")
                        {
                            this.x = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "y")
                        {
                            this.y = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "z")
                        {
                            this.z = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
                this.d = this.w.ToString();
            }
            this.keys.Add("x", this.TopintTostring(this.x).ToString());
            this.keys.Add("y", this.intTostring(this.y).ToString());
            this.keys.Add("z", this.intTostring(this.z).ToString());
            this.keys.Add("w", this.intTostring(this.w).ToString());
            this.keys.Add("ba", this.m.ToString());
            this.keys.Add("cb", this.n.ToString());
            this.keys.Add("db", this.s.ToString());
            this.keys.Add("dc", this.t.ToString());
            string ans = "";
            ans += "(" + x.ToString() + "," + y.ToString() + "," + z.ToString() + "," + w.ToString() + ")T\r\n";
            Console.Write(ans);
        }
    }
}
