using System;
using System.Collections.Generic;
using System.Xml;
using test_one;

namespace LACulTor1._0.ST7
{
    class chapter_Seven_2
    {
        private XmlDocument xmldocument = new XmlDocument();
        private Random random = new Random();
        private TestGenerateTools numberTools = new TestGenerateTools();

        private Dictionary<string, string> keys = new Dictionary<string, string>();
        private int m = 0;
        private int n = 0;
        private Dictionary<string, string> savestring = new Dictionary<string, string>();
        private string strNum;
        private int λ = 0;
        private int μ = 0;

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
        private string TopintTostring(int intNum)
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
            else if (intNum > 0)
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
        private string intTostring(int intNum)
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
            else if (intNum > 0)
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
            this.xmldocument.Load("XML/Cal_7_2.xml");
            if (isRegeneration)
            {
                while (this.λ == this.μ)
                {
                    this.λ = this.random.Next(1, 4);
                    this.μ = this.random.Next(1, 4);
                }
                while ((this.n == 0) && (this.m == 0))
                {
                    this.n = this.random.Next(0, 2);
                    this.m = this.random.Next(0, 2);
                }
            }
            else
            {
                XmlNode node = LoadXml.LoadShowParameterXml("Parms_Cal_7_2.xml");
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        if (node2.Name == "λ")
                        {
                            this.λ = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "μ")
                        {
                            this.μ = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "n")
                        {
                            this.n = int.Parse(node2.InnerText);
                        }
                        else if (node2.Name == "m")
                        {
                            this.m = int.Parse(node2.InnerText);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("参数有问题");
                    }
                }
            }
            this.savestring.Add("λ", this.λ.ToString());
            this.savestring.Add("μ", this.μ.ToString());
            this.savestring.Add("n", this.n.ToString());
            this.savestring.Add("m", this.m.ToString());
            this.keys.Add("aa", this.λ.ToString());
            this.keys.Add("ab", this.μ.ToString());
            int num = (this.m * this.λ) + (this.n * this.μ);
            this.keys.Add("ac", num.ToString());

            string ans = "";
            int[] vec = { 0, 0, 0 ,0 };
            ++vec[λ];
            ++vec[μ];
            ++vec[num];
            int cnt = 0;
            string tmp = "";
            for (int i=1;i<=3;++i)
            {
                if (vec[i] != 0)
                {
                    ++cnt;
                    tmp += "x" + i.ToString() + " ";
                }
            }
            if(cnt==2)
                ans += "维数是2，一组基是：";
            else
                ans += "维数是3，一组基是：";
            ans += tmp + "\r\n";
           Console.Write(ans);
        }
    }
}
