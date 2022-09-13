Console.WriteLine("Введите координату Х точки А");
string koordAX = Console.ReadLine();
int AX = int.Parse(koordAX);

Console.WriteLine("Введите координату Y точки А");
string koordAY = Console.ReadLine();
int AY = int.Parse(koordAY);

Console.WriteLine("Введите координату Z точки А");
string koordAZ = Console.ReadLine();
int AZ = int.Parse(koordAZ);

Console.WriteLine("Введите координату Х точки B");
string koordBX = Console.ReadLine();
int BX = int.Parse(koordBX);

Console.WriteLine("Введите координату Y точки B");
string koordBY = Console.ReadLine();
int BY = int.Parse(koordBY);

Console.WriteLine("Введите координату Z точки B");
string koordBZ = Console.ReadLine();
int BZ = int.Parse(koordBZ);

/*
Не могу понять почему это возведение в квадрат не работает

int xKv = Math.Pow((BX - AX), 2);
int yKv = Math.Pow((BY - AY), 2);
int zKv = Math.Pow((BZ - AZ), 2);
*/


int xKv = (BX - AX)*(BX - AX);
int yKv = (BY - AY)*(BY - AY);
int zKv = (BZ - AZ)*(BZ - AZ);

double Rasston = Math.Sqrt(xKv + yKv + zKv);

Console.WriteLine(Rasston);
