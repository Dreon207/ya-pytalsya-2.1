void Beep(int hz)
{
    Console.Beep(hz, 200);
}
int[] Octava(int Octavanumer)//Добавить дефолт не забудь
{
    switch (Octavanumer)
    {
        case 2:
            return new int[] { 130, 138, 146, 196, 207, 220, 233 };
        case 3:
            return new int[] { 261, 277, 293, 392, 415, 440, 466 };
        case 4:
            return new int[] { 523, 554, 587, 784, 830, 880, 932 };
        case 5:
            return new int[] { 1047, 1109, 1175, 1568, 1661, 1760, 1865 };
        case 6:
            return new int[] { 2093, 2217, 2349, 3136, 3322, 3520, 3729 };
        default:
            return new int[] { 65, 69, 73, 98, 103, 110, 116, 123 };
    }
}
    Console.WriteLine("Переключение октав: A,S,D. Звуки: Z,X,C,V,B,N,M");
    while (true)
    {
        int Octavanumer = 0;
        ConsoleKeyInfo octaveke = Console.ReadKey(true);
        switch (octaveke.Key)
        {
            case ConsoleKey.A:
                Octavanumer = 3;
                break;
            case ConsoleKey.S:
                Octavanumer = 1;
                break;
            case ConsoleKey.D:
                Octavanumer = 2;
                break;
            default:
                Console.WriteLine("Такая октава не существует. Выбрана октава 1.");
                break;
        }
        int[] octave = Octava(Octavanumer);
        ConsoleKeyInfo ki = Console.ReadKey(true);
        switch (ki.Key)
        {
            case ConsoleKey.Z:
                Beep(octave[0]);
                break;
            case ConsoleKey.X:
                Beep(octave[1]);
                break;
            case ConsoleKey.C:
                Beep(octave[2]);
                break;
            case ConsoleKey.V:
                Beep(octave[3]);
                break;
            case ConsoleKey.B:
                Beep(octave[4]);
                break;
            case ConsoleKey.N:
                Beep(octave[5]);
                break;
            case ConsoleKey.M:
                Beep(octave[6]);
                break;
            
            default:
                Console.WriteLine("Нет такой клавиши");
                break;
        }
    }