Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("+----- Calcular lados do triângulo -----+\n");
Console.ResetColor();
Console.Write("|digite o valor do primeiro lado...: ");
double lado1 = Convert.ToDouble(Console.ReadLine());

Console.Write("|digite o valor do segundo lado...: ");
double lado2 = Convert.ToDouble(Console.ReadLine());

Console.Write("|digite o valor do terceiro lado...: ");
double lado3 = Convert.ToDouble(Console.ReadLine());

double p = (lado1 + lado2 + lado3) / 2;
double area = Math.Sqrt(p * (p - lado1) * (p - lado2) * (p - lado3));

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("+--------------------------------+");
Console.ResetColor();

Console.WriteLine($"\n o valor do semiperímetro é...: {p}");
Console.WriteLine($"o valor da área é igual à...: {area}");