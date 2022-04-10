double c,f;

Console.Write("Digite uma temperatura em graus F°:");
f = Convert.ToDouble (Console.ReadLine());

c = (f - 32) / 1.8;

Console.WriteLine($"{f:N2}° equivalem a {c:N2}°");