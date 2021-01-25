using System;

namespace assignment_6_coffee_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            drink[] drinks = new drink[10];

            drinks[0] = new drink("coffee", 50);
            drinks[1]= new drink("tea", 45);
            drinks[2] = new drink("juice", 30);
            drinks[3] = new drink("coffee", 50);

            int count = 0;
            for(int i = 0; i < drinks.Length; i++)
            {
                if(drinks[i] != null)
                {
                    count = count + 1;
                }
            }
        }
    }
}
