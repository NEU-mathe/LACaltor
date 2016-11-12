using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST6
{
    class chapter_Six_3
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
        private int aa = 0;
        private int Aab = 0;
        private int Aac = 0;
        private int Abc = 0;
        private int b = 0;
        private List<int> B = new List<int>();
        private int bb = 0;
        private int Bfaa = 0;
        private int Bfbb = 0;
        private int Bfcc = 0;
        private int BfD = 0;
        private int BfF = 0;
        private int Bfk = 0;
        private int c = 0;
        private List<int> C = new List<int>();
        private int cc = 0;
        private int D = 0;
        private int F = 0;
        private int fAab = 0;
        private int fAac = 0;
        private int fAbc = 0;
        private int fI = 0;
        private int fm = 0;
        private int fn = 0;
        private int I = 0;
        private int J = 0;
        private int K = 0;
        private int m = 0;
        private int Mab = 0;
        private int Mac = 0;
        private int Mb = 0;
        private int Mbb = 0;
        private int Mbc = 0;
        private int Mc = 0;
        private int Mcc = 0;
        private int MD = 0;
        private int MF = 0;
        private int mn = 0;
        private int n = 0;
        private Dictionary<string, string> savestring = new Dictionary<string, string>();
        private Dictionary<string, string> keys = new Dictionary<string, string>();
        private string strNum;
        private int TD = 0;
        private int TF = 0;
        private int Tm = 0;
        private int Tn = 0;

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
            this.xmldocument.Load("XML/Cal_6_3.xml");
            if (isRegeneration)
            {
                this.A.Add(this.numberTools.myRandom(4));
                this.B.Add(this.numberTools.myRandom(4));
                this.C.Add(this.numberTools.myRandom(4));
                this.a = this.A[0];
                this.b = this.B[0];
                this.c = this.C[0];
                this.a11 = this.a;
                this.a22 = (this.a + (this.b * this.b)) - 1;
                this.a33 = (this.a + (this.c * this.c)) - 1;
                this.a12 = 2 * this.b;
                this.a13 = 2 * this.c;
                this.a23 = (2 * this.b) * this.c;
                this.Mbb = this.a22;
                this.Mab = this.a12;
                this.Mac = this.a13;
                this.Mbc = this.a23;
                this.Mcc = this.a33;
                this.D = this.a - 1;
                this.MD = this.a - 1;
                this.F = (this.a + (this.b * this.b)) + (this.c * this.c);
                this.MF = (this.a + (this.b * this.b)) + (this.c * this.c);
                this.TD = this.D;
                this.TF = this.F;
                this.Mb = this.b;
                this.Mc = this.c;
                this.mn = this.b * this.c;
                this.aa = this.a11;
                this.Aab = this.a12 / 2;
                this.Aac = this.a13 / 2;
                this.bb = this.a22;
                this.Abc = this.a23 / 2;
                this.cc = this.a33;
                this.Bfaa = -this.a11;
                this.fAab = -this.a12 / 2;
                this.fAac = -this.a13 / 2;
                this.Bfbb = -this.a22;
                this.fAbc = -this.a23 / 2;
                this.Bfcc = -this.a33;
                this.Bfk = -this.a;
                this.fm = -this.b;
                this.fn = -this.c;
                this.Tm = this.b;
                this.Tn = this.c;
                this.BfD = -this.D;
                this.BfF = -this.F;
                this.m = this.b;
                this.n = this.c;
                this.I = 1 + (this.b * this.b);
                this.fI = -this.I;
                this.K = (1 + (this.b * this.b)) + (this.c * this.c);
                this.J = this.I * this.K;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_6_3.xml");
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
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            this.a11 = this.a;
            this.a22 = (this.a + (this.b * this.b)) - 1;
            this.a33 = (this.a + (this.c * this.c)) - 1;
            this.a12 = 2 * this.b;
            this.a13 = 2 * this.c;
            this.a23 = (2 * this.b) * this.c;
            this.Mbb = this.a22;
            this.Mab = this.a12;
            this.Mac = this.a13;
            this.Mbc = this.a23;
            this.Mcc = this.a33;
            this.D = this.a - 1;
            this.MD = this.a - 1;
            this.F = (this.a + (this.b * this.b)) + (this.c * this.c);
            this.MF = (this.a + (this.b * this.b)) + (this.c * this.c);
            this.TD = this.D;
            this.TF = this.F;
            this.Mb = this.b;
            this.Mc = this.c;
            this.mn = this.b * this.c;
            this.aa = this.a11;
            this.Aab = this.a12 / 2;
            this.Aac = this.a13 / 2;
            this.bb = this.a22;
            this.Abc = this.a23 / 2;
            this.cc = this.a33;
            this.Bfaa = -this.a11;
            this.fAab = -this.a12 / 2;
            this.fAac = -this.a13 / 2;
            this.Bfbb = -this.a22;
            this.fAbc = -this.a23 / 2;
            this.Bfcc = -this.a33;
            this.Bfk = -this.a;
            this.fm = -this.b;
            this.fn = -this.c;
            this.Tm = this.b;
            this.Tn = this.c;
            this.BfD = -this.D;
            this.BfF = -this.F;
            this.m = this.b;
            this.n = this.c;
            this.I = 1 + (this.b * this.b);
            this.fI = -this.I;
            this.K = (1 + (this.b * this.b)) + (this.c * this.c);
            this.J = this.I * this.K;
            this.a11 = this.a;
            this.a22 = (this.a + (this.b * this.b)) - 1;
            this.a33 = (this.a + (this.c * this.c)) - 1;
            this.a12 = 2 * this.b;
            this.a13 = 2 * this.c;
            this.a23 = (2 * this.b) * this.c;
            this.Mbb = this.a22;
            this.Mab = this.a12;
            this.Mac = this.a13;
            this.Mbc = this.a23;
            this.Mcc = this.a33;
            this.D = this.a - 1;
            this.MD = this.a - 1;
            this.F = (this.a + (this.b * this.b)) + (this.c * this.c);
            this.MF = (this.a + (this.b * this.b)) + (this.c * this.c);
            this.TD = this.D;
            this.TF = this.F;
            this.Mb = this.b;
            this.Mc = this.c;
            this.mn = this.b * this.c;
            this.aa = this.a11;
            this.Aab = this.a12 / 2;
            this.Aac = this.a13 / 2;
            this.bb = this.a22;
            this.Abc = this.a23 / 2;
            this.cc = this.a33;
            this.Bfaa = -this.a11;
            this.fAab = -this.a12 / 2;
            this.fAac = -this.a13 / 2;
            this.Bfbb = -this.a22;
            this.fAbc = -this.a23 / 2;
            this.Bfcc = -this.a33;
            this.Bfk = -this.a;
            this.fm = -this.b;
            this.fn = -this.c;
            this.Tm = this.b;
            this.Tn = this.c;
            this.BfD = -this.D;
            this.BfF = -this.F;
            this.m = this.b;
            this.n = this.c;
            this.I = 1 + (this.b * this.b);
            this.fI = -this.I;
            this.K = (1 + (this.b * this.b)) + (this.c * this.c);
            this.J = this.I * this.K;
            this.keys.Add("a", this.a.ToString());
            this.keys.Add("b", this.b.ToString());
            this.keys.Add("c", this.c.ToString());
            this.keys.Add("Mbb", this.MintTostring(this.Mbb).ToString());
            this.keys.Add("Mab", this.MintTostring(this.Mab).ToString());
            this.keys.Add("Mac", this.MintTostring(this.Mac).ToString());
            this.keys.Add("Mbc", this.MintTostring(this.Mbc).ToString());
            this.keys.Add("Mcc", this.MintTostring(this.Mcc).ToString());
            this.keys.Add("D", this.D.ToString());
            this.keys.Add("MD", this.MintTostring(this.MD).ToString());
            this.keys.Add("F", this.F.ToString());
            this.keys.Add("MF", this.MintTostring(this.MF).ToString());
            this.keys.Add("TD", this.TintTostring(this.TD).ToString());
            this.keys.Add("TF", this.TintTostring(this.TF).ToString());
            this.keys.Add("Mb", this.MintTostring(this.Mb).ToString());
            this.keys.Add("Mc", this.MintTostring(this.Mc).ToString());
            this.keys.Add("mn", this.mn.ToString());
            this.keys.Add("aa", this.aa.ToString());
            this.keys.Add("Aab", this.Aab.ToString());
            this.keys.Add("Aac", this.Aac.ToString());
            this.keys.Add("bb", this.bb.ToString());
            this.keys.Add("Abc", this.Abc.ToString());
            this.keys.Add("cc", this.cc.ToString());
            this.keys.Add("Bfaa", this.BintTostring(this.Bfaa).ToString());
            this.keys.Add("fAab", this.fAab.ToString());
            this.keys.Add("fAac", this.fAac.ToString());
            this.keys.Add("Bfbb", this.BintTostring(this.Bfbb).ToString());
            this.keys.Add("fAbc", this.fAbc.ToString());
            this.keys.Add("Bfcc", this.BintTostring(this.Bfcc).ToString());
            this.keys.Add("Bfk", this.BintTostring(this.Bfk).ToString());
            this.keys.Add("fm", this.fm.ToString());
            this.keys.Add("fn", this.fn.ToString());
            this.keys.Add("Tm", this.TintTostring(this.Tm).ToString());
            this.keys.Add("Tn", this.TintTostring(this.Tn).ToString());
            this.keys.Add("BfD", this.BintTostring(this.BfD).ToString());
            this.keys.Add("BfF", this.BintTostring(this.BfF).ToString());
            this.keys.Add("m", this.m.ToString());
            this.keys.Add("n", this.n.ToString());
            this.keys.Add("I", this.I.ToString());
            this.keys.Add("fI", this.fI.ToString());
            this.keys.Add("K", this.K.ToString());
            this.keys.Add("J", this.J.ToString());

            string ans = "";
            ans += "(1) f(x1,x2,x3)=" + keys["TD"]+"(y1)^2"+ keys["MD"] + "(y2)^2" + keys["MF"] + "(y3)^2\r\n";
            ans += "(2) x1="+ "("+keys["m"]+"/sqrt("+ keys["I"]+"))y1+"+ "(" + keys["n"] + "/sqrt(" + keys["J"] + "))y2+" + "(" + "1" + "/sqrt(" + keys["K"] + "))y3\r\n";
            ans += "    x2=" + "(" + "-1" + "/sqrt(" + keys["I"] + "))y1+" + "(" + keys["mn"] + "/sqrt(" + keys["J"] + "))y2+" + "(" + keys["m"] + "/sqrt(" + keys["K"] + "))y3\r\n";
            ans += "    x3=" + "(" +"0"+ ")y1+" + "(-" + keys["I"] + "/sqrt(" + keys["J"] + "))y2+" + "(" + keys["n"] + "/sqrt(" + keys["K"] + "))y3\r\n";

            Console.Write(ans);
        }
    }
}
