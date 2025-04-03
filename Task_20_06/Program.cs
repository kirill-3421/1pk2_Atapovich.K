namespace Task_20_06
{
    internal class Program
    {
        /* Создайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
             • Red
             • Yellow
             • Green
           Реализуйте автоматическое переключение цветов (каждые 3 секунды).
           При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep).
           Добавьте возможность ручного переключения (например, по нажатию клавиши)
         */

        
        private static TrafficLightColor startColor = TrafficLightColor.Red;
        private static bool action = true;

        //метод класса - автоматичсекое переклбчение светофора
        static void AutoSwitch()
        {
            while (action)
            {
                switch(startColor)
                {
                    case TrafficLightColor.Red:
                    Console.WriteLine("Светофор - красный");
                    break;

                    case TrafficLightColor.Yellow:
                    Console.WriteLine("Светофор - жёлтый");
                    break;

                    case TrafficLightColor.Green:
                    Console.WriteLine("Светофор - зелёный");
                    break;
                }   
                Thread.Sleep(3000);
            } 
        }

        //метод класса - перключения цветов светофора в ручную
        static void ManualSwitch()
        {
            while (action)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);

                    switch(startColor)
                    {
                        case TrafficLightColor.Red:
                            Console.WriteLine("Переключение с красного на жёлтый:");
                            startColor = TrafficLightColor.Yellow;
                            break;

                        case TrafficLightColor.Yellow:
                            Console.WriteLine("Переключение с жёлтого на зелёный:");
                            startColor = TrafficLightColor.Green;
                            break;

                        case TrafficLightColor.Green:
                            Console.WriteLine("Переключение с зелёного на красный:");
                            startColor = TrafficLightColor.Red;
                            break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Thread autoThead = new Thread(AutoSwitch);
            autoThead.Start();

            ManualSwitch();
            action = false;
            autoThead.Join();
        }
    }
}
