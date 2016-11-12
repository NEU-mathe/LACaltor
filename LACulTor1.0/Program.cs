using LACulTor1._0.ST2;
using LACulTor1._0.ST3;
using LACulTor1._0.ST4;
using LACulTor1._0.ST5;
using LACulTor1._0.ST6;
using LACulTor1._0.ST7;
using System;
using System.IO;
using System.Windows.Forms;


namespace LACulTor1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || ( args[0] != "-realTestorLaunch" && args[0] != "-realWelcomeLaunch"))
            {
                MessageBox.Show("程序被非法执行！", "Warning");
                Console.Write("咒语");
                string iAbracadabra = Console.ReadLine();
                if (iAbracadabra != "coolyou")
                    while(true)
                    {
                        Console.Write("呵呵哒呵呵哒呵呵哒哈哈");
                    }
                Console.Clear();
            }

            if (args.Length == 0 || args[0] != "-realTestorLaunch")
            {
                //Welcome
                Console.WriteLine("欢迎。此版本的使用范围：三四五六七章。");
                if(args.Length != 0 && args[0] == "-realWelcomeLaunch")
                    return;
            }

            //Read ParameterXml until completely loaded
            string[] fn;
            string path;
            if (args.Length == 2)
                path = args[1] + "ParameterXml";
            else
                path = "ParameterXml";
            do { fn = Directory.GetFiles(path); }
            while (fn.Length < 12);

            char[] separator = { '\\', '_', '.' };

            int chapter = 0; // chapter number
            double[] cal = new double[6]; // Q No.
            int count = 0; // Q in total

            foreach (string s in fn)
            {
                string tmp;
                if (args.Length == 2)
                    tmp = s.Substring(args[1].Length);
                else
                    tmp = s;
               // Console.WriteLine(tmp);
                string[] name = tmp.Split(separator);
                //name[0] ParameterXml
                //name[1] Params
                //name[2] Cal
                //name[3] {chapter}
                //name[4] {Q No.}
                //name[5] xml || {Q No..}
                //name[6] xml
                if (name[2] == "Cal")
                {
                    chapter = int.Parse(name[3]);
                    if (name.Length == 6)
                    {
                        cal[count] = double.Parse(name[4]);
                        ++count;
                    }
                    else if (name.Length == 7)
                    {
                        cal[count] = double.Parse(name[4]) + double.Parse(name[5]) * 0.1;
                        ++count;
                    }
                }
            }

            Array.Sort(cal);
            for (int i = 0; i < count; ++i)
            {
                Console.WriteLine("第{0}题的答案是：", i + 7);

                if (chapter == 2)
                {
                    switch ("2_" + Convert.ToString(cal[i]).Replace(".", "_") + ".xml")
                    {
                        case "2_5_2.xml":
                            chapter_Two_5_2 item5_2 = new chapter_Two_5_2();
                            item5_2.Generate_T("1", false);
                            break;
                    }

                }
                else if (chapter == 3)
                {
                    switch ("3_" + Convert.ToString(cal[i]).Replace(".", "_") + ".xml")
                    {
                        case "3_1.xml":
                            chapter_Three_1 item1 = new chapter_Three_1();
                            item1.Generate_T("1", false);
                            break;
                        case "3_2.xml":
                            chapter_Three_2 item2 = new chapter_Three_2();
                            item2.Generate_T("1", false);
                            break;
                        case "3_3.xml":
                            chapter_Three_3 item3 = new chapter_Three_3();
                            item3.Generate_T("1", false);
                            break;
                        case "3_4.xml":
                            chapter_Three_4 item4 = new chapter_Three_4();
                            item4.Generate_T("1", false);
                            break;
                        case "3_5.xml":
                            chapter_Three_5 item5 = new chapter_Three_5();
                            item5.Generate_T("1", false);
                            break;
                        case "3_6.xml":
                            chapter_Three_6 item6 = new chapter_Three_6();
                            item6.Generate_T("1", false);
                            break;
                        case "3_7.xml":
                            chapter_Three_7 item7 = new chapter_Three_7();
                            item7.Generate_T("1", false);
                            break;
                        case "3_8.xml":
                            chapter_Three_8 item8 = new chapter_Three_8();
                            item8.Generate_T("1", false);
                            break;
                        case "3_9.xml":
                            chapter_Three_9 item9 = new chapter_Three_9();
                            item9.Generate_T("1", false);
                            break;
                        case "3_10.xml":
                            chapter_Three_10 item10 = new chapter_Three_10();
                            item10.Generate_T("1", false);
                            break;
                        case "3_11.xml":
                            chapter_Three_11 item11 = new chapter_Three_11();
                            item11.Generate_T("1", false);
                            break;
                    }
                }
                else if (chapter == 4)
                {
                    switch ("4_" + Convert.ToString(cal[i]).Replace(".", "_") + ".xml")
                    {
                        case "4_1.xml":
                            chapter_Four_1 item1 = new chapter_Four_1();
                            item1.Generate_T("1", false);
                            break;
                        case "4_2.xml":
                            chapter_Four_2 item2 = new chapter_Four_2();
                            item2.Generate_T("1", false);
                            break;
                        case "4_3_1.xml":
                            chapter_Four_3_1 item3_1 = new chapter_Four_3_1();
                            item3_1.Generate_T("1", false);
                            break;
                        case "4_3_2.xml":
                            chapter_Four_3_2 item3_2 = new chapter_Four_3_2();
                            item3_2.Generate_T("1", false);
                            break;
                        case "4_3_3.xml":
                            chapter_Four_3_3 item3_3 = new chapter_Four_3_3();
                            item3_3.Generate_T("1", false);
                            break;
                        case "4_4.xml":
                            chapter_Four_4 item4 = new chapter_Four_4();
                            item4.Generate_T("1", false);
                            break;
                        case "4_5_1.xml":
                            chapter_Four_5_1 item5_1 = new chapter_Four_5_1();
                            item5_1.Generate_T("1", false);
                            break;
                        case "4_5_2.xml":
                            chapter_Four_5_2 item5_2 = new chapter_Four_5_2();
                            item5_2.Generate_T("1", false);
                            break;
                        case "4_6.xml":
                            chapter_Four_6 item6 = new chapter_Four_6();
                            item6.Generate_T("1", false);
                            break;
                        case "4_7.xml":
                            chapter_Four_7 item7 = new chapter_Four_7();
                            item7.Generate_T("1", false);
                            break;
                        case "4_8.xml":
                            chapter_Four_8 item8 = new chapter_Four_8();
                            item8.Generate_T("1", false);
                            break;
                    }
                }
                else if (chapter == 5)
                {
                    switch ("5_" + Convert.ToString(cal[i]).Replace(".", "_") + ".xml")
                    {
                        case "5_1.xml":
                            chapter_Five_1 item1 = new chapter_Five_1();
                            item1.Generate_T("1", false);
                            break;
                        case "5_2.xml":
                            chapter_Five_2 item2 = new chapter_Five_2();
                            item2.Generate_T("1", false);
                            break;
                        case "5_3.xml":
                            chapter_Five_3 item3 = new chapter_Five_3();
                            item3.Generate_T("1", false);
                            break;
                        case "5_4.xml":
                            chapter_Five_4 item4 = new chapter_Five_4();
                            item4.Generate_T("1", false);
                            break;
                        case "5_5.xml":
                            chapter_Five_5 item5 = new chapter_Five_5();
                            item5.Generate_T("1", false);
                            break;
                        case "5_6.xml":
                            chapter_Five_6 item6 = new chapter_Five_6();
                            item6.Generate_T("1", false);
                            break;
                        case "5_7.xml":
                            chapter_Five_7 item7 = new chapter_Five_7();
                            item7.Generate_T("1", false);
                            break;
                        case "5_8.xml":
                            chapter_Five_8 item8 = new chapter_Five_8();
                            item8.Generate_T("1", false);
                            break;

                    }
                }
                else if (chapter == 6)
                {
                    switch ("6_" + Convert.ToString(cal[i]).Replace(".", "_") + ".xml")
                    {
                        case "6_1_1.xml":
                            chapter_Six_1_1 item11 = new chapter_Six_1_1();
                            item11.Generate_T("1", false);
                            break;
                        case "6_1_2.xml":
                            chapter_Six_1_2 item12 = new chapter_Six_1_2();
                            item12.Generate_T("1", false);
                            break;
                        case "6_1_3.xml":
                            chapter_Six_1_3 item13 = new chapter_Six_1_3();
                            item13.Generate_T("1", false);
                            break;
                        case "6_2.xml":
                            chapter_Six_2 item2 = new chapter_Six_2();
                            item2.Generate_T("1", false);
                            break;
                        case "6_3.xml":
                            chapter_Six_3 item3 = new chapter_Six_3();
                            item3.Generate_T("1", false);
                            break;
                        case "6_4.xml":
                            chapter_Six_4 item4 = new chapter_Six_4();
                            item4.Generate_T("1", false);
                            break;
                        case "6_5.xml":
                            chapter_Six_5 item5 = new chapter_Six_5();
                            item5.Generate_T("1", false);
                            break;
                        case "6_6.xml":
                            chapter_Six_6 item6 = new chapter_Six_6();
                            item6.Generate_T("1", false);
                            break;
                    }
                }
                else if (chapter == 7)
                {
                    switch ("7_" + Convert.ToString(cal[i]).Replace(".", "_") + ".xml")
                    {
                        case "7_1.xml":
                            chapter_Seven_1 item1 = new chapter_Seven_1();
                            item1.Generate_T("1", false);
                            break;
                        case "7_2.xml":
                            chapter_Seven_2 item2 = new chapter_Seven_2();
                            item2.Generate_T("1", false);
                            break;
                        case "7_3.xml":
                            chapter_Seven_3 item3 = new chapter_Seven_3();
                            item3.Generate_T("1", false);
                            break;
                        case "7_4.xml":
                            chapter_Seven_4 item4 = new chapter_Seven_4();
                            item4.Generate_T("1", false);
                            break;
                        case "7_5_1.xml":
                            chapter_Seven_5_1 item51 = new chapter_Seven_5_1();
                            item51.Generate_T("1", false);
                            break;
                        case "7_5_2.xml":
                            chapter_Seven_5_2 item52 = new chapter_Seven_5_2();
                            item52.Generate_T("1", false);
                            break;
                        case "7_5_3.xml":
                            chapter_Seven_5_3 item53 = new chapter_Seven_5_3();
                            item53.Generate_T("1", false);
                            break;
                        case "7_6.xml":
                            chapter_Seven_6 item6 = new chapter_Seven_6();
                            item6.Generate_T("1", false);
                            break;
                        case "7_7.xml":
                            chapter_Seven_7 item7 = new chapter_Seven_7();
                            item7.Generate_T("1", false);
                            break;
                        case "7_8.xml":
                            chapter_Seven_8 item8 = new chapter_Seven_8();
                            item8.Generate_T("1", false);
                            break;
                        case "7_9.xml":
                            chapter_Seven_9 item9 = new chapter_Seven_9();
                            item9.Generate_T("1", false);
                            break;
                        case "7_10.xml":
                            chapter_Seven_10 item10 = new chapter_Seven_10();
                            item10.Generate_T("1", false);
                            break;
                    }
                }
            }

            //Reminder
            if (chapter == 3)
            {
                Console.WriteLine("如果一个空的答案为“-”，应当填写为“-1”；答案为“+”，应当填写为“1”。");
            }
            Console.WriteLine("请仔细检查。");

            if (args.Length == 0 || args[0] != "-realTestorLaunch")
            {
                Console.ReadKey(true);
            }

        }
    }
}
