using System;

namespace Sum2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] no=new int[2];
            Console.WriteLine("Enter any 2 positive numbers between which you wants to do addition. 2nd number should be bigger than 1st number:");
            for(int i=0;i<2;i++){
                String userInput=Console.ReadLine();
                no[i]=Convert.ToInt32(userInput);
            }
        
            int sum=Summation(no);
            Console.WriteLine("The summation is:"+sum);
        }
        public static int Summation(int[] no)
        {
            int i=0;
            int sum=0;
            int a=no[i+1]-no[i];
            int b=no[i]-1;
            for(i=0;i<a+1;i++){
                b=b+1;
                sum=sum+b;
            }
            return sum;
        }
    }
}
