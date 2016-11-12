using System;
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

namespace LACulTor1._0.ST4
{
    class chapter_Four_6
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a12;
        private int a13;
        private int a21;
        private int a22;
        private int a23;
        private int a31;
        private int a32;
        private int b1;
        private int b2,m,n;


        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_4_6.xml");
            if (isRegeneration)
            {
                this.a12 = this.numberTools.myRandom(5);
                this.a13 = this.numberTools.myRandom(5);
                this.a21 = this.numberTools.myRandom(5);
                this.a23 = this.numberTools.myRandom(5);
                this.b1 = this.numberTools.myRandom(5);
                this.b2 = this.numberTools.myRandom(5);
                this.m = this.numberTools.myRandom(3);
                this.n = this.numberTools.myRandom(3);
                this.a22 = (this.a12 * this.a21) + 1;
                this.a31 = this.m + (this.a21 * this.n);
                this.a32 = (this.a12 * this.m) + (this.a22 * this.n);
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_4_6.xml");
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        if (node2.Name == "a12")
                        {
                            this.a12 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a13")
                        {
                            this.a13 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a21")
                        {
                            this.a21 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a22")
                        {
                            this.a22 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a23")
                        {
                            this.a23 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a31")
                        {
                            this.a31 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a32")
                        {
                            this.a32 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b1")
                        {
                            this.b1 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "b2")
                        {
                            this.b2 = int.Parse(node2.InnerText);
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

            Console.WriteLine("λ=" + ((this.m * this.a13) + (this.n * this.a23)).ToString());
            Console.WriteLine("μ="+((this.m * this.b1) + (this.n * this.b2)).ToString());
            Console.WriteLine("R(A)=2 R(A|β)=2");
            Console.WriteLine("1 0 " + (this.a13 - (this.a12 * (this.a23 - (this.a21 * this.a13)))).ToString() +" "+ (this.b1 - (this.a12 * (this.b2 - (this.a21 * this.b1)))).ToString());
            Console.WriteLine("0 1 " + (this.a23 - (this.a21 * this.a13)).ToString() + " " + (this.b2 - (this.a21 * this.b1)).ToString());
            Console.WriteLine("0 0 0 0");
            Console.WriteLine("x=(" + (this.b1 - (this.a12 * (this.b2 - (this.a21 * this.b1)))).ToString() + "," + (this.b2 - (this.a21 * this.b1)).ToString() + ",0)T+k("+ ((this.a12 * (this.a23 - (this.a21 * this.a13))) - this.a13).ToString()+","+ ((this.a21 * this.a13) - this.a23).ToString()+"，1)T");

        }


    }
}
