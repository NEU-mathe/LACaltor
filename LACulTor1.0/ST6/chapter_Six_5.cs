using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST6
{
    class chapter_Six_5
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a1 = 0;
        private int a11 = 0;
        private int a12 = 0;
        private int a13 = 0;
        private int a2 = 0;
        private int a22 = 0;
        private int a23 = 0;
        private int a33 = 0;
        private int aa = 0;
        private int Aab = 0;
        private int Aac = 0;
        private int Abc = 0;
        private List<int> b = new List<int>();
        private int b1 = 0;
        private int b2 = 0;
        private int b3 = 0;
        private int bb = 0;
        private int BfC = 0;
        private int C = 0;
        private int cc = 0;
        private Dictionary<string, string> keys = new Dictionary<string, string>();
        private int Mab = 0;
        private int Mac = 0;
        private int Mbb = 0;
        private int Mbc = 0;
        private Dictionary<string, string> savestring = new Dictionary<string, string>();
        private string strNum;
        private int X = 0;
        private int XY = 0;
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

        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_6_5.xml");
            if (isRegeneration)
            {
                this.a1 = this.random.Next(1, 5);
                this.a2 = this.random.Next(1, 5);
                for (int i = 0; i < 4; i++)
                {
                    this.b.Add(this.numberTools.myRandom(6));
                }
                this.b1 = this.b[0];
                this.b2 = this.b[1];
                this.b3 = this.b[2];
                this.a11 = this.a1;
                this.a12 = (2 * this.a1) * this.b1;
                this.a13 = (2 * this.a1) * this.b2;
                this.a22 = ((this.a1 * this.b1) * this.b1) + this.a2;
                this.a23 = 2 * (((this.a1 * this.b1) * this.b2) + (this.a2 * this.b3));
                this.aa = this.a11;
                this.Mbb = this.a22;
                this.Mab = this.a12;
                this.Mac = this.a13;
                this.Mbc = this.a23;
                this.C = ((this.a1 * this.b2) * this.b2) + ((this.a2 * this.b3) * this.b3);
                this.bb = this.a22;
                this.cc = this.a33;
                this.Aab = this.a12 / 2;
                this.Aac = this.a13 / 2;
                this.Abc = this.a23 / 2;
                this.X = this.a1;
                this.XY = this.a1 * this.a2;
                this.BfC = -this.C;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_6_5.xml");
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        if (node2.Name == "a1")
                        {
                            this.a1 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a2")
                        {
                            this.a2 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b1")
                        {
                            this.b1 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b2")
                        {
                            this.b2 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b3")
                        {
                            this.b3 = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            this.a11 = this.a1;
            this.a12 = (2 * this.a1) * this.b1;
            this.a13 = (2 * this.a1) * this.b2;
            this.a22 = ((this.a1 * this.b1) * this.b1) + this.a2;
            this.a23 = 2 * (((this.a1 * this.b1) * this.b2) + (this.a2 * this.b3));
            this.aa = this.a11;
            this.Mbb = this.a22;
            this.Mab = this.a12;
            this.Mac = this.a13;
            this.Mbc = this.a23;
            this.C = ((this.a1 * this.b2) * this.b2) + ((this.a2 * this.b3) * this.b3);
            this.bb = this.a22;
            this.cc = this.a33;
            this.Aab = this.a12 / 2;
            this.Aac = this.a13 / 2;
            this.Abc = this.a23 / 2;
            this.X = this.a1;
            this.XY = this.a1 * this.a2;
            this.BfC = -this.C;
            this.keys.Add("a1", this.a1.ToString());
            this.keys.Add("a2", this.a2.ToString());
            this.keys.Add("b1", this.b1.ToString());
            this.keys.Add("b2", this.b2.ToString());
            this.keys.Add("b3", this.b3.ToString());
            this.a11 = this.a1;
            this.a12 = (2 * this.a1) * this.b1;
            this.a13 = (2 * this.a1) * this.b2;
            this.a22 = ((this.a1 * this.b1) * this.b1) + this.a2;
            this.a23 = 2 * (((this.a1 * this.b1) * this.b2) + (this.a2 * this.b3));
            this.aa = this.a11;
            this.Mbb = this.a22;
            this.Mab = this.a12;
            this.Mac = this.a13;
            this.Mbc = this.a23;
            this.C = ((this.a1 * this.b2) * this.b2) + ((this.a2 * this.b3) * this.b3);
            this.bb = this.a22;
            this.cc = this.a33;
            this.Aab = this.a12 / 2;
            this.Aac = this.a13 / 2;
            this.Abc = this.a23 / 2;
            this.X = this.a1;
            this.XY = this.a1 * this.a2;
            this.BfC = -this.C;
            this.keys.Add("aa", this.aa.ToString());
            this.keys.Add("Mab", this.MintTostring(this.Mab).ToString());
            this.keys.Add("Mac", this.MintTostring(this.Mac).ToString());
            this.keys.Add("Mbc", this.MintTostring(this.Mbc).ToString());
            this.keys.Add("C", this.C.ToString());
            this.keys.Add("bb", this.bb.ToString());
            this.keys.Add("cc", this.cc.ToString());
            this.keys.Add("Aab", this.Aab.ToString());
            this.keys.Add("Aac", this.Aac.ToString());
            this.keys.Add("Abc", this.Abc.ToString());
            this.keys.Add("X", this.X.ToString());
            this.keys.Add("XY", this.XY.ToString());
            this.keys.Add("BfC", this.BfC.ToString());

            string ans = "";
            ans += "t>"+keys["C"]+"\r\n";
            Console.Write(ans);
        }
    }
}
