using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public class Student
    {
        public string Name;
        public double MandarinScore;
        public double EnglishScore;
        public double MathScore;
        public string HighestSub;
        public string LowestSub;
        public double TtlScore;
        public double AvgScore;
        
        public void SetStacScore()
        {
            TtlScore = MandarinScore + EnglishScore + MathScore;
            AvgScore = Math.Round(TtlScore / 3,1);
            
        }

        public void RandomScore(int n)
        {
            Random rnd = new Random();
            Name = (n+1).ToString();
            MandarinScore = rnd.Next(1, 100);
            EnglishScore = rnd.Next(1, 100);
            MathScore = rnd.Next(1, 100);
            SetStacScore();
            HL();

    }

        public void HL()
        {
            if (MandarinScore >= EnglishScore)
            {
                if (MandarinScore >= MathScore)
                {
                    HighestSub = "國文"+MandarinScore;
                    LowestSub = (EnglishScore >= MathScore) ? "數學"+MathScore : "英文"+EnglishScore;
                }
                else
                {
                    HighestSub = "數學"+MathScore;
                    LowestSub = "英文"+EnglishScore;
                }
            }
            else if (EnglishScore >= MathScore)
            {
                HighestSub = "英文"+ EnglishScore;
                LowestSub = (MandarinScore >= MathScore) ? "數學" + MathScore : "國文" +MandarinScore;
            }
            else
            {
                HighestSub = "數學"+MathScore;
                LowestSub = "國文"+MandarinScore;
            }
        }
        public bool checkScore(double score)
        {
            if (score >= 0 && score <= 100)
            {
                return true;
            }
            else return false;
        }

    }

    public class ListScore
    {
        public double[] sum = new double[3]; //國.英.數
        public double[] avg = new double[3];
        public double[] max = new double[3];
        public double[] min = { 100,100,100};

        public void ScoreCalculate(List<Student> st)
        {
            foreach(Student item in st)
            {
                sum[0] += item.MandarinScore;
                sum[1] += item.EnglishScore;
                sum[2] += item.MathScore;

                avg[0] = sum[0] / st.Count;
                avg[1] = sum[1] / st.Count;
                avg[2] = sum[2] / st.Count;

                max[0] = (max[0] > item.MandarinScore) ? max[0] : item.MandarinScore;
                max[1] = (max[1] > item.EnglishScore) ? max[1] : item.EnglishScore;
                max[2] = (max[2] > item.MathScore) ? max[2] : item.MathScore;

                min[0] = (min[0] < item.MandarinScore) ? min[0] : item.MandarinScore;
                min[1] = (min[1] < item.EnglishScore) ? min[1] : item.EnglishScore;
                min[2] = (min[2] < item.MathScore) ? min[2] : item.MathScore;
            }
        }

    }

    public class Methods
    {
        public bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else return false;
        }

        public string PrintArray( int[] arr)
        {
            string result = "";
            for(int i  = 0; i < arr.Length -1 ; i++)
            {
                result += $"{arr[i]}, ";
            }
            result += arr[arr.Length-1];
            return result;
        }

        public string PrintArray( string[] arr)
        {
            string result = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                result += $"{arr[i]}, ";
            }
            result += arr[arr.Length-1];
            return result;
        }

        public void NumofOdd(int[] arr, ref int even,ref int odd)
        {
            for(int i = 0;i < arr.Length; i++)
            {
                if (IsEven(arr[i])) even++;
                else odd++;
            }
        }

        public int intArrSum(int[] arr )
        {
            int sum = 0;
            for(int i= 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public int intArrMax(int[] arr)
        {
            int max = arr[0];
            for(int i = 1; i<arr.Length; i++)
            {
                if (arr[i]>max) max = arr[i];
            }
            return max;
        }

        public int intArrMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }

        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public string LongestName(string[] arr, ref int length)
        {
            length = arr[0].Length;
            string result = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i].Length > length)
                {
                    length = arr[i].Length;
                    result = arr[i];
                }
            }
            return result;
        }

        public int ContainsCorc(string[] arr, ref string str)
        {
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains('C') || arr[i].Contains('c'))
                {
                    count++;
                    str += arr[i] + "\n";
                }
            }
            return count;
        }

        public string PrintMatrix(int[,] mat)
        {
            string result = "";
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0;  j < mat.GetLength(1); j++)
                {
                    result += mat[i, j] + " ";
                }
                result += "\n";
            }
            return result;
        }

        public void A1001(ref int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if( ( i == 0 ) || ( i == 9 ) || ( j == 0 ) || ( j == 9 ))
                    {
                        arr[i, j] = 1;
                    }
                    else arr[i,j] = 0;
                }
            }
        }

        public void A0110(ref int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i == 0) || (i == 9) || (j == 0) || (j == 9))
                    {
                        arr[i, j] = 0;
                    }
                    else arr[i, j] = 1;
                }
            }
        }

        public void A1010(ref int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ( IsEven(i) == IsEven(j) )
                    {
                        arr[i, j] = 1;
                    }
                    else arr[i, j] = 0;
                }
            }
        }

        public string BinaryConvert(int dec)
        {
            string dectoBinary = "";
            int remainder;

            while(dec > 0)
            {
                remainder = dec % 2;
                dec /= 2;
                dectoBinary = remainder + dectoBinary;
            }

            return dectoBinary;
        }

        public string XmasTree(int row)
        {
            string result ="";
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    result += "*";
                }
                result += "\n";
            }
            return result;
        }

        public string Print99()
        {
            string result = "九九乘法表\n";
            for(int i = 1; i<=9; i++)
            {
                for( int j = 2; j<=9; j++)
                {
                    if(i*j < 10)
                    {
                        result += $" {j}×{i}＝  {i * j}  | ";
                    }
                    else result += $" {j}×{i}＝{i * j}  | ";
                }
                result += "\n";
            }
            return result;
        }

        public string LotteryRandom()
        {
            Random r = new Random();
            string result = "大樂透號碼：\n";
            int[] Nums = new int[6];
            int count = 0;
            do
            {
                int number = r.Next(1, 49);
                if (Array.IndexOf(Nums, number) < 0)
                    Nums[count++] = number;
            } while (count < 6);

            result += PrintArray(Nums) +"\n由小到大排序：\n";
            Array.Sort(Nums);
            return result + PrintArray(Nums);
        }

        public int ForSum(int f, int t, int s)
        {
            int sum = 0;
            for( int i = f; i <= t; i += s )
            {
                sum += i;
            }
            return sum;
        }

        public int DoSum(int f, int t, int s)
        {
            int sum = 0;
            do
            {
                sum += f;
                f += s;
            } while (f <= t);
            return sum;
        }

        public int WhileSum(int f, int t, int s)
        {
            int sum = 0;
            while (f <= t)
            {
                sum += f;
                f += s;
            }
            return sum;
        }


    }
    
    
}

