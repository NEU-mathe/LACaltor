using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST6
{
    class chapter_Six_4
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private List<int> A = new List<int>();
        private int a1 = 0;
        private int a11 = 0;
        private int a12 = 0;
        private int a13 = 0;
        private int a2 = 0;
        private int a22 = 0;
        private int a23 = 0;
        private int a3 = 0;
        private int a33 = 0;
        private int aa = 0;
        private List<int> B = new List<int>();
        private int b1 = 0;
        private int b2 = 0;
        private int b3 = 0;
        private int F = 0;
        private int H = 0;
        private int I = 0;
        private Dictionary<string, string> keys = new Dictionary<string, string>();
        private int Mab = 0;
        private int MAbb = 0;
        private int Mac = 0;
        private int MAcc = 0;
        private int Mbb = 0;
        private int Mbc = 0;
        private int Mcc = 0;
        private int MfJ = 0;
        private int MfL = 0;
        private int MH = 0;
        private int MI = 0;
        private int MJ = 0;
        private int MK = 0;
        private int ML = 0;
        private int MX = 0;
        private int MY = 0;
        private int MZ = 0;
        private Dictionary<string, string> savestring = new Dictionary<string, string>();
        private string strNum;
        private int Taa = 0;
        private int TAaa = 0;
        private int TF = 0;

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
            this.xmldocument.Load("XML/Cal_6_4.xml");
            if (isRegeneration)
            {
                int num;
                for (num = 0; num < 3; num++)
                {
                    this.A.Add(this.numberTools.myRandom(6));
                }
                for (num = 0; num < 3; num++)
                {
                    this.B.Add(this.numberTools.myRandom(6));
                }
                this.a1 = this.A[0];
                this.a2 = this.A[1];
                this.a3 = this.A[2];
                this.b1 = this.B[0];
                this.b2 = this.B[1];
                this.b3 = this.B[2];
                this.a11 = this.a1;
                this.a12 = (2 * this.a1) * this.b1;
                this.a13 = (2 * this.a1) * this.b2;
                this.a22 = ((this.a1 * this.b1) * this.b1) + this.a2;
                this.a23 = 2 * (((this.a1 * this.b1) * this.b2) + (this.a2 * this.b3));
                this.a33 = (((this.a1 * this.b2) * this.b2) + ((this.a2 * this.b3) * this.b3)) + this.a3;
                this.Taa = this.a11;
                this.Mbb = this.a22;
                this.Mab = this.a12;
                this.Mac = this.a13;
                this.Mbc = this.a23;
                this.Mcc = this.a33;
                this.TAaa = 2 * this.a11;
                this.MAbb = 2 * this.a22;
                this.MAcc = 2 * this.a33;
                this.MJ = this.b1;
                this.MK = this.b2;
                this.ML = this.b3;
                this.MX = ((this.a2 * this.b3) * this.b3) + this.a3;
                this.MY = (2 * this.a2) * this.b3;
                this.MI = this.a3;
                this.aa = this.a11;
                this.MfJ = -this.b1;
                this.MZ = (this.b1 * this.b3) - this.b2;
                this.MfL = -this.b3;
                this.TF = this.a1;
                this.MH = this.a2;
                this.F = this.a1;
                this.H = this.a2;
                this.I = this.a3;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_6_4.xml");
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
                        else if (node2.Name == "a3")
                        {
                            this.a3 = int.Parse(node2.InnerText);
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
            this.a33 = (((this.a1 * this.b2) * this.b2) + ((this.a2 * this.b3) * this.b3)) + this.a3;
            this.Taa = this.a11;
            this.Mbb = this.a22;
            this.Mab = this.a12;
            this.Mac = this.a13;
            this.Mbc = this.a23;
            this.Mcc = this.a33;
            this.TAaa = 2 * this.a11;
            this.MAbb = 2 * this.a22;
            this.MAcc = 2 * this.a33;
            this.MJ = this.b1;
            this.MK = this.b2;
            this.ML = this.b3;
            this.MX = ((this.a2 * this.b3) * this.b3) + this.a3;
            this.MY = (2 * this.a2) * this.b3;
            this.MI = this.a3;
            this.aa = this.a11;
            this.MfJ = -this.b1;
            this.MZ = (this.b1 * this.b3) - this.b2;
            this.MfL = -this.b3;
            this.TF = this.a1;
            this.MH = this.a2;
            this.F = this.a1;
            this.H = this.a2;
            this.I = this.a3;
            this.keys.Add("a1", this.a1.ToString());
            this.keys.Add("a2", this.a2.ToString());
            this.keys.Add("a3", this.a3.ToString());
            this.keys.Add("b1", this.b1.ToString());
            this.keys.Add("b2", this.b2.ToString());
            this.keys.Add("b3", this.b3.ToString());
            this.a11 = this.a1;
            this.a12 = (2 * this.a1) * this.b1;
            this.a13 = (2 * this.a1) * this.b2;
            this.a22 = ((this.a1 * this.b1) * this.b1) + this.a2;
            this.a23 = 2 * (((this.a1 * this.b1) * this.b2) + (this.a2 * this.b3));
            this.a33 = (((this.a1 * this.b2) * this.b2) + ((this.a2 * this.b3) * this.b3)) + this.a3;
            this.Taa = this.a11;
            this.Mbb = this.a22;
            this.Mab = this.a12;
            this.Mac = this.a13;
            this.Mbc = this.a23;
            this.Mcc = this.a33;
            this.TAaa = 2 * this.a11;
            this.MAbb = 2 * this.a22;
            this.MAcc = 2 * this.a33;
            this.MJ = this.b1;
            this.MK = this.b2;
            this.ML = this.b3;
            this.MX = ((this.a2 * this.b3) * this.b3) + this.a3;
            this.MY = (2 * this.a2) * this.b3;
            this.MI = this.a3;
            this.aa = this.a11;
            this.MfJ = -this.b1;
            this.MZ = (this.b1 * this.b3) - this.b2;
            this.MfL = -this.b3;
            this.TF = this.a1;
            this.MH = this.a2;
            this.F = this.a1;
            this.H = this.a2;
            this.I = this.a3;
            this.keys.Add("Taa", this.TintTostring(this.Taa).ToString());
            this.keys.Add("Mbb", this.MintTostring(this.Mbb).ToString());
            this.keys.Add("Mab", this.MintTostring(this.Mab).ToString());
            this.keys.Add("Mac", this.MintTostring(this.Mac).ToString());
            this.keys.Add("Mbc", this.MintTostring(this.Mbc).ToString());
            this.keys.Add("Mcc", this.MintTostring(this.Mcc).ToString());
            this.keys.Add("TAaa", this.TintTostring(this.TAaa).ToString());
            this.keys.Add("MAbb", this.MintTostring(this.MAbb).ToString());
            this.keys.Add("MAcc", this.MintTostring(this.MAcc).ToString());
            this.keys.Add("MJ", this.MintTostring(this.MJ).ToString());
            this.keys.Add("MK", this.MintTostring(this.MK).ToString());
            this.keys.Add("ML", this.MintTostring(this.ML).ToString());
            this.keys.Add("MX", this.MintTostring(this.MX).ToString());
            this.keys.Add("MY", this.MintTostring(this.MY).ToString());
            this.keys.Add("MI", this.MintTostring(this.MI).ToString());
            this.keys.Add("MfJ", this.MintTostring(this.MfJ).ToString());
            this.keys.Add("MZ", this.MintTostring(this.MZ).ToString());
            this.keys.Add("MfL", this.MintTostring(this.MfL).ToString());
            this.keys.Add("TF", this.TintTostring(this.TF).ToString());
            this.keys.Add("MH", this.MintTostring(this.MH).ToString());
            this.keys.Add("aa", this.aa.ToString());
            this.keys.Add("F", this.F.ToString());
            this.keys.Add("H", this.H.ToString());
            this.keys.Add("I", this.I.ToString());

            string ans = "";
            ans += "(1) f(x1,x2,x3)="+keys["TF"]+"(y1)^2"+ keys["MH"] + "(y2)^2"+ keys["MI"] + "(y3)^2\r\n";
            ans += "(2) x1=" + "y1" + keys["MfJ"] + "y2" + keys["MZ"] + "y3\r\n";
            ans += "    x2=" + "y2" + keys["MfL"] + "y3\r\n";
            ans += "    x3=y3\r\n";

            Console.Write(ans);
        }
    }
}
