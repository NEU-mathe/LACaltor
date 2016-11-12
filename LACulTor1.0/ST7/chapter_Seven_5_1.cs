using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST7
{
    class chapter_Seven_5_1
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a11 = 1;
        private int a12 = 0;
        private int a13 = 0;
        private int a14 = 0;
        private int a21 = 0;
        private int a22 = 0;
        private int a23 = 0;
        private int a24 = 0;
        private int a31 = 0;
        private int a32 = 0;
        private int a33 = 0;
        private int a34 = 0;
        private int a41 = 0;
        private int a42 = 0;
        private int a43 = 0;
        private int a44 = 0;
        private int h = 0;
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
            this.xmldocument.Load("XML/Cal_7_5_1.xml");
            if (isRegeneration)
            {
                this.a12 = this.numberTools.myRandom(5);
                this.a13 = this.numberTools.myRandom(5);
                this.a14 = this.numberTools.myRandom(5);
                this.a21 = this.numberTools.myRandom(5);
                this.a23 = this.numberTools.myRandom(5);
                this.a24 = this.numberTools.myRandom(5);
                while ((this.m * this.k) == (this.n * this.h))
                {
                    this.m = this.numberTools.myRandom(3);
                    this.n = this.numberTools.myRandom(3);
                    this.h = this.numberTools.myRandom(3);
                    this.k = this.numberTools.myRandom(3);
                }
                this.a22 = (this.a21 * this.a12) + 1;
                this.a32 = (this.a31 * this.a12) + 1;
                this.a31 = (this.m * this.a11) + (this.n * this.a21);
                this.a32 = (this.m * this.a12) + (this.n * this.a22);
                this.a33 = (this.m * this.a13) + (this.n * this.a23);
                this.a34 = (this.m * this.a14) + (this.n * this.a24);
                this.a41 = (this.h * this.a11) + (this.k * this.a21);
                this.a42 = (this.h * this.a12) + (this.k * this.a22);
                this.a43 = (this.h * this.a13) + (this.k * this.a23);
                this.a44 = (this.h * this.a14) + (this.k * this.a24);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_7_5_1.xml");
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
                        else if (node2.Name == "h")
                        {
                            this.h = int.Parse(node2.InnerText);
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
            this.a31 = (this.m * this.a11) + (this.n * this.a21);
            this.a32 = (this.m * this.a12) + (this.n * this.a22);
            this.a33 = (this.m * this.a13) + (this.n * this.a23);
            this.a34 = (this.m * this.a14) + (this.n * this.a24);
            this.a41 = (this.h * this.a11) + (this.k * this.a21);
            this.a42 = (this.h * this.a12) + (this.k * this.a22);
            this.a43 = (this.h * this.a13) + (this.k * this.a23);
            this.a44 = (this.h * this.a14) + (this.k * this.a24);
            this.keys.Add("aab", this.a12.ToString());
            this.keys.Add("aac", this.a13.ToString());
            this.keys.Add("aad", this.a14.ToString());
            this.keys.Add("aba", this.a21.ToString());
            this.keys.Add("abb", this.a22.ToString());
            this.keys.Add("abc", this.a23.ToString());
            this.keys.Add("abd", this.a24.ToString());
            this.keys.Add("aca", this.a31.ToString());
            this.keys.Add("acb", this.a32.ToString());
            this.keys.Add("acc", this.a33.ToString());
            this.keys.Add("acd", this.a34.ToString());
            this.keys.Add("ada", this.a41.ToString());
            this.keys.Add("adb", this.a42.ToString());
            this.keys.Add("adc", this.a43.ToString());
            this.keys.Add("add", this.a44.ToString());
            this.keys.Add("bbc", (this.a23 - (this.a21 * this.a13)).ToString());
            this.keys.Add("bbd", (this.a24 - (this.a21 * this.a14)).ToString());
            this.keys.Add("bcb", (this.a32 - (this.a31 * this.a12)).ToString());
            this.keys.Add("bcc", (this.a33 - (this.a31 * this.a13)).ToString());
            this.keys.Add("bcd", (this.a34 - (this.a31 * this.a14)).ToString());
            this.keys.Add("bdb", (this.a42 - (this.a41 * this.a12)).ToString());
            this.keys.Add("bdc", (this.a43 - (this.a41 * this.a13)).ToString());
            this.keys.Add("bdd", (this.a44 - (this.a41 * this.a14)).ToString());

            string ans = "";
            ans += "维数是：2；一组基是：α1，α2.\r\n";
            Console.Write(ans);
        }
    }
}
