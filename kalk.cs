
        static void Main(string[] args)
        {
            Console.WriteLine("1 - pole kwadratu, 2 - pole prostokata, 3 - pole trojkata, 4 - pole rownolegloboku, 5 - pole trapezu, 6 - pole kola, 7 - objetosc szescianu,");
            Console.WriteLine("8 - objetosc prostopadloscianu, 9 - objetosc walca, 10 - objetosc kuli, 11 - pole powierzchni szescianu, 12 - pole powierzchni prostopadloscianu, 12 - pole powierzchni walca");
            int inp = int.Parse(Console.ReadLine()); - 1
            switch (inp)
            {
                case 0:
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Pow(a, 2));
                    break;
                case 1:
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(a * b);
                    break;
                case 2:
                    int a = int.Parse(Console.ReadLine());
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine(a * h/2);
                    break;
                case 3:
                    int a = int.Parse(Console.ReadLine());
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine(a * h);
                    break;
                case 4:
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine((a+b)*h/2);
                    break;
                case 5:
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine(Math.PI *Math.Pow(r,2));
                    break;
                case 6:
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Pow(a, 3));
                    break;
                case 7:
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine(a*b*c);
                    break;
                case 8:
                    int r = int.Parse(Console.ReadLine());
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine(Math.PI * Math.Pow(r, 2)* h);
                    break;
                case 9:
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine(Math.PI * Math.Pow(r, 2)*4/3);
                    break;
                case 10:
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a*6);
                    break;
                case 11:
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine(2*a*b+2*b*c+2*a*c);
                    break;
                case 12:
                    int r = int.Parse(Console.ReadLine());
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine(Math.PI * Math.Pow(r, 2)+Math.PI*2*r*h);
                    break;
                
            }
            Console.ReadLine();
        }
    }
}
