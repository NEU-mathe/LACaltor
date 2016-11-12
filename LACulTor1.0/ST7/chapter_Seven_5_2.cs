using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST7
{
    class chapter_Seven_5_2
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a11 = 0;
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
        private int c11;
        private int c21;
        private int c22;
        private int c31;
        private int c32;
        private int c33;
        private int d11;
        private int d12;
        private int d13;
        private int d22;
        private int d23;
        private int d33;
        private int ddda = 0;
        private int dddb = 0;
        private int dddc = 0;
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
            this.xmldocument.Load("XML/Cal_7_5_2.xml");
            if (isRegeneration)
            {
                this.c11 = this.numberTools.myRandom(6);
                this.c22 = this.numberTools.myRandom(6);
                this.c33 = this.numberTools.myRandom(6);
                this.d11 = this.numberTools.myRandom(6);
                this.d22 = this.numberTools.myRandom(6);
                this.d33 = this.numberTools.myRandom(6);
                this.a14 = this.numberTools.myRandom(6);
                this.a24 = this.numberTools.myRandom(6);
                this.a34 = this.numberTools.myRandom(6);
                this.c21 = this.numberTools.myRandom(5);
                this.c31 = this.numberTools.myRandom(5);
                this.c32 = this.numberTools.myRandom(5);
                this.d12 = this.numberTools.myRandom(5);
                this.d13 = this.numberTools.myRandom(5);
                this.d23 = this.numberTools.myRandom(5);
                this.a11 = this.c11 * this.d11;
                this.a12 = this.c11 * this.d12;
                this.a13 = this.c11 * this.d13;
                this.a21 = this.c21 * this.d11;
                this.a31 = this.c31 * this.d11;
                this.a22 = (this.c21 * this.d12) + (this.c22 * this.d22);
                this.a23 = (this.c21 * this.d13) + (this.c22 * this.d23);
                this.a32 = (this.a31 * this.d12) + (this.c32 * this.d22);
                this.a33 = ((this.c31 * this.d13) + (this.c32 * this.d23)) + (this.c33 * this.d33);
                while (this.m == this.n)
                {
                    this.m = this.numberTools.myRandom(4);
                    this.n = this.numberTools.myRandom(4);
                }
                this.a41 = (this.m * this.a11) + (this.n * this.a21);
                this.a42 = (this.m * this.a12) + (this.n * this.a22);
                this.a43 = (this.m * this.a13) + (this.n * this.a23);
                this.a44 = (this.m * this.a14) + (this.n * this.a24);
                this.ddda = (((this.a33 * this.a11) - (this.a31 * this.a13)) * ((this.a22 * this.a11) - (this.a21 * this.a12))) - (((this.a32 * this.a11) - (this.a31 * this.a12)) * ((this.a23 * this.a11) - (this.a21 * this.a13)));
                this.dddb = ((this.a22 * this.a11) - (this.a21 * this.a12)) * this.a11;
                this.dddc = (((this.a43 * this.a11) - (this.a41 * this.a13)) * ((this.a22 * this.a11) - (this.a21 * this.a12))) - (((this.a42 * this.a11) - (this.a41 * this.a12)) * ((this.a23 * this.a11) - (this.a21 * this.a13)));
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_7_5_2.xml");
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        if (node2.Name == "c11")
                        {
                            this.c11 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c22")
                        {
                            this.c22 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c33")
                        {
                            this.c33 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d11")
                        {
                            this.d11 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d22")
                        {
                            this.d22 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d33")
                        {
                            this.d33 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a14")
                        {
                            this.a14 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a24")
                        {
                            this.a24 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a34")
                        {
                            this.a34 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c21")
                        {
                            this.c21 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c31")
                        {
                            this.c31 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c32")
                        {
                            this.c32 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d12")
                        {
                            this.d12 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d13")
                        {
                            this.d13 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "d23")
                        {
                            this.d23 = int.Parse(node2.InnerText);
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
            this.a11 = this.c11 * this.d11;
            this.a12 = this.c11 * this.d12;
            this.a13 = this.c11 * this.d13;
            this.a21 = this.c21 * this.d11;
            this.a31 = this.c31 * this.d11;
            this.a22 = (this.c21 * this.d12) + (this.c22 * this.d22);
            this.a23 = (this.c21 * this.d13) + (this.c22 * this.d23);
            this.a32 = (this.a31 * this.d12) + (this.c32 * this.d22);
            this.a33 = ((this.c31 * this.d13) + (this.c32 * this.d23)) + (this.c33 * this.d33);
            this.a41 = (this.m * this.a11) + (this.n * this.a21);
            this.a42 = (this.m * this.a12) + (this.n * this.a22);
            this.a43 = (this.m * this.a13) + (this.n * this.a23);
            this.a44 = (this.m * this.a14) + (this.n * this.a24);
            this.ddda = (((this.a33 * this.a11) - (this.a31 * this.a13)) * ((this.a22 * this.a11) - (this.a21 * this.a12))) - (((this.a32 * this.a11) - (this.a31 * this.a12)) * ((this.a23 * this.a11) - (this.a21 * this.a13)));
            this.dddb = ((this.a22 * this.a11) - (this.a21 * this.a12)) * this.a11;
            this.dddc = (((this.a43 * this.a11) - (this.a41 * this.a13)) * ((this.a22 * this.a11) - (this.a21 * this.a12))) - (((this.a42 * this.a11) - (this.a41 * this.a12)) * ((this.a23 * this.a11) - (this.a21 * this.a13)));
            this.keys.Add("aaa", this.a11.ToString());
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
            this.keys.Add("bbbs", ((this.a22 * this.a11) - (this.a21 * this.a12)).ToString());
            this.keys.Add("bbbt", this.a11.ToString());
            this.keys.Add("bbcs", ((this.a23 * this.a11) - (this.a21 * this.a13)).ToString());
            this.keys.Add("bbds", ((this.a24 * this.a11) - (this.a21 * this.a14)).ToString());
            this.keys.Add("bcbs", ((this.a32 * this.a11) - (this.a31 * this.a12)).ToString());
            this.keys.Add("bccs", ((this.a33 * this.a11) - (this.a31 * this.a13)).ToString());
            this.keys.Add("bcds", ((this.a34 * this.a11) - (this.a31 * this.a14)).ToString());
            this.keys.Add("bdbs", ((this.a42 * this.a11) - (this.a41 * this.a12)).ToString());
            this.keys.Add("bdcs", ((this.a43 * this.a11) - (this.a41 * this.a13)).ToString());
            this.keys.Add("bdds", ((this.a44 * this.a11) - (this.a41 * this.a14)).ToString());
            this.keys.Add("ccca", this.ddda.ToString());
            this.keys.Add("cccb", this.dddb.ToString());
            this.keys.Add("cdca", this.dddc.ToString());
            this.keys.Add("cdcb", this.dddb.ToString());

            string ans = "";
            ans += "维数是：3；一组基是：α1，α2，α3.\r\n";
            Console.Write(ans);
        }
    }
}
