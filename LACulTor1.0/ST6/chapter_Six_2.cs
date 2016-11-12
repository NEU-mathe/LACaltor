using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST6
{
    class chapter_Six_2
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a11 = 0;
        private int a12 = 0;
        private int a13 = 0;
        private int a21 = 0;
        private int a22 = 0;
        private int a23 = 0;
        private int a31 = 0;
        private int a32 = 0;
        private int a33 = 0;
        private int b1 = 0;
        private int B1 = 0;
        private int b12 = 0;
        private int b13 = 0;
        private int b2 = 0;
        private int B2 = 0;
        private int b21 = 0;
        private int b23 = 0;
        private int b3 = 0;
        private int B3 = 0;
        private int b31 = 0;
        private int b32 = 0;
        private int BfA = 0;
        private int Bfaa = 0;
        private int Bfbb = 0;
        private int Bfcc = 0;
        private int BfX1 = 0;
        private int BfX2 = 0;
        private int BfX3 = 0;
        private int BX1 = 0;
        private int BZ = 0;
        private int fab = 0;
        private int fac = 0;
        private int fbc = 0;
        private int ftbc = 0;
        private int k = 0;
        private List<int> K = new List<int>();
        private Dictionary<string, string> keys = new Dictionary<string, string>();
        private int m = 0;
        private List<int> M = new List<int>();
        private int MfY = 0;
        private int n = 0;
        private List<int> N = new List<int>();
        private int s = 0;
        private Dictionary<string, string> savestring = new Dictionary<string, string>();
        private string strNum;
        private int t = 0;
        private List<int> T = new List<int>();
        private int X1 = 0;
        private int X2 = 0;
        private int X3 = 0;

        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_6_2.xml");
            if (isRegeneration)
            {
                this.K.Add(this.numberTools.myRandom(4));
                this.M.Add(this.numberTools.myRandom(4));
                this.N.Add(this.numberTools.myRandom(4));
                this.T.Add(this.numberTools.myRandom(1));
                this.s = this.random.Next(0, 2);
                this.k = this.K[0];
                this.m = this.M[0];
                this.n = this.N[0];
                this.t = this.T[0];
                this.b1 = ((2 - this.s) * this.t) * this.k;
                this.b2 = ((3 - this.s) * this.t) * this.m;
                this.b3 = ((6 - this.s) * this.t) * this.n;
                this.a11 = (this.k + this.m) + this.n;
                this.a22 = (this.k + this.m) + this.n;
                this.a12 = (this.m + this.n) - this.k;
                this.a21 = (this.m + this.n) - this.k;
                this.a13 = this.m - (2 * this.n);
                this.a31 = this.m - (2 * this.n);
                this.a23 = this.m - (2 * this.n);
                this.a32 = this.m - (2 * this.n);
                this.a33 = this.m + (4 * this.n);
                this.X1 = 2 * this.k;
                this.X2 = 3 * this.m;
                this.X3 = 6 * this.n;
                this.Bfaa = -this.a11;
                this.fab = -this.a12;
                this.fac = this.a13;
                this.Bfbb = -this.a22;
                this.Bfcc = this.a33;
                this.fbc = -this.a23;
                this.BfX1 = -2 * this.k;
                this.BfA = -2 * (this.m + this.n);
                this.BX1 = 2 * this.k;
                this.MfY = -3 * this.m;
                this.BZ = this.X2 * this.X3;
                this.BfX2 = -this.X2;
                this.BfX3 = -this.X3;
                this.B1 = this.b1;
                this.B2 = this.b2;
                this.B3 = this.b3;
                this.ftbc = -2 * this.a23;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_6_2.xml");
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        if (node2.Name == "k")
                        {
                            this.k = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "m")
                        {
                            this.m = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "n")
                        {
                            this.n = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "s")
                        {
                            this.s = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "t")
                        {
                            this.t = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }

            string ans = "";
            if ((this.t == 1) && (this.s == 0))
            {
                ans += "(1) 矩阵A与B是相似的\r\n";
                ans += "(2) 矩阵A与B是合同的\r\n";
            }
            else if ((this.t == 1) && (this.s == 1))
            {
                ans += "(1) 矩阵A与B不是相似的\r\n";
                ans += "(2) 矩阵A与B是合同的\r\n";
            }
            else
            {
                ans += "(1) 矩阵A与B不是相似的\r\n";
                ans += "(2) 矩阵A与B不是合同的\r\n";
            }
            Console.Write(ans);
        }
    }
}
