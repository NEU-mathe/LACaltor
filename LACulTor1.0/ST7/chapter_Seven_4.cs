using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST7
{
    class chapter_Seven_4
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
        private int a22 = 0;
        private int a23 = 0;
        private int a3;
        private int a31 = 0;
        private int a32 = 0;
        private int a33 = 0;
        private int b = 0;
        private int k = 0;
        private Dictionary<string, string> keys = new Dictionary<string, string>();
        private int m = 0;
        private int n = 0;
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
            this.xmldocument.Load("XML/Cal_7_4.xml");
            if (isRegeneration)
            {
                this.a12 = this.numberTools.myRandom(5);
                this.a13 = this.numberTools.myRandom(5);
                this.a21 = this.numberTools.myRandom(5);
                this.a31 = this.numberTools.myRandom(5);
                this.b = this.numberTools.myRandom(5);
                this.m = this.numberTools.myRandom(5);
                this.k = this.numberTools.myRandom(5);
                this.a22 = (this.a21 * this.a12) + 1;
                this.a32 = (this.a31 * this.a12) + 1;
                this.a23 = (this.a21 * this.a13) + this.b;
                this.a33 = ((this.a31 * this.a13) + this.b) + 1;
                this.a1 = ((this.m * this.a11) + (this.n * this.a12)) + (this.k * this.a13);
                this.a2 = ((this.m * this.a21) + (this.n * this.a22)) + (this.k * this.a23);
                this.a3 = ((this.m * this.a31) + (this.n * this.a32)) + (this.k * this.a33);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_7_4.xml");
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
                        else if (node2.Name == "a21")
                        {
                            this.a21 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a31")
                        {
                            this.a31 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b")
                        {
                            this.b = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "m")
                        {
                            this.m = int.Parse(node2.InnerText);
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
            this.a22 = (this.a21 * this.a12) + 1;
            this.a32 = (this.a31 * this.a12) + 1;
            this.a23 = (this.a21 * this.a13) + this.b;
            this.a33 = ((this.a31 * this.a13) + this.b) + 1;
            this.a1 = ((this.m * this.a11) + (this.n * this.a12)) + (this.k * this.a13);
            this.a2 = ((this.m * this.a21) + (this.n * this.a22)) + (this.k * this.a23);
            this.a3 = ((this.m * this.a31) + (this.n * this.a32)) + (this.k * this.a33);
            this.keys.Add("aaa", this.a11.ToString());
            this.keys.Add("aab", this.a12.ToString());
            this.keys.Add("aac", this.a13.ToString());
            this.keys.Add("aad", this.a1.ToString());
            this.keys.Add("aba", this.a21.ToString());
            this.keys.Add("abb", this.a22.ToString());
            this.keys.Add("abc", this.a23.ToString());
            this.keys.Add("abd", this.a2.ToString());
            this.keys.Add("aca", this.a31.ToString());
            this.keys.Add("acb", this.a32.ToString());
            this.keys.Add("acc", this.a33.ToString());
            this.keys.Add("acd", this.a3.ToString());
            this.keys.Add("bad", this.a1.ToString());
            this.keys.Add("bbc", this.b.ToString());
            this.keys.Add("bbd", (this.a2 - (this.a21 * this.a1)).ToString());
            this.keys.Add("bcc", (this.b + 1).ToString());
            this.keys.Add("bcd", (this.a3 - (this.a31 * this.a1)).ToString());
            this.keys.Add("ccd", this.k.ToString());
            this.keys.Add("dad", (this.m + (this.n * this.a12)).ToString());
            this.keys.Add("dbd", this.n.ToString());
            this.keys.Add("ead", this.m.ToString());

            string ans = "";
            ans += "(" + keys["ead"] + ", " + keys["dbd"] + "," + keys["ccd"] + ")T\r\n";
            Console.Write(ans);
        }
    }
}
