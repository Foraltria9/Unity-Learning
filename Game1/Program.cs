namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("가위는0 바위는 1 보는 2");
            //가위0，바위1，보2
            Random rand = new Random();
            int aiChoice = rand.Next(0, 3);//AI 랜덤 숫자 선택
            
            int manChoice = Convert.ToInt32(Console.ReadLine());

            switch (manChoice)
            {
                case 0:
                    Console.WriteLine("당신은 가위를 선택");                
                    break;
                case 1:
                    Console.WriteLine("당신은 바위를 선택");
                    break;
                case 2:
                    Console.WriteLine("당신은 보를 선택");
                    break;
            }

            switch (aiChoice)
            {
                case 0:
                    Console.WriteLine("AI는 가위를 선택");
                    break;
                case 1:
                    Console.WriteLine("AI는 바위를 선택");
                    break;
                case 2:
                    Console.WriteLine("AI는 보를 선택");
                    break;
            }

            //结果
            if(manChoice == aiChoice)
            {
                Console.WriteLine("무승부");
            }

            else if(manChoice == 0 && aiChoice==2)
            {
                Console.WriteLine("승리");
            }

            else if (manChoice == 1 && aiChoice == 0)
            {
                Console.WriteLine("승리");
            }

            else if (manChoice == 2 && aiChoice == 1)
            {
                Console.WriteLine("승리");
            }

            else
            {
                Console.WriteLine("실패");
            }

        }
    }
}
