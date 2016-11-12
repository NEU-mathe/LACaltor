namespace test_one
{
    using System;
    using System.Collections.Generic;

    public class TestGenerateTools
    {
        private Random random = new Random();

        public string compare(int i)
        {
            if (i >= 0)
            {
                return ("+" + i.ToString());
            }
            return i.ToString();
        }

        public List<int> Generaterandom(int l, int s, int t)
        {
            int num = this.random.Next(-l + 1, l);
            int num2 = this.random.Next(-s + 1, s);
            int num3 = this.random.Next(-t + 1, t);
            List<int> list = new List<int> {
                2 * num,
                3 * num2,
                6 * num3,
                num,
                num2,
                num3
            };
            if ((list[0] == list[1]) && (list[0] == list[2]))
            {
                list = this.Generaterandom(l, s, t);
            }
            return list;
        }

        public int myRandom(int j)
        {
            int minValue = -1 * j;
            int num2 = this.random.Next(minValue, j + 1);
            if (num2 == 0)
            {
                num2 = this.myRandom(j);
            }
            return num2;
        }
    }
}

