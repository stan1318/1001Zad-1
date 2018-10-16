using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
       public static int Sum(int[] num){
           int sum=num[0];
           for(int i=1;i<7;i++){
               sum=sum+num[i];
           }
           return sum;
       }
    
        static void Main(string[] args)
        {
            int[] nums = new int[7];
           string[] newnums=new string[7];
           Console.WriteLine("Type in the numbers you want to see:");
           newnums = Console.ReadLine().Split();
           for (int i = 0; i < 7; i++)
           { nums[i] = Convert.ToInt32(newnums[i]); }
            

           Console.WriteLine("{0}",Sum(nums));
           Console.ReadLine();

            
        }
       
    }

    }
//Finds The Sum of the 7 inputted numbers
