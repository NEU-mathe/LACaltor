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
    class chapter_Five_2
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
        private int anwser1;
        private int anwser2;
        private int anwser3;

        private int myRandom(int j)
        {
            int minValue = -1 * j;
            int num2 = this.random.Next(minValue, j + 1);
            if (num2 == 0)
            {
                num2 = this.myRandom(j);
            }
            return num2;
        }

        public void Generate_T(string number, bool isRegeneration)
        {
            int num;
            int num2;
            this.xmldocument.Load("XML/Cal_5_2.xml");
            if (isRegeneration)
            {
                this.a11 = this.myRandom(5);
                this.a12 = this.myRandom(5);
                this.a13 = this.myRandom(5);
                this.a21 = this.myRandom(5);
                this.a31 = this.myRandom(5);
                this.a33 = this.myRandom(5);
                if (((this.a12 == -this.a21) || (this.a12 == (this.a33 - this.a11))) || (this.a21 == (this.a11 - this.a33)))
                {
                    this.a12 = 2;
                    this.a21 = 2;
                    this.a33 = 3;
                    this.a11 = 4;
                }
                this.a22 = (this.a11 + this.a12) - this.a21;
                this.a23 = this.a13;
                this.a32 = -this.a31;
                num = ((this.a11 - this.a21) > (this.a11 + this.a12)) ? (this.a11 + this.a12) : (this.a11 - this.a21);
                this.anwser1 = (num > this.a33) ? this.a33 : num;
                num2 = ((this.a11 - this.a21) > (this.a11 + this.a12)) ? (this.a11 - this.a21) : (this.a11 + this.a12);
                this.anwser3 = (num2 > this.a33) ? num2 : this.a33;
                this.anwser2 = (((this.a11 + this.a22) + this.a33) - this.anwser1) - this.anwser3;
            }
            else
            {
                XmlNode node =LoadXml.LoadShowParameterXml("Parms_Cal_5_2.xml");
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
                        else if (node2.Name == "a31")
                        {
                            this.a31 = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "a33")
                        {
                            this.a33 = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
                this.a22 = (this.a11 + this.a12) - this.a21;
                this.a23 = this.a13;
                this.a32 = -this.a31;
                num = ((this.a11 - this.a21) > (this.a11 + this.a12)) ? (this.a11 + this.a12) : (this.a11 - this.a21);
                this.anwser1 = (num > this.a33) ? this.a33 : num;
                num2 = ((this.a11 - this.a21) > (this.a11 + this.a12)) ? (this.a11 - this.a21) : (this.a11 + this.a12);
                this.anwser3 = (num2 > this.a33) ? num2 : this.a33;
                this.anwser2 = (((this.a11 + this.a22) + this.a33) - this.anwser1) - this.anwser3;
                int num3 = ((this.a13 * this.a31) * this.a21) - ((this.a12 * this.a21) * ((this.a11 - this.a21) - this.a33));
                int num4 = (this.a21 * this.a31) * (this.a21 + this.a12);
                int num5 = (this.a21 * ((this.a11 - this.a21) - this.a33)) + (this.a13 * this.a31);
                int num6 = this.a31 * (this.a21 + this.a12);
                int num7 = ((this.a12 * this.a21) * ((this.a11 - this.a21) - this.a33)) - ((this.a13 * this.a31) * this.a21);
                int num8 = this.a21 * ((this.a21 * (this.a33 - (this.a11 - this.a21))) - (this.a13 * this.a31));
                int num9 = (this.a21 * this.a31) * (this.a21 + this.a12);

                string ans = "";
                ans += "λ1=" + anwser1.ToString() + ",λ2=" + anwser2.ToString() + ",λ3=" + anwser3.ToString() + ";\r\n";
                ans += "属于λ="+ (this.a11 - this.a21).ToString()+"的一个特征向量为(" + num7.ToString()+ "," + num8.ToString()+ "," + num9.ToString()+ ")T;\r\n";
                ans += "属于λ=" + (this.a21 + this.a22).ToString() + "的一个特征向量为(1,1,0)T;\r\n";
                ans += "属于λ=" + this.a33.ToString() + "的一个特征向量为(" + a13.ToString() + "," + a13.ToString() + "," + ((a33 - a22) - a21).ToString() + ")T.\r\n";
                Console.Write(ans);
            }

        }
    }
}
