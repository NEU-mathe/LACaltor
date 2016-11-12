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
    class chapter_Five_1
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a = 0;
        private List<int> a1 = new List<int>();
        private int a11 = 0;
        private int a12 = 0;
        private int a13 = 0;
        private int a21 = 0;
        private int a22 = 0;
        private int a23 = 0;
        private int a31 = 0;
        private int a32 = 0;
        private int a33 = 0;
        private int b = 0;
        private List<int> b1 = new List<int>();
        private int D = 0;
        private string strNum;
        private int temp1 = 0;
        private int temp2 = 0;
        private int X = 0;
        //private XmlDocument xmldocument = new XmlDocument();
        private int Y = 0;
        private int λ1 = 0;
        private int λ2 = 0;
        private int λ3 = 0;
        private Dictionary<string, string> keys = new Dictionary<string, string>();
        private Dictionary<string, string> savestring = new Dictionary<string, string>();

        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_5_1.xml");
            if (isRegeneration)
            {
                this.a1.Add(this.numberTools.myRandom(3));
                this.b1.Add(this.numberTools.myRandom(6));
                this.a = this.a1[0];
                this.b = this.b1[0];
                if ((6 * this.a) == (2 * this.b))
                {
                    this.a = -this.a;
                }
                this.savestring.Add("a", this.a.ToString());
                this.savestring.Add("b", this.b.ToString());
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_5_1.xml");
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
            this.a12 = -2 * this.a;
            this.a13 = -2 * this.a;
            this.a21 = -2 * this.a;
            this.a31 = -2 * this.a;
            this.a22 = this.a + this.b;
            this.a33 = this.a + this.b;
            this.a23 = this.a - this.b;
            this.a32 = this.a - this.b;
            if (0 < (2 * this.b))
            {
                this.temp1 = 0;
            }
            else
            {
                this.temp1 = 2 * this.b;
            }
            if (this.temp1 < (6 * this.a))
            {
                this.λ1 = this.temp1;
            }
            else
            {
                this.λ1 = 6 * this.a;
            }
            if (0 < (2 * this.b))
            {
                this.temp2 = 2 * this.b;
            }
            else
            {
                this.temp2 = 0;
            }
            if (this.temp2 < (6 * this.a))
            {
                this.λ3 = 6 * this.a;
            }
            else
            {
                this.λ3 = this.temp2;
            }
            this.λ2 = (((2 * this.b) + (6 * this.a)) - this.λ1) - this.λ3;
            this.X = 2 * this.b;
            this.Y = 6 * this.a;
            this.D = this.λ2;

            string ans="";
            ans += "λ1=";
            ans += λ1.ToString();
            ans += " ";
            ans += "λ2=";
            ans += λ2.ToString();
            ans += " ";
            ans += "λ3=";
            ans += λ3.ToString();
            ans += " \r\n";
            ans += "α1=(x,x,x)T,只要x≠0;\r\n";
            ans += "α2=(0,y,-y)T,只要y≠0;\r\n";
            ans += "α3=(-2z,z,z)T,只要z≠0.\r\n";
            Console.Write(ans);
        }
        

    }
}
