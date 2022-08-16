int friend = 1,
    Speed1Friend = 5,
    Speed2Friend = 4,
    DogSpeed = 10,
    Smin = 5,
    count = 0;
double S = 100, time;

while (S > Smin)
{
    if (friend == 1)
    {
        time = S / (DogSpeed + Speed2Friend);
        friend = 2;
    }
    else
    {
        time = S / (DogSpeed + Speed1Friend);
        friend = 1;
    }
    S = S - (Speed1Friend + Speed2Friend) * time;
    count++;
}

Console.Write("Собака пробежала ");
Console.Write(count);
Console.WriteLine(" раз(а).");

Console.Write("Оставалось  ");
Console.Write(S);
Console.WriteLine(" метров.");