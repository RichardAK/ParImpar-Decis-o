int numero; 
string parimpar; 

Console.Write("digite seu numero: ");
numero = Convert.ToInt32(Console.ReadLine());

parimpar = (numero % 2) == 0? "par": "ímpar"; 

Console.WriteLine($"{numero} é {parimpar}");