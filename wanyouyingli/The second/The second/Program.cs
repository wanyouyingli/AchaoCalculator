using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_second
{
    class Program
    {
        class wanyouyinli
        {
            public wanyouyinli() { }
            public void input()
            {
                Random ran = new Random();
                char[] mark = { '+', '-', '*', '/' };
                Console.WriteLine("输入想得到几组数据");
                int input = int.Parse(Console.ReadLine());
                List<string> pro = new List<string>();
                for (int i = 1; i <= input; i++)
                {
                    while (true)
                    {
                        int ranA = ran.Next(0, 100);
                        int ranB = ran.Next(0, 100);
                        int ranC = ran.Next(0, 100);
                        int ranD = ran.Next(0, 100);
                        int marknumber = (ran.Next(2, 4));
                        if (marknumber == 2)
                        {
                            char op1 = mark[ran.Next(0, 4)], op2 = mark[ran.Next(0, 4)];
                            string str = ranA.ToString() + op1 + ranB.ToString() + op2 + ranC.ToString();
                            DataTable dataTable = new DataTable();
                            double ans = Convert.ToDouble(dataTable.Compute(str, "false"));
                            if (ans == (int)ans)
                            {
                                Console.WriteLine(str + "=");
                                pro.Add(str + "=" + ((int)ans).ToString());
                                break;
                            }
                        }
                        else if (marknumber == 3)
                        {
                            char op1 = mark[ran.Next(0, 4)], op2 = mark[ran.Next(0, 4)], op3 = mark[ran.Next(0, 4)];
                            string str = ranA.ToString() + op1 + ranB.ToString() + op2 + ranC.ToString() + op3 + ranD.ToString();
                            DataTable dataTable = new DataTable();
                            double ans = Convert.ToDouble(dataTable.Compute(str, "false"));
                            if (ans == (int)ans)
                            {
                                Console.WriteLine(str + "=");
                                pro.Add(str + "=" + ((int)ans).ToString());
                                break;
                            }
                        }
                    }
                }
                //print to file
                StreamWriter sw = new StreamWriter(@".\subject.txt", false, Encoding.UTF8);
                for (int i = 0; i < pro.Count(); ++i)
                {
                    sw.WriteLine(pro[i]);
                }
                sw.Close();
            }
        }
        static void Main(string[] args)
        {
            wanyouyinli wanyouyinli = new wanyouyinli();
            wanyouyinli.input();
        }
    }
}
