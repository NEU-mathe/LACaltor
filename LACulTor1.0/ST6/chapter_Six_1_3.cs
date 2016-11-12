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

namespace LACulTor1._0.ST6
{
    class chapter_Six_1_3
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a1 = 0;
        private int a11 = 0;
        private int a12 = 0;
        private int a13 = 0;
        private int a1a2 = 0;
        private int a1a2a3 = 0;
        private int a2 = 0;
        private int a22 = 0;
        private int a23 = 0;
        private int a3 = 0;
        private int a33 = 0;
        private int aa = 0;
        private int Aab = 0;
        private int Aac = 0;
        private int Abc = 0;
        private int b1 = 0;
        private int b2 = 0;
        private int b3 = 0;
        private int bb = 0;
        private int cc = 0;
        private Dictionary<string, string> keys = new Dictionary<string, string>();
        private Dictionary<string, string> savestring = new Dictionary<string, string>();
        private string strNum;
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
            this.xmldocument.Load("XML/Cal_6_1_3.xml");
            if (isRegeneration)
            {
                this.a1 = this.random.Next(1, 4);
                this.a2 = this.random.Next(1, 4);
                this.a3 = this.random.Next(1, 4);
                this.b1 = this.random.Next(-2, 3);
                this.b2 = this.random.Next(-2, 3);
                this.b3 = this.random.Next(-2, 3);
                this.a11 = this.a1;
                this.a12 = (2 * this.a1) * this.b1;
                this.a13 = (2 * this.a1) * this.b2;
                this.a22 = ((this.a1 * this.b1) * this.b1) + this.a2;
                this.a23 = 2 * (((this.a1 * this.b1) * this.b2) + (this.a2 * this.b3));
                this.a33 = (((this.a1 * this.b2) * this.b2) + ((this.a2 * this.b3) * this.b3)) + this.a3;
                this.aa = this.a11;
                this.bb = this.a22;
                this.cc = this.a33;
                this.Aab = this.a12 / 2;
                this.Aac = this.a13 / 2;
                this.Abc = this.a23 / 2;
                this.a1a2 = this.a1 * this.a2;
                this.a1a2a3 = (this.a1 * this.a2) * this.a3;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_6_1_3.xml");
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
                        else if (node2.Name == "a3")
                        {
                            this.a3 = int.Parse(node2.InnerText);
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
            this.a33 = (((this.a1 * this.b2) * this.b2) + ((this.a2 * this.b3) * this.b3)) + this.a3;
            this.aa = this.a11;
            this.bb = this.a22;
            this.cc = this.a33;
            this.Aab = this.a12 / 2;
            this.Aac = this.a13 / 2;
            this.Abc = this.a23 / 2;
            this.a1a2 = this.a1 * this.a2;
            this.a1a2a3 = (this.a1 * this.a2) * this.a3;
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
            this.aa = this.a11;
            this.bb = this.a22;
            this.cc = this.a33;
            this.Aab = this.a12 / 2;
            this.Aac = this.a13 / 2;
            this.Abc = this.a23 / 2;
            this.a1a2 = this.a1 * this.a2;
            this.a1a2a3 = (this.a1 * this.a2) * this.a3;
            this.keys.Add("aa", this.aa.ToString());
            this.keys.Add("bb", this.bb.ToString());
            this.keys.Add("cc", this.cc.ToString());
            this.keys.Add("Aab", this.Aab.ToString());
            this.keys.Add("Aac", this.Aac.ToString());
            this.keys.Add("Abc", this.Abc.ToString());
            this.keys.Add("a1a2", this.a1a2.ToString());
            this.keys.Add("a1a2a3", this.a1a2a3.ToString());

            string ans="";
            ans += "(1) A=\r\n";
            ans += keys["aa"]+" "+ keys["Aab"]+" "+ keys["Aac"]+"\r\n";
            ans += keys["Aab"] + " " + keys["bb"] + " " + keys["Abc"] + "\r\n";
            ans += keys["Aac"] + " " + keys["Abc"] + " " + keys["cc"] + "\r\n";
            ans += "(2) 不定\r\n";
            Console.Write(ans);
        }
        

    }
}
