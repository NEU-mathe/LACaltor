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
    class chapter_Five_5
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a = 0;
        private int A = 0;
        private List<int> a1 = new List<int>();
        private int b = 0;
        private int B = 0;
        private List<int> b1 = new List<int>();
        private int c = 0;
        private int C = 0;
        private List<int> c1 = new List<int>();
        private int k = 0;
        private int m = 0;
        private int Ma = 0;
        private int Mb = 0;
        private int Mc = 0;
        private int Mfa = 0;
        private int Mfb = 0;
        private int Mfc = 0;
        private int n = 0;

        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_5_5.xml");
            if (!isRegeneration)
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_5_5.xml");
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
                        else if (node2.Name == "k")
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
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            while (((((this.a == 0) || (this.b == 0)) || ((this.c == 0) || (this.a == this.b))) || (this.a == this.c)) || (this.b == this.c))
            {
                this.a = this.random.Next(-9, 10);
                this.b = this.random.Next(-9, 10);
                this.c = this.random.Next(-9, 10);
                if (((((this.a != 0) && (this.b != 0)) && ((this.c != 0) && (this.a != this.b))) && (this.a != this.c)) && (this.b != this.c))
                {
                    break;
                }
            }
            this.Ma = -this.a;
            this.Mb = -this.b;
            this.Mc = -this.c;
            this.A = 5 - this.k;
            this.B = 5 - this.m;
            this.C = 5 - this.n;
            this.Mfa = -this.a;
            this.Mfb = -this.b;
            this.Mfc = -this.c;

            string ans = "";
            int cnt = 0;
            for(int i = 0;i < A;++i)
            {
                ++cnt;
                ans += "λ" + cnt.ToString() + "=" + a.ToString();
                if (cnt == 5)
                    ans += ".\r\n";
                else
                    ans += ",";
            }
            for (int i = 0; i < B; ++i)
            {
                ++cnt;
                ans += "λ" + cnt.ToString() + "=" + b.ToString();
                if (cnt == 5)
                    ans += ".\r\n";
                else
                    ans += ",";
            }
            for (int i = 0; i < C; ++i)
            {
                ++cnt;
                ans += "λ" + cnt.ToString() + "=" + c.ToString();
                if (cnt == 5)
                    ans += ".\r\n";
                else
                    ans += ",";
            }

            Console.Write(ans);
        }


    }
}
