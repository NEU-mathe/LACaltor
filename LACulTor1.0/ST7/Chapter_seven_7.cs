using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST7
{
    class chapter_Seven_7
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a11 = 1;
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
            this.xmldocument.Load("XML/Cal_7_7.xml");
            if (isRegeneration)
            {
                this.a12 = this.numberTools.myRandom(6);
                this.a13 = this.numberTools.myRandom(6);
                this.a14 = this.numberTools.myRandom(6);
                this.a21 = this.numberTools.myRandom(6);
                this.a23 = this.numberTools.myRandom(6);
                this.a24 = this.numberTools.myRandom(6);
                this.m = this.numberTools.myRandom(3);
                this.n = this.numberTools.myRandom(3);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_7_7.xml");
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
                        else if (node2.Name == "a23")
                        {
                            this.a23 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a24")
                        {
                            this.a24 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "m")
                        {
                            this.m = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "n")
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
            this.a22 = (this.a21 * this.a12) + 1;
            this.a31 = (this.m * this.a11) + (this.n * this.a21);
            this.a32 = (this.m * this.a12) + (this.n * this.a22);
            this.a33 = (this.m * this.a13) + (this.n * this.a23);
            this.a34 = (this.m * this.a14) + (this.n * this.a24);
            this.keys.Add("aaa", this.a11.ToString());
            this.keys.Add("aab", this.intTostring(this.a12));
            this.keys.Add("aac", this.intTostring(this.a13));
            this.keys.Add("aad", this.intTostring(this.a14));
            this.keys.Add("aba", this.a21.ToString());
            this.keys.Add("abb", this.intTostring(this.a22));
            this.keys.Add("abc", this.intTostring(this.a23));
            this.keys.Add("abd", this.intTostring(this.a24));
            this.keys.Add("aca", this.a31.ToString());
            this.keys.Add("acb", this.intTostring(this.a32));
            this.keys.Add("acc", this.intTostring(this.a33));
            this.keys.Add("acd", this.intTostring(this.a34));
            this.keys.Add("bba", ((this.a12 * (this.a23 - (this.a21 * this.a13))) - this.a13).ToString());
            this.keys.Add("bbb", ((this.a21 * this.a13) - this.a23).ToString());
            this.keys.Add("bbc", (((((this.a12 * (this.a23 - (this.a21 * this.a13))) - this.a13) * ((this.a12 * (this.a23 - (this.a21 * this.a13))) - this.a13)) + (((this.a21 * this.a13) - this.a23) * ((this.a21 * this.a13) - this.a23))) + 1).ToString());
            this.keys.Add("bbd", ((this.a12 * (this.a23 - (this.a21 * this.a13))) - this.a13).ToString());
            this.keys.Add("bbe", ((this.a21 * this.a13) - this.a23).ToString());

            string ans = "";
            ans += "E=(1/" + "sqrt(" + keys["bbc"] + "))*(" + keys["bbd"] + "," + keys["bbe"] + ",1,0)T.\r\n";
            Console.Write(ans);
        }
    }
}
