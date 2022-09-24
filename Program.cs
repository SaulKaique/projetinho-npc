string npcNOME = "Yosano";
Console.Clear();
string frase = $"Bom Dia\nMeu nome é {npcNOME} você deve ser novo aqui\nQual seu nome?\n";
Console.ForegroundColor = ConsoleColor.DarkGreen;
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);   
Thread.Sleep(75); 
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
frase = "Digite seu nome: ";
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);   
Thread.Sleep(75); 
}
Console.ForegroundColor = ConsoleColor.DarkRed;
string Nome =  Console.ReadLine()!;
Console.ForegroundColor = ConsoleColor.DarkGreen;
frase = $"Então Seu Nome é {Nome}. \nQue nome legal. \n{Nome} esta tudo bem Com você?\n";
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);   
Thread.Sleep(75); 
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
frase = "Fale como você esta com Y (yes) ou N (no) \n";
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);   
Thread.Sleep(75); 
}
Console.ForegroundColor = ConsoleColor.DarkRed;

// YES OU NO (RESPOSTA) ----------------------------

string resposta = Console.ReadLine()!;
Console.ForegroundColor = ConsoleColor.DarkGreen;
int valor = new Random().Next(1,21);
int valor2 = new Random().Next(1,21);
if (resposta.Contains("N") == true) 
{
frase = $"Não ?? que triste se eu podese te daria um abraço voce quer comversar falam que isso ajuda nessas horas.\n";
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);   
Thread.Sleep(75); 
}
}
else if (resposta.Contains("Y") == true)
{
    frase = $"Então vamos brincar, se eu tirar dado maior que o seu você perde :)\n";
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);   
Thread.Sleep(75); 
}
// VALORES DOS DADOS ----------------------------
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    frase = $"{npcNOME} tirou {valor} nos dados.\n";
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);   
Thread.Sleep(75); 
} 
    frase = $"{Nome} tirou {valor2} nos dados.\n";
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);   
Thread.Sleep(75); 
} 

// FRASES DE VITORIAS - PERDAS - EMPATES ----------------------------

Console.ForegroundColor = ConsoleColor.DarkGreen;
if (valor > valor2)
{
    frase = $"{Nome} você perdeu >:)\n";
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);   
Thread.Sleep(75); 
}
}
else if (valor < valor2)
{
    frase = $"{Nome} você ganhou!\n";
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);   
Thread.Sleep(75); 
}
}
else if (valor == valor2)
{
    frase = $"Empate :|\n";
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);   
Thread.Sleep(75); 
}
}
}
Console.ResetColor();








