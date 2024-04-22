using System.ComponentModel.Design;

decimal n1 = 0, n2 = 0, n3 = 0, n4 = 0;
int op = 0;
bool control = false;
decimal resultado = 0;


do
{
    do
    {


        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");
        op = int.Parse(Console.ReadLine());
    } while (op < 1 || op >5);

    Console.WriteLine("Digite o valor do primeiro numero:");
    n1 = decimal.Parse(Console.ReadLine());

    do
    {
        Console.WriteLine("Digite o valor do segundo numero( se divisão digitar diferente de 0):");
        n2 = decimal.Parse(Console.ReadLine());
        if (op == 4)
        {
            if (n2 != 0)
            {
                control = true;
            }
            else
            {
                control = false;
            }
        }
        else
        {
            control = true;
        }
    } while ( control == false);

    control = false;

    while (control == false)
    {
        Console.WriteLine("Digite o valor do terceiro numero( se divisão digitar diferente de 0):");
        n3 = decimal.Parse(Console.ReadLine());
        if (op == 4)
        {
            if (n3 != 0)
            {
                control = true;
            }
            else
            {
                control = false;
            }
        }
        else
        {
            control = true;
        }
    }

    for (control = false; control == true;)
    {
        Console.WriteLine("Digite o valor do quarto numero( se divisão digitar diferente de 0):");
        n4 = decimal.Parse(Console.ReadLine());
        if (op == 4)
        {
            if (n4 != 0)
            {
                control = true;
            }
            else
            {
                control = false;
            }
        }
        else
        {
            control = true;
        }
    }


    switch (op)
    {
        case 1:
            resultado = n1 + n2 + n3 + n4;
            break;
        case 2:
            resultado = n1 - n2 - n3 - n4;
        break;
        case 3:
            resultado = n1 * n2 * n3 * n4;
         break ;
        case 4:
            resultado = n1 / n2 / n3 / n4;
         break;
        default:
            break;
    }

    Console.WriteLine($"Resultado: {resultado} ");

} while (op != 5);
