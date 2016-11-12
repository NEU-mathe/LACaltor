using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST7
{
    class chapter_Seven_10
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a;
        private int a11 = 0;
        private int a12;
        private int a13;
        private int b;
        private int c;
        private int d;
        private int e;
        private int f;
        private int k;
        private Dictionary<string, string> keys = new Dictionary<string, string>();
        private int m;
        private int n;
        private Dictionary<string, string> savestring = new Dictionary<string, string>();
        private string strNum;

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
            this.xmldocument.Load("XML/Cal_7_10.xml");
            if (isRegeneration)
            {
                this.a = this.numberTools.myRandom(7);
                this.b = this.numberTools.myRandom(7);
                this.c = this.numberTools.myRandom(7);
                this.d = this.numberTools.myRandom(7);
                this.e = this.numberTools.myRandom(7);
                this.f = this.numberTools.myRandom(7);
                this.m = this.numberTools.myRandom(7);
                this.n = this.numberTools.myRandom(7);
                this.k = this.numberTools.myRandom(7);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_7_10.xml");
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        if (node2.Name == "a")
                        {
                            this.a = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b")
                        {
                            this.b = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c")
                        {
                            this.c = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d")
                        {
                            this.d = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "e")
                        {
                            this.e = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "f")
                        {
                            this.f = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "m")
                        {
                            this.m = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "n")
                        {
                            this.n = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "k")
                        {
                            this.k = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            while ((this.a11 = ((this.m * this.a) + (this.n * this.b)) + (this.k * this.d)) == 0)
            {
                this.m = -this.m;
                this.a11 = ((this.m * this.a) + (this.n * this.b)) + (this.k * this.d);
            }
            while ((this.a12 = (this.n * this.c) + (this.k * this.e)) == 0)
            {
                this.n = -this.n;
                this.a12 = (this.n * this.c) + (this.k * this.e);
            }
            this.a13 = this.k * this.f;
            this.keys.Add("aaa", this.a.ToString());
            this.keys.Add("aab", this.b.ToString());
            this.keys.Add("aac", this.c.ToString());
            this.keys.Add("aad", this.d.ToString());
            this.keys.Add("aae", this.e.ToString());
            this.keys.Add("aaf", this.f.ToString());
            this.keys.Add("baa", this.a11.ToString());
            this.keys.Add("bab", this.a12.ToString());
            this.keys.Add("bac", this.a13.ToString());
            this.keys.Add("caa", ((this.a * this.c) * this.f).ToString());
            this.keys.Add("daa", (this.c * this.f).ToString());
            this.keys.Add("dab", (-this.b * this.f).ToString());
            this.keys.Add("dac", ((this.b * this.e) - (this.c * this.d)).ToString());
            this.keys.Add("dbb", (this.a * this.f).ToString());
            this.keys.Add("dbc", (-this.a * this.e).ToString());
            this.keys.Add("dcc", (this.a * this.c).ToString());
            this.keys.Add("eaa", this.m.ToString());
            this.keys.Add("eab", this.n.ToString());
            this.keys.Add("eac", this.k.ToString());

            string ans = "";
            ans += "过渡矩阵为：\r\n";
            ans += keys["aaa"] + " " + keys["aab"] + " " + keys["aad"] + "\r\n";
            ans += "0" + " " + keys["aac"] + " " + keys["aae"] + "\r\n";
            ans += "0 0 " + keys["aaf"] + "\r\n";
            ans += "p(x)坐标为：(" + keys["eaa"] + "," + keys["eab"] + "," + keys["eac"] + ").\r\n";
            Console.Write(ans);
        }
    }
}
