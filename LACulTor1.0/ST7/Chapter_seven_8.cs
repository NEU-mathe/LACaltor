using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST7
{
    class chapter_Seven_8
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a11 = 0;
        private int a12;
        private int a13;
        private int a21;
        private int a22;
        private int a23;
        private int a31;
        private int a32;
        private int a33;
        private int b11;
        private int b12;
        private int b13;
        private int b21;
        private int b22;
        private int b23;
        private int b31;
        private int b32;
        private int b33;
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
            this.xmldocument.Load("XML/Cal_7_8.xml");
            if (isRegeneration)
            {
                this.a11 = this.numberTools.myRandom(6);
                this.a12 = this.numberTools.myRandom(6);
                this.a13 = this.numberTools.myRandom(6);
                this.a21 = this.numberTools.myRandom(6);
                this.a22 = this.numberTools.myRandom(6);
                this.a23 = this.numberTools.myRandom(6);
                this.a31 = this.numberTools.myRandom(6);
                this.a32 = this.numberTools.myRandom(6);
                this.a33 = this.numberTools.myRandom(6);
                this.m = this.numberTools.myRandom(3);
                this.n = this.numberTools.myRandom(3);
                this.k = this.numberTools.myRandom(3);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_7_8.xml");
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
                        else if (node2.Name == "a22")
                        {
                            this.a22 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a23")
                        {
                            this.a23 = int.Parse(node2.InnerText);
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
            this.b11 = (((1 - ((this.m * this.n) * this.k)) * (this.a11 + (this.n * this.a13))) - (this.k * (this.a21 + (this.n * this.a23)))) + ((this.m * this.k) * (this.a31 + (this.n * this.a33)));
            this.b21 = (-this.n * (this.a11 + (this.n * this.a13))) + (this.a31 + (this.n * this.a33));
            this.b31 = (((this.m * this.n) * (this.a11 + (this.n * this.a13))) + (this.a21 + (this.n * this.a23))) - (this.m * (this.a31 + (this.n * this.a33)));
            this.b12 = (((1 - ((this.m * this.n) * this.k)) * ((this.m * this.a12) + this.a13)) - (this.k * ((this.m * this.a22) + this.a23))) + ((this.m * this.k) * ((this.m * this.a32) + this.a33));
            this.b22 = (-this.n * ((this.m * this.a12) + this.a13)) + ((this.m * this.a32) + this.a33);
            this.b32 = (((this.m * this.n) * ((this.m * this.a12) + this.a13)) + ((this.m * this.a22) + this.a23)) - (this.m * ((this.m * this.a32) + this.a33));
            this.b13 = (((1 - ((this.m * this.n) * this.k)) * (((this.k * this.a11) + this.a12) + ((this.k * this.n) * this.a13))) - (this.k * (((this.k * this.a21) + this.a22) + ((this.k * this.n) * this.a23)))) + ((this.m * this.k) * (((this.k * this.a31) + this.a32) + ((this.k * this.n) * this.a33)));
            this.b23 = (-this.n * (((this.k * this.a11) + this.a12) + ((this.k * this.n) * this.a13))) + (((this.k * this.a31) + this.a32) + ((this.k * this.n) * this.a33));
            this.b33 = (((this.m * this.n) * (((this.k * this.a11) + this.a12) + ((this.k * this.n) * this.a13))) + (((this.k * this.a21) + this.a22) + ((this.k * this.n) * this.a23))) - (this.m * (((this.k * this.a31) + this.a32) + ((this.k * this.n) * this.a33)));
            this.keys.Add("aaa", (this.a11 + (this.n * this.a13)).ToString());
            this.keys.Add("aab", (this.a21 + (this.n * this.a23)).ToString());
            this.keys.Add("aac", (this.a31 + (this.n * this.a33)).ToString());
            this.keys.Add("baa", this.b11.ToString());
            this.keys.Add("bab", this.b21.ToString());
            this.keys.Add("bac", this.b31.ToString());
            this.keys.Add("caa", ((this.m * this.a12) + this.a13).ToString());
            this.keys.Add("cab", ((this.m * this.a22) + this.a23).ToString());
            this.keys.Add("cac", ((this.m * this.a32) + this.a33).ToString());
            this.keys.Add("daa", this.b12.ToString());
            this.keys.Add("dab", this.b22.ToString());
            this.keys.Add("dac", this.b32.ToString());
            this.keys.Add("eaa", (((this.k * this.a11) + this.a12) + ((this.k * this.n) * this.a13)).ToString());
            this.keys.Add("eab", (((this.k * this.a21) + this.a22) + ((this.k * this.n) * this.a23)).ToString());
            int num = ((this.k * this.a31) + this.a32) + ((this.k * this.n) * this.a33);
            this.keys.Add("eac", num.ToString());
            this.keys.Add("faa", this.b13.ToString());
            this.keys.Add("fab", this.b23.ToString());
            this.keys.Add("fac", this.b33.ToString());

            string ans = "";
            ans += keys["baa"] + " " + keys["daa"] + " " + keys["faa"] + "\r\n";
            ans += keys["bab"] + " " + keys["dab"] + " " + keys["fab"] + "\r\n";
            ans += keys["bac"] + " " + keys["dac"] + " " + keys["fac"] + "\r\n";
            Console.Write(ans);
        }
    }
}
