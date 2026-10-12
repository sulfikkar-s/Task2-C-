class Prime
{
      bool IsPrime=true;

   public void Calculate()
    {
        

        Console.WriteLine("enter a number");
        int Number= int.Parse(Console.ReadLine());
        if(Number<=1) IsPrime=false; 

        for(int i = 2; i <= Number / 2 && IsPrime; i++)
        {
            if (Number % i == 0)
            {
                IsPrime=false;
            }
            
        }
        Console.WriteLine(IsPrime?$"{Number} is prime":$"{Number} is not prime");
        
        
    }
   static public void Main()
    {
        Prime result= new Prime();
        result.Calculate();
        
    }
}
