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

namespace LACulTor1._0.ST3
{
    class chapter_Three_5
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private int a11;
        private int a12;
        private int a13;
        private int a21;
        private int a22;
        private int a23;
        private int a31;
        private int a32;
        private int a33;
        private int m, n, t;
        public void Generate_T(string number, bool isRegeneration)
        {
            this.xmldocument.Load("XML/Cal_3_5.xml");
            if (isRegeneration)
            {
                this.a13 = this.numberTools.myRandom(6);
                this.a23 = this.numberTools.myRandom(6);
                do
                {
                    this.a11 = this.numberTools.myRandom(6);
                    this.a22 = this.numberTools.myRandom(6);
                    this.a12 = this.numberTools.myRandom(6);
                    this.a21 = this.numberTools.myRandom(6);
                }
                while ((this.a11 * this.a22) == (this.a12 * this.a21));
                this.m = this.numberTools.myRandom(5);
                this.n = this.numberTools.myRandom(5);
                this.t = this.random.Next(0, 2);
                this.a31 = (this.a11 * this.m) + (this.a21 * this.n);
                this.a32 = (this.a12 * this.m) + (this.a22 * this.n);
                this.a33 = ((this.a13 * this.m) + (this.a23 * this.n)) + this.t;
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Params_Cal_3_5.xml");
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
                        if (node2.Name == "a23")
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
                        else if (node2.Name == "a33")
                        {
                            this.a33 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "m")
                        {
                            this.m = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "n")
                        {
                            this.n = int.Parse(node2.InnerText);
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
            if (this.t == 0)
            {
                Console.WriteLine("相");
            }
            else if (this.t == 1)
            {
                Console.WriteLine("无");
            }
        }


    }
}
