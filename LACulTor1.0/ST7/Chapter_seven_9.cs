using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST7
{
    class chapter_Seven_9
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a;
        private int a11 = 0;
        private int a12;
        private int a13;
        private int a21;
        private int a22;
        private int a23;
        private int a31;
        private int a32;
        private int a33;
        private int bb11;
        private int bb12;
        private int bb13;
        private int bb21;
        private int bb22;
        private int bb23;
        private int bb31;
        private int bb32;
        private int bb33;
        private int c;
        private Dictionary<string, string> keys = new Dictionary<string, string>();
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
            this.xmldocument.Load("XML/Cal_7_9.xml");
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
                this.a = this.numberTools.myRandom(6);
                this.c = this.numberTools.myRandom(6);
                this.bb11 = this.a11 - (this.a * this.a21);
                this.bb21 = this.a21 - (this.c * this.a31);
                this.bb31 = this.a31;
                this.bb12 = (this.a12 - (this.a * this.a22)) + (this.a * (this.a11 - (this.a * this.a21)));
                this.bb22 = (this.a22 - (this.c * this.a32)) + (this.a * (this.a21 - (this.c * this.a31)));
                this.bb32 = this.a32 + (this.a * this.a31);
                this.bb13 = ((this.a13 - (this.a * this.a23)) + ((this.a * this.c) * (this.a11 - (this.a * this.a21)))) + (this.c * (this.a12 - (this.a * this.a22)));
                this.bb23 = ((this.a23 - (this.c * this.a33)) + ((this.a * this.c) * (this.a21 - (this.c * this.a31)))) + (this.c * (this.a22 - (this.c * this.a32)));
                this.bb33 = (this.a33 + ((this.a * this.c) * this.a31)) + (this.c * this.a32);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_7_9.xml");
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
                        else if (node2.Name == "a")
                        {
                            this.a = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "c")
                        {
                            this.c = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            this.bb11 = this.a11 - (this.a * this.a21);
            this.bb21 = this.a21 - (this.c * this.a31);
            this.bb31 = this.a31;
            this.bb12 = (this.a12 - (this.a * this.a22)) + (this.a * (this.a11 - (this.a * this.a21)));
            this.bb22 = (this.a22 - (this.c * this.a32)) + (this.a * (this.a21 - (this.c * this.a31)));
            this.bb32 = this.a32 + (this.a * this.a31);
            this.bb13 = ((this.a13 - (this.a * this.a23)) + ((this.a * this.c) * (this.a11 - (this.a * this.a21)))) + (this.c * (this.a12 - (this.a * this.a22)));
            this.bb23 = ((this.a23 - (this.c * this.a33)) + ((this.a * this.c) * (this.a21 - (this.c * this.a31)))) + (this.c * (this.a22 - (this.c * this.a32)));
            this.bb33 = (this.a33 + ((this.a * this.c) * this.a31)) + (this.c * this.a32);
            this.keys.Add("aaa", this.a.ToString());
            this.keys.Add("aab", (this.a * this.c).ToString());
            this.keys.Add("aac", this.c.ToString());
            this.keys.Add("baa", "-"+this.a.ToString());
            this.keys.Add("bab", "-"+this.c.ToString());
            this.keys.Add("caa", this.a11.ToString());
            this.keys.Add("cab", this.a12.ToString());
            this.keys.Add("cac", this.a13.ToString());
            this.keys.Add("cba", this.a21.ToString());
            this.keys.Add("cbb", this.a22.ToString());
            this.keys.Add("cbc", this.a23.ToString());
            this.keys.Add("cca", this.a31.ToString());
            this.keys.Add("ccb", this.a32.ToString());
            this.keys.Add("ccc", this.a33.ToString());
            this.keys.Add("daa", (this.a11 - (this.a * this.a21)).ToString());
            this.keys.Add("dab", (this.a12 - (this.a * this.a22)).ToString());
            this.keys.Add("dac", (this.a13 - (this.a * this.a23)).ToString());
            this.keys.Add("dba", (this.a21 - (this.c * this.a31)).ToString());
            this.keys.Add("dbb", (this.a22 - (this.c * this.a32)).ToString());
            int num = this.a23 - (this.c * this.a33);
            this.keys.Add("dbc", num.ToString());
            this.keys.Add("dca", this.a31.ToString());
            this.keys.Add("dcb", this.a32.ToString());
            this.keys.Add("dcc", this.a33.ToString());
            this.keys.Add("eaa", this.bb11.ToString());
            this.keys.Add("eba", this.bb21.ToString());
            this.keys.Add("eca", this.bb31.ToString());
            this.keys.Add("eab", this.bb12.ToString());
            this.keys.Add("ebb", this.bb22.ToString());
            this.keys.Add("ecb", this.bb32.ToString());
            this.keys.Add("eac", this.bb13.ToString());
            this.keys.Add("ebc", this.bb23.ToString());
            this.keys.Add("ecc", this.bb33.ToString());

            string ans = "";
            ans += keys["eaa"] + " " + keys["eab"] + " " + keys["eac"] + "\r\n";
            ans += keys["eba"] + " " + keys["ebb"] + " " + keys["ebc"] + "\r\n";
            ans += keys["eca"] + " " + keys["ecb"] + " " + keys["ecc"] + "\r\n";
            Console.Write(ans);
        }
    }
}
