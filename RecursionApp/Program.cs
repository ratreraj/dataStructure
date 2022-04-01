namespace RecursionApp
{

class Program 
{   
   public static void Fun(int n)
    {
        // while(n>0)
        // {
            if(n>0)
            {
            int result = n*n;
            Console. WriteLine($"{result}");
            //n = n-1;
            Fun(n-1);    
            }         
        //}
    }
    static void Main()
    {
        Fun(10);
     
    }


}

}