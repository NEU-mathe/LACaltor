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
    class chapter_Five_7
    {

        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a11 = 0;
        private int a12 = 0;
        private int a13 = 0;
        private int a22 = 0;
        private int a31 = 0;
        private int a32 = 0;
        private int a33 = 0;
        private int aafC = 0;
        private int ab = 0;
        private List<int> b11 = new List<int>();
        private int b12 = 0;
        private int b13 = 0;
        private int b21 = 0;
        private List<int> b22 = new List<int>();
        private int b23 = 0;
        private int b31 = 0;
        private int b32 = 0;
        private int bbfC = 0;
        private int C = 0;
        private List<int> c11 = new List<int>();
        private List<int> c12 = new List<int>();
        private List<int> c22 = new List<int>();
        private int ca = 0;
        private int cb = 0;
        private int ccfC = 0;
        private int Cfaa = 0;
        private int D = 0;
        private int F = 0;
        private int fab = 0;
        private int H = 0;
        private int I = 0;
        private int Mab = 0;
        private int MfC = 0;
        private int Taafd1 = 0;
        private int Tbbfd1 = 0;
        private int Tccfd1 = 0;
        private int TD = 0;
        private int X = 0;
        private int Y = 0;
        private int λ1 = 0;
        private int λ2 = 0;
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

        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_5_7.xml");
            if (isRegeneration)
            {
                this.b11.Add(this.numberTools.myRandom(5));
                this.b22.Add(this.numberTools.myRandom(5));
                this.c11.Add(this.numberTools.myRandom(5));
                this.c12.Add(this.numberTools.myRandom(3));
                this.c22.Add(this.numberTools.myRandom(6));
                if (this.b11[0] == this.b22[0])
                {
                    this.b22[0] = -this.b22[0];
                }
                this.λ1 = this.b11[0];
                this.λ2 = this.b22[0];
                this.a11 = this.c11[0];
                this.a12 = this.c12[0];
                this.a22 = this.c22[0];
                this.a13 = 1;
                this.a33 = (((2 * this.λ1) + this.λ2) - this.a11) - this.a22;
                this.a31 = (this.a11 - this.λ1) * (this.a33 - this.λ1);
                this.a32 = this.a12 * (this.a33 - this.λ1);
                this.C = this.λ1;
                this.D = this.λ2;
                this.X = (this.a11 - this.λ1) * (this.a22 - this.λ1);
                this.Y = this.a22 - this.λ1;
                this.ab = this.a12;
                this.bbfC = this.a22 - this.C;
                this.Cfaa = this.C - this.a11;
                this.fab = -this.a12;
                this.F = this.a12 * (this.a33 - this.λ1);
                this.H = (this.a11 + this.a22) + this.a33;
                this.I = this.λ1 + this.λ2;
                this.MfC = -this.C;
                this.aafC = this.a11 - this.λ1;
                this.ccfC = this.a33 - this.λ1;
                this.ca = this.a31;
                this.cb = this.a32;
                this.TD = this.λ2;
                this.Taafd1 = this.a11 - this.λ1;
                this.Mab = this.a12;
                this.Tbbfd1 = this.a22 - this.λ1;
                this.Tccfd1 = this.a33 - this.λ1;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_5_7.xml");
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
                        else if (node2.Name == "a22")
                        {
                            this.a22 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "λ1")
                        {
                            this.λ1 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "λ2")
                        {
                            this.λ2 = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            this.a13 = 1;
            this.a33 = (((2 * this.λ1) + this.λ2) - this.a11) - this.a22;
            this.a31 = (this.a11 - this.λ1) * (this.a33 - this.λ1);
            this.a32 = this.a12 * (this.a33 - this.λ1);
            this.C = this.λ1;
            this.D = this.λ2;
            this.X = (this.a11 - this.λ1) * (this.a22 - this.λ1);
            this.Y = this.a22 - this.λ1;
            this.ab = this.a12;
            this.bbfC = this.a22 - this.C;
            this.Cfaa = this.C - this.a11;
            this.fab = -this.a12;
            this.F = this.a12 * (this.a33 - this.λ1);
            this.H = (this.a11 + this.a22) + this.a33;
            this.I = this.λ1 + this.λ2;
            this.MfC = -this.C;
            this.aafC = this.a11 - this.λ1;
            this.ccfC = this.a33 - this.λ1;
            this.ca = this.a31;
            this.cb = this.a32;
            this.TD = this.λ2;
            this.Taafd1 = this.a11 - this.λ1;
            this.Mab = this.a12;
            this.Tbbfd1 = this.a22 - this.λ1;
            this.Tccfd1 = this.a33 - this.λ1;
            this.a13 = 1;
            this.a33 = (((2 * this.λ1) + this.λ2) - this.a11) - this.a22;
            this.a31 = (this.a11 - this.λ1) * (this.a33 - this.λ1);
            this.a32 = this.a12 * (this.a33 - this.λ1);
            this.C = this.λ1;
            this.D = this.λ2;
            this.X = (this.a11 - this.λ1) * (this.a22 - this.λ1);
            this.Y = this.a22 - this.λ1;
            this.ab = this.a12;
            this.bbfC = this.a22 - this.C;
            this.Cfaa = this.C - this.a11;
            this.fab = -this.a12;
            this.F = this.a12 * (this.a33 - this.λ1);
            this.H = (this.a11 + this.a22) + this.a33;
            this.I = this.λ1 + this.λ2;
            this.MfC = -this.C;
            this.aafC = this.a11 - this.λ1;
            this.ccfC = this.a33 - this.λ1;
            this.ca = this.a31;
            this.cb = this.a32;
            this.TD = this.λ2;
            this.Taafd1 = this.a11 - this.λ1;
            this.Mab = this.a12;
            this.Tbbfd1 = this.a22 - this.λ1;
            this.Tccfd1 = this.a33 - this.λ1;

            string ans = "";
            ans += "(1) x=";
            ans += X.ToString() + "/" + ab.ToString() + "; ";
            ans += "y=";
            ans += Y.ToString() + "/" + ab.ToString() + "; ";
            ans += "z=";
            ans += λ1.ToString()+";\r\n";
            ans += "(2) P=\r\n";
            //ans += "p11 p13 p12\r\n";
            //ans += "p21 p23 p22\r\n";
            //ans += "p31 p33 p32\r\n";
            //ans += "只要满足" + this.TintTostring(this.Taafd1).ToString() + "p1i" + this.MintTostring(this.Mab).ToString()
            //    + "p2i+p3i=0(i=1或2) 并且 " + this.TintTostring(this.Tbbfd1).ToString() + "p13"
            //    + this.MintTostring(this.Mab).ToString() + "p23=0," + this.TintTostring(this.Tccfd1).ToString() + "p13=p33.\r\n";
            ans += "1 " + ab.ToString()+ " 0\r\n";
            ans += "0 " + bbfC.ToString() + " 1\r\n";
            ans += Cfaa.ToString()+" "+ F.ToString()+" "+ fab.ToString()+"\r\n";
            Console.Write(ans);
        }
    }
}
