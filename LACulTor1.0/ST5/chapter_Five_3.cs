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
    class chapter_Five_3
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a = 0;
        private int A = 0;
        private List<int> a1 = new List<int>();
        private int ab = 0;
        private int abc = 0;
        private int ac = 0;
        private int b = 0;
        private int B = 0;
        private List<int> b1 = new List<int>();
        private int bc = 0;
        private int c = 0;
        private int C = 0;
        private List<int> c1 = new List<int>();
        private int D = 0;
        private int m = 0;
        private int Mfn = 0;
        private int Mm = 0;
        private int n = 0;
        private int Tabc = 0;

        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_5_3.xml");
            if (isRegeneration)
            {
                this.a1.Add(this.numberTools.myRandom(6));
                this.b1.Add(this.numberTools.myRandom(6));
                this.c1.Add(this.numberTools.myRandom(6));
                this.a = this.a1[0];
                this.b = this.b1[0];
                this.c = this.c1[0];
                this.m = this.random.Next(1, 9);
                this.n = this.random.Next(1, 9);
                this.bc = this.b * this.c;
                this.ac = this.a * this.c;
                this.ab = this.a * this.b;
                this.Tabc = (this.a * this.b) * this.c;
                this.abc = (this.a * this.b) * this.c;
                this.Mm = this.m;
                this.Mfn = -this.n;
                this.A = ((((this.a * this.a) + (this.m * this.a)) - this.n) * (((this.b * this.b) + (this.m * this.b)) - this.n)) * (((this.c * this.c) + (this.m * this.c)) - this.n);
                this.B = ((this.a * this.a) + (this.m * this.a)) - this.n;
                this.C = ((this.b * this.b) + (this.m * this.b)) - this.n;
                this.D = ((this.c * this.c) + (this.m * this.c)) - this.n;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_5_3.xml");
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
                        else if (node2.Name == "m")
                        {
                            this.m = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "n")
                        {
                            this.n = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                    this.bc = this.b * this.c;
                    this.ac = this.a * this.c;
                    this.ab = this.a * this.b;
                    this.Tabc = (this.a * this.b) * this.c;
                    this.abc = (this.a * this.b) * this.c;
                    this.Mm = this.m;
                    this.Mfn = -this.n;
                    this.A = ((((this.a * this.a) + (this.m * this.a)) - this.n) * (((this.b * this.b) + (this.m * this.b)) - this.n)) * (((this.c * this.c) + (this.m * this.c)) - this.n);
                    this.B = ((this.a * this.a) + (this.m * this.a)) - this.n;
                    this.C = ((this.b * this.b) + (this.m * this.b)) - this.n;
                    this.D = ((this.c * this.c) + (this.m * this.c)) - this.n;
                    this.bc = this.b * this.c;
                    this.ac = this.a * this.c;
                    this.ab = this.a * this.b;
                    this.Tabc = (this.a * this.b) * this.c;
                    this.abc = (this.a * this.b) * this.c;
                    this.Mm = this.m;
                    this.Mfn = -this.n;
                    this.A = ((((this.a * this.a) + (this.m * this.a)) - this.n) * (((this.b * this.b) + (this.m * this.b)) - this.n)) * (((this.c * this.c) + (this.m * this.c)) - this.n);
                    this.B = ((this.a * this.a) + (this.m * this.a)) - this.n;
                    this.C = ((this.b * this.b) + (this.m * this.b)) - this.n;
                    this.D = ((this.c * this.c) + (this.m * this.c)) - this.n;
                    
                }
                string ans = "";
                ans += "λ1=";
                ans += bc.ToString();
                ans += " ";
                ans += "λ2=";
                ans += ac.ToString();
                ans += " ";
                ans += "λ3=";
                ans += ab.ToString();
                ans += " ";
                ans += "D=";
                ans += (((((this.a * this.a) + (this.m * this.a)) - this.n) * (((this.b * this.b) + (this.m * this.b)) - this.n)) * (((this.c * this.c) + (this.m * this.c)) - this.n)).ToString();
                ans += "\r\n";
                Console.Write(ans);
            }
        }
    }
}
