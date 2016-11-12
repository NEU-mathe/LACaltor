using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST7
{
    class chapter_Seven_1
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a = 0;
        private int b = 0;
        private int c = 0;
        private int d = 0;
        private int e = 0;
        private int f = 0;
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
            this.xmldocument.Load("XML/Cal_7_1.xml");
            if (isRegeneration)
            {
                this.b = this.numberTools.myRandom(3);
                this.c = this.numberTools.myRandom(3);
                this.d = this.numberTools.myRandom(3);
                this.e = this.numberTools.myRandom(3);
                this.a = this.random.Next(0, 2);
                this.f = this.random.Next(0, 2);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_7_1.xml");
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
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }

            string ans = "";
            if ((this.a == 0) && (this.f == 0))
                ans += "是.\r\n";
            else
                ans += "不是.\r\n";
            Console.Write(ans);
        }
    }
}
