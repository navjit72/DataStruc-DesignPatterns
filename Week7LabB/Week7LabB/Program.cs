using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7LabB
{
    class Program
    {
        static Random ran = new Random();
        int userNum;
        List<int[]> numList = new List<int[]>();

        private int[] LoadArrayList()
        {
            List<int> numList = new List<int>();
            int i = 0;
            while(i<6)
            {
                int n = ran.Next(1, 49);
                if(numList.Count==0)
                {
                    numList.Add(n);
                    i++;
                }
                else if (!numList.Contains(n))
                {
                    numList.Add(n);
                    i++;
                }
            }
            numList.Sort();
            return numList.ToArray();
        }

        private List<int[]> GenerateNumbers(int userNum)
        {
            List<int[]> numbers = new List<int[]>();
            numbers.Capacity = userNum;
            int[] num = new int[6];
            for (int i = 0; i < userNum; i++)
            {
                num = LoadArrayList();
                numbers.Add(num);
            }
            return numbers;
        }

        public int[] GenerateWiningNumber()
        {
            List<int> winList = new List<int>();
            int i = 0;
            while (i < 7)
            {
                int n = ran.Next(1, 49);
                if (winList.Count == 0)
                {
                    winList.Add(n);
                    i++;
                }
                else if (!winList.Contains(n))
                {
                    winList.Add(n);
                    i++;
                }
            }
            winList.Sort();
            foreach (int y in winList)
                Console.WriteLine(y);
            return winList.ToArray();
        }

        public void ProcessNumbers()
        {
            int i = 0;
            Console.WriteLine("Enter the number of QuickPick numbers to generate : ");
            string input = Console.ReadLine();
            Int32.TryParse(input, out userNum);
            Console.WriteLine("Your QuickPick numbers are : ");
            numList = GenerateNumbers(userNum);
            while (i < userNum)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(numList[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                i++;
            }
        }

        public string GetReward(int value,int index,int[] winingNum)
        {
            double reward;
            switch(value)
            {
                case 2:
                    {
                        if (numList[index][5] == winingNum[6])
                            return "Congratulations!! You won $5";
                        else
                            return "Sorry better luck next time";
                    }
                case 3:
                    return "Congratulations!! You won $10";
                case 4:
                    {
                        reward = 9 * (0.3);
                        return "Congratulations!! You won " + reward + " million";
                    }
                case 5:
                    {
                        if (numList[index][5] == winingNum[6])
                            reward = 5.75 * (0.3);
                        else
                            reward = 4.75 * (0.3);
                        return "Congratulations!! You won " + reward + " million";
                    }
                case 6:
                    {
                        reward = 80.5 * (0.3);
                        return "Congratulations!! You won " + reward + " million";
                    }
                default:
                    return "Sorry better luck next time";
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Program p = new Program();               
                char c = 'n';                
                while (c == 'n')
                {
                    p.ProcessNumbers();             
                    Console.WriteLine("Do you want to generate winning number? (y/n)");
                    c=Convert.ToChar(Console.ReadLine());
                }

                int[] winNum = p.GenerateWiningNumber();
                int x=0;
                int[] count = new int[p.userNum];
                
                while (x < p.userNum)
                {
                    int z = 0;
                    for (int j = 0; j < 6; j++)
                    {
                      //  Console.WriteLine("NumList : " + p.numList[x][j]);
                        for (int e = 0; e < 6; e++)
                        {
                            if (p.numList[x][j] == winNum[e])
                            {
                              //  Console.WriteLine("Wining number : " + winNum[e]);
                                z++;
                            }
                        }                      
                    }
                    count[x] = z;
                    x++;
                }

                //foreach (int f in count)
                //    Console.WriteLine("count : " + f);
                int max = count.Max(),k=0;
                for (k = 0; k < count.Length; k++)
                {
                    if (count[k] == max)
                        break;
                }
                //Console.WriteLine("Va/*lue k : " + k);
                Console.WriteLine(p.GetReward(max,k,winNum));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Console.Read();
        }
    }
}
