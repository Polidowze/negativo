﻿Console.Clear();

int numero;

void loop(){
Console.WriteLine("__________Como saber se o numero é negativo ou possitivo__________");

Console.WriteLine("Digite seu numero:");
numero = Convert.ToInt32(Console.ReadLine());

if(numero < 0){

Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Seu numero é negativo.");

}

if(numero > 0){

Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Seu numero é positivo.");

}

Console.ResetColor();

 Console.WriteLine("Você quer recomeçar o programa? [S/N]");
    string reposta = Console.ReadLine()!;
    if(reposta.ToUpper() == "S")
    {
    Console.ResetColor();
        loop();
    }
    else{

    }
}
loop();