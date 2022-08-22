int FindBiggerDigit (int number)
{
int ed = number % 10;
int dec = number / 10;

int result;

if (ed > dec) result = ed;
else result = dec;

return result;
};

int RandNumber = new Random().Next (10,100);
int biggerDigit = FindBiggerDigit(RandNumber);

Console.WriteLine($"bigger digit of {RandNumber} is {biggerDigit}");

