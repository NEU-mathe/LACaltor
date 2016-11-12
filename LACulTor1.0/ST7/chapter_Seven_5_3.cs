using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST7
{
    class chapter_Seven_5_3
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
        private int ddda1 = 0;
        private int ddda2;
        private int ddda3;
        private int ddda4;
        private int dddaa = 0;
        private int dddbb = 0;
        private int dddc = 0;
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
            this.xmldocument.Load("XML/Cal_7_5_3.xml");
            if (isRegeneration)
            {
                this.a12 = this.numberTools.myRandom(5);
                this.a13 = this.numberTools.myRandom(5);
                this.a14 = this.numberTools.myRandom(5);
                this.a21 = this.numberTools.myRandom(5);
                this.a31 = this.numberTools.myRandom(5);
                this.a41 = this.numberTools.myRandom(5);
                this.a22 = (this.a21 * this.a12) + 1;
                this.a23 = (this.a21 * this.a13) + 2;
                this.a24 = (this.a21 * this.a14) + 3;
                this.a32 = (this.a31 * this.a12) + 2;
                this.a33 = (this.a31 * this.a13) + 5;
                this.a34 = (this.a31 * this.a14) + 7;
                this.a42 = (this.a41 * this.a12) + 3;
                this.a43 = (this.a41 * this.a13) + 7;
                this.a44 = (this.a41 * this.a14) + 11;
                this.dddaa = (((this.a33 * this.a11) - (this.a31 * this.a13)) * ((this.a22 * this.a11) - (this.a21 * this.a12))) - (((this.a32 * this.a11) - (this.a31 * this.a12)) * ((this.a23 * this.a11) - (this.a21 * this.a13)));
                this.dddbb = ((this.a22 * this.a11) - (this.a21 * this.a12)) * this.a11;
                this.dddc = (((this.a43 * this.a11) - (this.a41 * this.a13)) * ((this.a22 * this.a11) - (this.a21 * this.a12))) - (((this.a42 * this.a11) - (this.a41 * this.a12)) * ((this.a23 * this.a11) - (this.a21 * this.a13)));
                this.ddda1 = (((this.a34 * this.a11) - (this.a31 * this.a14)) * ((this.a22 * this.a11) - (this.a21 * this.a12))) - (((this.a32 * this.a11) - (this.a31 * this.a12)) * ((this.a24 * this.a11) - (this.a21 * this.a14)));
                this.ddda2 = (((this.a44 * this.a11) - (this.a41 * this.a14)) * ((this.a22 * this.a11) - (this.a21 * this.a12))) - (((this.a42 * this.a11) - (this.a41 * this.a12)) * ((this.a24 * this.a11) - (this.a21 * this.a14)));
                this.ddda3 = (this.ddda2 * this.dddaa) - (this.dddc * this.ddda1);
                this.ddda4 = this.dddbb * this.dddaa;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_7_5_3.xml");
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
                        else if (node2.Name == "a31")
                        {
                            this.a31 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a41")
                        {
                            this.a41 = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            this.a22 = (this.a21 * this.a12) + 1;
            this.a23 = (this.a21 * this.a13) + 2;
            this.a24 = (this.a21 * this.a14) + 3;
            this.a32 = (this.a31 * this.a12) + 2;
            this.a33 = (this.a31 * this.a13) + 5;
            this.a34 = (this.a31 * this.a14) + 7;
            this.a42 = (this.a41 * this.a12) + 3;
            this.a43 = (this.a41 * this.a13) + 7;
            this.a44 = (this.a41 * this.a14) + 11;
            this.dddaa = (((this.a33 * this.a11) - (this.a31 * this.a13)) * ((this.a22 * this.a11) - (this.a21 * this.a12))) - (((this.a32 * this.a11) - (this.a31 * this.a12)) * ((this.a23 * this.a11) - (this.a21 * this.a13)));
            this.dddbb = ((this.a22 * this.a11) - (this.a21 * this.a12)) * this.a11;
            this.dddc = (((this.a43 * this.a11) - (this.a41 * this.a13)) * ((this.a22 * this.a11) - (this.a21 * this.a12))) - (((this.a42 * this.a11) - (this.a41 * this.a12)) * ((this.a23 * this.a11) - (this.a21 * this.a13)));
            this.ddda1 = (((this.a34 * this.a11) - (this.a31 * this.a14)) * ((this.a22 * this.a11) - (this.a21 * this.a12))) - (((this.a32 * this.a11) - (this.a31 * this.a12)) * ((this.a24 * this.a11) - (this.a21 * this.a14)));
            this.ddda2 = (((this.a44 * this.a11) - (this.a41 * this.a14)) * ((this.a22 * this.a11) - (this.a21 * this.a12))) - (((this.a42 * this.a11) - (this.a41 * this.a12)) * ((this.a24 * this.a11) - (this.a21 * this.a14)));
            this.ddda3 = (this.ddda2 * this.dddaa) - (this.dddc * this.ddda1);
            this.ddda4 = this.dddbb * this.dddaa;
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
            this.keys.Add("ccca", this.dddaa.ToString());
            this.keys.Add("ccda", this.ddda1.ToString());
            this.keys.Add("cccb", this.dddbb.ToString());
            this.keys.Add("cdca", this.dddc.ToString());
            this.keys.Add("cdda", this.ddda2.ToString());
            this.keys.Add("cdcb", this.dddbb.ToString());
            this.keys.Add("ddda", this.ddda3.ToString());
            this.keys.Add("dddb", this.ddda4.ToString());

            string ans = "";
            ans += "维数是：4；一组基是：α1，α2，α3，α4.\r\n";
            Console.Write(ans);
        }
    }
}
