using System;

namespace percen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //ฝากเงินมากกว่า 5000/20
            //ฝากเงินมากกว่า 2000/10
            //ฝากเงินน้อยกกว่า 2000/5
            //(n/100)*percen
            double percentage;
            Console.WriteLine("Plz input money : ");
            double money = Convert.ToDouble(Console.ReadLine());
            if(money>5000)
            {
                percentage = (money / 100) * 20;
            }else if (money > 2000)
            {
                percentage = (money / 100) * 10;
            }
            else
            {
                percentage = (money / 100) * 5;
            }

            Console.WriteLine("interest is : " + percentage);  

        }
    }
}
