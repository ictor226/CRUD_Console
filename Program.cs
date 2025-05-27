// See https://aka.ms/new-console-template for more information
Console.WriteLine("salveee");

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - caastrar cliente");
    Console.WriteLine("2 - buscar cliente");
    Console.WriteLine("3 - apagar cliente");
    Console.WriteLine("4 - encerrar");


    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("busca de cliente");
            break;

        case "3":
            Console.WriteLine("apagar cliente");
            break;

        case "4":
            Console.WriteLine("encerrar");
            exibirMenu = false;
            break;


        default:
            Console.WriteLine("opcao invalida");
            break;
    }
}
Console.WriteLine("o programa se encerrou");























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