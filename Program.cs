﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("salveee");

List<string> listaString = new List<string>();
listaString.Add("salve");
listaString.Add("victor");
listaString.Add("o meor");
listaString.Add("oiiii");
listaString.Add("testee");
listaString.Add("ola mundo");


for (int contador = 0; contador < listaString.Count; contador++)
{
    System.Console.WriteLine($" posicao nº {contador} - {listaString[contador]}");
}

int contadorForeach = 0;

foreach (string item in listaString)
{
    Console.WriteLine($" posicao nº {contadorForeach} - {item}");
 contadorForeach++;
}












// int[] arrayInteiros = new int[4];


// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     System.Console.WriteLine($"posicao nº {contador} - {arrayInteiros[contador]}");
// }


// int contadorForeach = 0;
// foreach (int valor in arrayInteiros)
// {
//    Console.WriteLine($"posicao nº {contadorForeach} - {valor}");
//     contadorForeach++;
// }







// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção");
//     Console.WriteLine("1 - caastrar cliente");
//     Console.WriteLine("2 - buscar cliente");
//     Console.WriteLine("3 - apagar cliente");
//     Console.WriteLine("4 - encerrar");


//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("apagar cliente");
//             break;

//         case "4":
//             Console.WriteLine("encerrar");
//             exibirMenu = false;
//             break;


//         default:
//             Console.WriteLine("opcao invalida");
//             break;
//     }
// }
// Console.WriteLine("o programa se encerrou");























// int soma = 0, numero = 0;

// do
// {


//     System.Console.WriteLine("digite um numero (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;




// } while (numero != 0);

//         Console.WriteLine($"total da soma dos numeros digitados é: {soma}");

// int numero = 99999;
// for (int contador = 99999990; contador <= 10000000; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador }");
// 
