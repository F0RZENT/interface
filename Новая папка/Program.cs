Console.WriteLine(ImaxMinSpeed.minSpeed);
Console.WriteLine(ImaxMinSpeed.MaxSpeed);
double time = ImaxMinSpeed.GetTime(500, 120);//время
Console.WriteLine(time);

 
interface ImaxMinSpeed
{
    public const int minSpeed = 0; //минимальное скорость
    private static int maxSpeed = 120; //максимальная скорость
    static double GetTime(double distance, double speed) => distance / speed;
    static int MaxSpeed
    {
        get => maxSpeed;
        set
        {
            if (value > 120) maxSpeed = value;
        }
    }
}