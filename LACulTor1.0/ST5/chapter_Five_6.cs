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
    class chapter_Five_6
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a = 0;
        private int A = 0;
        private List<int> a1 = new List<int>();
        private int a11 = 0;
        private int a12 = 0;
        private int a13 = 0;
        private List<int> a2 = new List<int>();
        private int a21 = 0;
        private int a22 = 0;
        private int a23 = 0;
        private List<int> a3 = new List<int>();
        private int a31 = 0;
        private int a32 = 0;
        private int a33 = 0;
        private int AB = 0;
        private int Aca1 = 1;
        private int b = 0;
        private int B = 0;
        private List<int> b1 = new List<int>();
        private int B1 = 0;
        private int ba = 0;
        private int bafca = 0;
        private int C = 0;
        private int ca = 0;
        private int D = 0;
        private int F = 0;
        private int fA = 0;
        private int fAba = 0;
        private int fAca = 0;
        private int fB = 0;
        private int fba = 0;
        private int fca = 0;
        private int X = 0;
        private int Y = 0;
        private int Z = 0;

        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_5_6.xml");
            if (isRegeneration)
            {
                this.a1.Add(this.numberTools.myRandom(3));
                this.b1.Add(this.numberTools.myRandom(3));
                this.a2.Add(this.numberTools.myRandom(5));
                this.a3.Add(this.numberTools.myRandom(5));
                this.a = this.a1[0];
                this.b = this.b1[0];
                this.a21 = this.a2[0];
                this.a31 = this.a3[0];
                this.a11 = 1;
                this.a12 = this.a + 1;
                this.a22 = ((this.a + 1) * this.a21) + 1;
                this.a32 = ((this.a + 1) * this.a31) + 1;
                this.a13 = (this.a * this.b) + 1;
                this.a23 = (((this.a * this.b) + 1) * this.a21) + this.b;
                this.a33 = ((((this.a * this.b) + 1) * this.a31) + this.b) + 1;
                this.X = 1 + (this.a * this.a21);
                this.Y = this.a21 * (1 + (this.a * this.a21));
                this.Z = this.a31 * this.X;
                this.fA = -this.a;
                this.fAba = -this.a * this.a21;
                this.fAca = -this.a * this.a31;
                this.A = this.a;
                this.Aca1 = (this.a * this.a31) + 1;
                this.AB = this.a * this.b;
                this.C = ((this.a * this.b) * this.a21) + this.b;
                this.D = (((this.a * this.b) * this.a31) + this.b) + 1;
                this.B = this.b;
                this.B1 = this.b + 1;
                this.fba = -this.a21;
                this.fca = -this.a31;
                this.bafca = this.a21 - this.a31;
                this.F = (this.b * this.a31) - ((this.b + 1) * this.a21);
                this.fB = -this.b;
                this.ba = this.a21;
                this.ca = this.a31;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_5_6.xml");
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        if (node2.Name == "a21")
                        {
                            this.a21 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a31")
                        {
                            this.a31 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a11")
                        {
                            this.a11 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a")
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
            this.a12 = this.a + 1;
            this.a22 = ((this.a + 1) * this.a21) + 1;
            this.a32 = ((this.a + 1) * this.a31) + 1;
            this.a13 = (this.a * this.b) + 1;
            this.a23 = (((this.a * this.b) + 1) * this.a21) + this.b;
            this.a33 = ((((this.a * this.b) + 1) * this.a31) + this.b) + 1;
            this.X = 1 + (this.a * this.a21);
            this.Y = this.a21 * (1 + (this.a * this.a21));
            this.Z = this.a31 * this.X;
            this.fA = -this.a;
            this.fAba = -this.a * this.a21;
            this.fAca = -this.a * this.a31;
            this.A = this.a;
            this.Aca1 = (this.a * this.a31) + 1;
            this.AB = this.a * this.b;
            this.C = ((this.a * this.b) * this.a21) + this.b;
            this.D = (((this.a * this.b) * this.a31) + this.b) + 1;
            this.B = this.b;
            this.B1 = this.b + 1;
            this.fba = -this.a21;
            this.fca = -this.a31;
            this.bafca = this.a21 - this.a31;
            this.F = (this.b * this.a31) - ((this.b + 1) * this.a21);
            this.fB = -this.b;
            this.ba = this.a21;
            this.ca = this.a31;

            string ans = "";
            ans += X.ToString() + " " + fA.ToString() + " " + "0\r\n";
            ans += Y.ToString() + " " + fAba.ToString() + " " + "0\r\n";
            ans += Z.ToString() + " " + fAca.ToString() + " " + "0\r\n";
            Console.Write(ans);
        }
    }
}
