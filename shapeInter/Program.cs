namespace shapeInter
{
    internal class Program
    {
        public static void  result()
        {
            Console.WriteLine("for triangel enter 1 : for rectangel enter 2 :for paralleleepiped enter 3  ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    int firstSide;
                    int secondSide;
                    int thirdSide;
                    Console.WriteLine("enter 1 side of triangel");
                    if(int.TryParse(Console.ReadLine(), out firstSide))
                    {
                        Console.WriteLine("enter 2 side of triangel");
                        if (int.TryParse(Console.ReadLine(), out secondSide))
                        {
                            Console.WriteLine("enter 3 side of triangel");
                            if (int.TryParse(Console.ReadLine(), out thirdSide))
                            {
                                Console.WriteLine("For Parametr enter P:for Area enter S");
                                string calc = Console.ReadLine();
                                if(calc.ToLower() == "p")
                                {
                                    IPerimetr p = new Triangel(firstSide, secondSide, thirdSide);
                                    Console.WriteLine(p.CalcPerimetr());
                                }
                                else if(calc.ToLower() == "s")
                                {
                                    IArea s = new Triangel(firstSide, secondSide, thirdSide);
                                    Console.WriteLine(s.CalcArea());
                                }
                                

                            }
                        }
                    }
                    break;
                case "2":
                    double length;
                    double weight;

                    Console.WriteLine(  "enter weight for rectangle");
                    if (double.TryParse(Console.ReadLine(), out weight))
                    {
                        Console.WriteLine("enter length for rectangle");
                        if (double.TryParse(Console.ReadLine(), out length))
                        {
                            Console.WriteLine("For Parametr enter P:for Area enter S");
                            string calc = Console.ReadLine();
                            if (calc.ToLower() == "p")
                            {
                                IPerimetr p = new Rectangle(length, weight);
                                Console.WriteLine(p.CalcPerimetr());
                            }
                            else if (calc.ToLower() == "s")
                            {
                                IArea s = new Rectangle(length, weight);
                                Console.WriteLine(s.CalcArea());
                            }
                        }

                    }

                        break;
                case "3":
                    double height;
                    Console.WriteLine("enter weight for paralleleepiped");
                    if (double.TryParse(Console.ReadLine(), out weight))
                    {
                        Console.WriteLine("enter length for paralleleepiped");
                        if (double.TryParse(Console.ReadLine(), out length))
                        {
                            Console.WriteLine("enter height for paralleleepiped");
                            if (double.TryParse(Console.ReadLine(), out height))
                            {
                                IVolume v = new Parallelepiped(length, weight, height);
                                Console.WriteLine($"V = {v.CalcVolume()}");  
                            }
                        }
                    }

                            break;
                default:
                    break;
            }

        }
        static void Main(string[] args)
        {
            //IPerimetr p = new Triangel(3, 4, 5);
            //Console.WriteLine(p.CalcPerimetr());
            //IArea s = new Triangel(3, 4, 5);
            //Console.WriteLine(s.CalcArea());

            
            result();

        }
    }
}
