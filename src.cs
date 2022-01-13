using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
       string number_str = Console.ReadLine();
        int N  = Convert.ToInt32(number_str);

       for(int i = 1; i <= N; i++){
            
           int sum = 0;
           int j = i;
           while(j != 0){
               int digit = j%10;
               sum = sum + (digit*digit*digit);
               j = j/10;
           }
            
           if(sum == i){
               Console.WriteLine(i);
           }
       }
    }
}
