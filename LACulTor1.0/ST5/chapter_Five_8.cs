using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
//using System.Windows.Forms;
using System.Xml;
using System.IO;
using test_one;

namespace LACulTor1._0.ST5
{
    class chapter_Five_8
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a = 0;
        private int A = 0;
        private int a11 = 0;
        private int a12 = 0;
        private int a13 = 0;
        private int a22 = 0;
        private int a23 = 0;
        private int a33 = 0;
        private int af1 = 0;
        private int b = 0;
        private int B = 0;
        private int bc = 0;
        private int BD = 0;
        private int Bfa = 0;
        private int Bfaa = 0;
        private int Bfaf1 = 0;
        private int Bfbb = 0;
        private int Bfcc = 0;
        private int c = 0;
        private int C = 0;
        private int F = 0;
        private int fab = 0;
        private int fac = 0;
        private int fb = 0;
        private int fba = 0;
        private int fbc = 0;
        private int fc = 0;
        private int fD = 0;
        private int Mb = 0;
        private int Mc = 0;
        private List<int> O = new List<int>();
        private List<int> S = new List<int>();
        private List<int> T = new List<int>();
        private int Taf1 = 0;
        private int Tb = 0;
        private int Tc = 0;
        private int TfD = 0;
        private int X = 0;
        private int Y = 0;
        private int Z = 0;


        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_5_8.xml");
            if (isRegeneration)
            {
                this.S.Add(this.numberTools.myRandom(6));
                this.O.Add(this.numberTools.myRandom(2));
                this.T.Add(this.numberTools.myRandom(2));
                this.a = this.S[0];
                this.b = this.O[0];
                this.c = this.T[0];
                this.a11 = this.a;
                this.a12 = this.b;
                this.a13 = this.c;
                this.a22 = (this.a + (this.b * this.b)) - 1;
                this.a23 = this.b * this.c;
                this.a33 = (this.a + (this.c * this.c)) - 1;
                this.X = this.a - 1;
                this.Y = (this.a + (this.b * this.b)) + (this.c * this.c);
                this.Mb = this.b;
                this.Mc = this.c;
                this.Tb = this.b;
                this.Tc = this.c;
                this.A = 1 + (this.b * this.b);
                this.B = this.A * ((1 + (this.b * this.b)) + (this.c * this.c));
                this.C = (1 + (this.b * this.b)) + (this.c * this.c);
                this.Bfaa = -this.a11;
                this.fab = -this.a12;
                this.fac = -this.a13;
                this.Bfbb = -this.a22;
                this.fbc = -this.a23;
                this.Bfcc = -this.a33;
                this.Bfa = -this.a;
                this.fb = -this.b;
                this.fc = -this.c;
                this.Taf1 = this.a - 1;
                this.Bfaf1 = -(this.a - 1);
                this.BD = -((this.a + (this.b * this.b)) + (this.c * this.c));
                this.fD = this.Y;
                this.TfD = this.Y;
                this.F = -(1 + (this.b * this.b));
                this.fba = this.a;
                this.bc = this.b * this.c;
                this.Z = 1 + (this.b * this.b);
                this.af1 = this.a - 1;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_5_8.xml");
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
            this.a12 = this.b;
            this.a13 = this.c;
            this.a22 = (this.a + (this.b * this.b)) - 1;
            this.a23 = this.b * this.c;
            this.a33 = (this.a + (this.c * this.c)) - 1;
            this.X = this.a - 1;
            this.Y = (this.a + (this.b * this.b)) + (this.c * this.c);
            this.Mb = this.b;
            this.Mc = this.c;
            this.Tb = this.b;
            this.Tc = this.c;
            this.A = 1 + (this.b * this.b);
            this.B = this.A * ((1 + (this.b * this.b)) + (this.c * this.c));
            this.C = (1 + (this.b * this.b)) + (this.c * this.c);
            this.Bfaa = -this.a11;
            this.fab = -this.a12;
            this.fac = -this.a13;
            this.Bfbb = -this.a22;
            this.fbc = -this.a23;
            this.Bfcc = -this.a33;
            this.Bfa = -this.a;
            this.fb = -this.b;
            this.fc = -this.c;
            this.Taf1 = this.a - 1;
            this.Bfaf1 = -(this.a - 1);
            this.BD = -((this.a + (this.b * this.b)) + (this.c * this.c));
            this.fD = this.Y;
            this.TfD = this.Y;
            this.F = -(1 + (this.b * this.b));
            this.fba = this.a;
            this.bc = this.b * this.c;
            this.Z = 1 + (this.b * this.b);
            this.af1 = this.a - 1;

            string ans = "";
            ans += "(1) λ1=" + X.ToString() + ",λ2=" + X.ToString() + ",λ3=" + Y.ToString() + ";\r\n";

            this.a11 = this.a;
            this.a12 = this.b;
            this.a13 = this.c;
            this.a22 = (this.a + (this.b * this.b)) - 1;
            this.a23 = this.b * this.c;
            this.a33 = (this.a + (this.c * this.c)) - 1;
            this.X = this.a - 1;
            this.Y = (this.a + (this.b * this.b)) + (this.c * this.c);
            this.Mb = this.b;
            this.Mc = this.c;
            this.Tb = this.b;
            this.Tc = this.c;
            this.A = 1 + (this.b * this.b);
            this.B = this.A * ((1 + (this.b * this.b)) + (this.c * this.c));
            this.C = (1 + (this.b * this.b)) + (this.c * this.c);
            this.Bfaa = -this.a11;
            this.fab = -this.a12;
            this.fac = -this.a13;
            this.Bfbb = -this.a22;
            this.fbc = -this.a23;
            this.Bfcc = -this.a33;
            this.Bfa = -this.a;
            this.fb = -this.b;
            this.fc = -this.c;
            this.Taf1 = this.a - 1;
            this.Bfaf1 = -(this.a - 1);
            this.BD = -((this.a + (this.b * this.b)) + (this.c * this.c));
            this.fD = this.Y;
            this.TfD = this.Y;
            this.F = -(1 + (this.b * this.b));
            this.fba = this.a;
            this.bc = this.b * this.c;
            this.Z = 1 + (this.b * this.b);
            this.af1 = this.a - 1;

            ans += "(2) " + "α1=(" + fb.ToString() + ",1,0)\r\n";
            ans += "α2=(" + fc.ToString() + ",0,1)\r\n";
            ans += "α3=(1," + b.ToString() +","+ c.ToString()+")\r\n";
            ans += "(3) Q=\r\n";
            ans +=  b.ToString() + "/sqrt(" + A.ToString() + ") " + c.ToString() + "/sqrt(" + B.ToString() + ") 1/sqrt(" + C.ToString() + ")\r\n";
            ans += "-1" + "/sqrt(" + A.ToString() + ") " + bc.ToString() + "/sqrt(" + B.ToString() + ") " +b.ToString() + "/sqrt("+ C.ToString() + ")\r\n";
            ans += "0 -" + Z.ToString() + "/sqrt(" + B.ToString() + ") " + c.ToString() + "/sqrt(" + C.ToString() + ")\r\n";
            ans += "(4) Q-1AQ=\r\n";
            ans += X.ToString() + " " + "0 0\r\n";
            ans += "0 " + X.ToString() + " 0\r\n";
            ans += "0 0 " + Y.ToString() + "\r\n";

            Console.Write(ans);
            }


    }
}
