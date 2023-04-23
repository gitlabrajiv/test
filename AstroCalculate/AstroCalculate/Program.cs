using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AstroCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strKey = { "A,I,J,Q,Y", "B,K,R", "C,G,L,S", "D,M,T", "E,H,N,X", "U,V,W", "O,Z", "F,P" };

            System.Console.WriteLine("Enter Value : ");
            string strInput = System.Console.ReadLine();
            int sum = 0;
            for(int i = 0; i<strInput.Length;i++)
            {
                for(int j=0;j<strKey.Length;j++)
                {
                    int number;
                    if (!(int.TryParse(strInput[i].ToString(), out number)))
                    {
                        if (strKey[j].Contains(strInput[i].ToString().ToUpper()))
                        {
                            sum += j + 1;
                            break;
                        }
                    }
                    else
                    {
                        sum += Convert.ToInt16(strInput[i].ToString());
                        break;
                    }
                }
            }

            string strSum = sum.ToString();
            int sumofsum = 0;
            for (int i = 0; i < strSum.Length; i++)
            {
                sumofsum += Convert.ToInt16(strSum[i].ToString());
            }
            string a = "Y";
            bool isa = a == "Y" ? true : false;
            Console.WriteLine(isa);
            Console.WriteLine("Output is : " + sumofsum);
            Console.ReadLine();
        }
    }
}
