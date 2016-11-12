using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST6
{
    class chapter_Six_6
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a = 0;
        private List<int> A = new List<int>();
        private int a11 = 0;
        private int a12 = 0;
        private int a13 = 0;
        private int a22 = 0;
        private int a23 = 0;
        private int a33 = 0;
        private int A6 = 0;
        private int A6faa = 0;
        private int A6fbb = 0;
        private int A6fcc = 0;
        private int aa = 0;
        private int Aab = 0;
        private int Aac = 0;
        private int Abc = 0;
        private int b = 0;
        private List<int> B = new List<int>();
        private int B2 = 0;
        private int B2faa = 0;
        private int B2fbb = 0;
        private int B2fcc = 0;
        private int BA6 = 0;
        private int bb = 0;
        private int BB2 = 0;
        private int Bbb = 0;
        private int C = 0;
        private int faa = 0;
        private int fAab = 0;
        private int fAac = 0;
        private int fAbc = 0;
        private int fbb = 0;
        private int fcc = 0;
        private Dictionary<string, string> keys = new Dictionary<string, string>();
        private int MA6 = 0;
        private int Mab = 0;
        private int Mac = 0;
        private int Mbb = 0;
        private int Mbc = 0;
        private Dictionary<string, string> savestring = new Dictionary<string, string>();
        private string strNum;
        private int TB2 = 0;

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
            this.xmldocument.Load("XML/Cal_6_6.xml");
            if (isRegeneration)
            {
                this.A.Add(this.numberTools.myRandom(3));
                this.B.Add(this.numberTools.myRandom(6));
                this.a = this.A[0];
                this.b = this.B[0];
                this.a11 = 4 * this.a;
                this.a12 = -4 * this.a;
                this.a13 = -4 * this.a;
                this.a22 = this.a + this.b;
                this.a23 = 2 * (this.a - this.b);
                this.aa = this.a11;
                this.bb = this.a22;
                this.Aab = this.a12 / 2;
                this.Aac = this.a13 / 2;
                this.Abc = this.a23 / 2;
                this.Mab = this.a12;
                this.Mac = this.a13;
                this.Mbb = this.a22;
                this.Mbc = this.a23;
                this.MA6 = 6 * this.a;
                this.B2 = 2 * this.b;
                this.A6 = 6 * this.a;
                this.BB2 = 2 * this.b;
                this.BA6 = 6 * this.a;
                this.C = this.b + this.a;
                this.faa = -this.a11;
                this.fAab = -this.a12 / 2;
                this.fAac = -this.a13 / 2;
                this.fbb = -this.a22;
                this.fAbc = -this.a23 / 2;
                this.fcc = -(this.b + this.a);
                this.B2faa = this.B2 - this.a11;
                this.B2fbb = this.B2 - this.a22;
                this.B2fcc = this.B2 - (this.b + this.a);
                this.A6faa = this.A6 - this.a11;
                this.A6fbb = this.A6 - this.a22;
                this.A6fcc = this.A6 - (this.b + this.a);
                this.Bbb = this.a22;
                this.TB2 = 2 * this.b;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_6_6.xml");
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
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            this.a11 = 4 * this.a;
            this.a12 = -4 * this.a;
            this.a13 = -4 * this.a;
            this.a22 = this.a + this.b;
            this.a23 = 2 * (this.a - this.b);
            this.aa = this.a11;
            this.bb = this.a22;
            this.Aab = this.a12 / 2;
            this.Aac = this.a13 / 2;
            this.Abc = this.a23 / 2;
            this.Mab = this.a12;
            this.Mac = this.a13;
            this.Mbb = this.a22;
            this.Mbc = this.a23;
            this.MA6 = 6 * this.a;
            this.B2 = 2 * this.b;
            this.A6 = 6 * this.a;
            this.BB2 = 2 * this.b;
            this.BA6 = 6 * this.a;
            this.C = this.b + this.a;
            this.faa = -this.a11;
            this.fAab = -this.a12 / 2;
            this.fAac = -this.a13 / 2;
            this.fbb = -this.a22;
            this.fAbc = -this.a23 / 2;
            this.fcc = -(this.b + this.a);
            this.B2faa = this.B2 - this.a11;
            this.B2fbb = this.B2 - this.a22;
            this.B2fcc = this.B2 - (this.b + this.a);
            this.A6faa = this.A6 - this.a11;
            this.A6fbb = this.A6 - this.a22;
            this.A6fcc = this.A6 - (this.b + this.a);
            this.Bbb = this.a22;
            this.TB2 = 2 * this.b;
            this.keys.Add("a", this.a.ToString());
            this.keys.Add("b", this.b.ToString());
            this.a11 = 4 * this.a;
            this.a12 = -4 * this.a;
            this.a13 = -4 * this.a;
            this.a22 = this.a + this.b;
            this.a23 = 2 * (this.a - this.b);
            this.aa = this.a11;
            this.bb = this.a22;
            this.Aab = this.a12 / 2;
            this.Aac = this.a13 / 2;
            this.Abc = this.a23 / 2;
            this.Mab = this.a12;
            this.Mac = this.a13;
            this.Mbb = this.a22;
            this.Mbc = this.a23;
            this.BA6 = 6 * this.a;
            this.aa = this.a11;
            this.bb = this.a22;
            this.Aab = this.a12 / 2;
            this.Aac = this.a13 / 2;
            this.Abc = this.a23 / 2;
            this.Mab = this.a12;
            this.Mac = this.a13;
            this.Mbb = this.a22;
            this.Mbc = this.a23;
            this.MA6 = 6 * this.a;
            this.B2 = 2 * this.b;
            this.A6 = 6 * this.a;
            this.BB2 = 2 * this.b;
            this.BA6 = 6 * this.a;
            this.C = this.b + this.a;
            this.faa = -this.a11;
            this.fAab = -this.a12 / 2;
            this.fAac = -this.a13 / 2;
            this.fbb = -this.a22;
            this.fAbc = -this.a23 / 2;
            this.fcc = -(this.b + this.a);
            this.B2faa = this.B2 - this.a11;
            this.B2fbb = this.B2 - this.a22;
            this.B2fcc = this.B2 - (this.b + this.a);
            this.A6faa = this.A6 - this.a11;
            this.A6fbb = this.A6 - this.a22;
            this.A6fcc = this.A6 - (this.b + this.a);
            this.Bbb = this.a22;
            this.TB2 = 2 * this.b;
            this.keys.Add("aa", this.aa.ToString());
            this.keys.Add("bb", this.bb.ToString());
            this.keys.Add("Aab", this.Aab.ToString());
            this.keys.Add("Aac", this.Aac.ToString());
            this.keys.Add("Abc", this.Abc.ToString());
            this.keys.Add("Mab", this.MintTostring(this.Mab).ToString());
            this.keys.Add("Mac", this.MintTostring(this.Mac).ToString());
            this.keys.Add("Mbb", this.MintTostring(this.Mbb).ToString());
            this.keys.Add("Mbc", this.MintTostring(this.Mbc).ToString());
            this.keys.Add("BA6", this.BintTostring(this.BA6).ToString());
            this.keys.Add("B2", this.B2.ToString());
            this.keys.Add("A6", this.A6.ToString());
            this.keys.Add("BB2", this.MintTostring(this.BB2).ToString());
            this.keys.Add("MA6", this.MintTostring(this.MA6).ToString());
            this.keys.Add("C", this.C.ToString());
            this.keys.Add("faa", this.faa.ToString());
            this.keys.Add("fAab", this.fAab.ToString());
            this.keys.Add("fAac", this.fAac.ToString());
            this.keys.Add("fbb", this.fbb.ToString());
            this.keys.Add("fAbc", this.fAbc.ToString());
            this.keys.Add("fcc", this.fcc.ToString());
            this.keys.Add("B2faa", this.B2faa.ToString());
            this.keys.Add("B2fbb", this.B2fbb.ToString());
            this.keys.Add("B2fcc", this.B2fcc.ToString());
            this.keys.Add("A6faa", this.A6faa.ToString());
            this.keys.Add("A6fbb", this.A6fbb.ToString());
            this.keys.Add("A6fcc", this.A6fcc.ToString());
            this.keys.Add("Bbb", this.BintTostring(this.Bbb).ToString());

            string ans = "";
            ans += "(1) t=" + keys["C"]+"\r\n";
            ans += "(2) P=\r\n";
            ans += "1/sqrt(3) 0 -2/sqrt(6)\r\n";
            ans += "1/sqrt(3) 1/sqrt(2) 1/sqrt(6)\r\n";
            ans += "1/sqrt(3) -1/sqrt(2) 1/sqrt(6)\r\n";
            Console.Write(ans);
        }
    }
}
