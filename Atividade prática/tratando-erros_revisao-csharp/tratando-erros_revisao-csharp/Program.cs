//Declaração variáveis globais

int i = 0;
double resultado = 0;


// Funções


double somarValor(double valor)
{
    return resultado += valor;
}

double subtrairValor(double valor)
{
    return resultado -= valor;
}

double dividirValor(double valor)
{
    return resultado /= valor;
}

double multiplicarValor(double valor)
{
    return resultado *= valor;
}

double zerarResultado()
{
    return resultado = 0;
}

double pegarResultadoDaUltimaOperacaoMatematica() 
{
    return resultado;
} 

double definirResultadoDaUltimaOperacaoMatematica() 
    {
    double novoValor;
    Console.WriteLine("Digite novo valor para última operação: ");
    novoValor = Convert.ToDouble(Console.ReadLine());

    resultado = novoValor;

    return resultado;
    }


//Main

while (i == 0)
{
    int opcao;
    Console.WriteLine($"Escola qual operação deseja realizar: \r\n" +
        $"1 - Somar \r\n" +
        $"2 - Subtrair \r\n" +
        $"3 - Divdir \r\n" +
        $"4 - Multiplicar \r\n" +
        $"5 - Zerar o resultado \r\n" +
        $"6 - Recuperar valor da última operação \r\n" +
        $"7 - Definir resultado da última operação \r\n" +
        $"O valor atual é: {resultado}");
    opcao = Convert.ToInt32(Console.ReadLine());

    if (opcao == 1)
    {
        Console.WriteLine("Qual valor deseja somar? ");
        double VALOR = Convert.ToDouble(Console.ReadLine());
        somarValor(VALOR);
    }
    else if (opcao == 2)
    {
        Console.WriteLine("Qual valor deseja subtrair? ");
        double VALOR = Convert.ToDouble(Console.ReadLine());
        subtrairValor(VALOR);
    }
    else if (opcao == 3)
    {
        Console.WriteLine("Qual valor deseja dividir? ");
        double VALOR = Convert.ToDouble(Console.ReadLine());
        dividirValor(VALOR);
    }
    else if (opcao == 4)
    {
        Console.WriteLine("Qual valor deseja multiplicar? ");
        double VALOR = Convert.ToDouble(Console.ReadLine());
        multiplicarValor(VALOR);
    }
    else if (opcao == 5)
    {
        zerarResultado();
    }
    else if (opcao == 6)
    {
        pegarResultadoDaUltimaOperacaoMatematica();
    }
    else
    {
        definirResultadoDaUltimaOperacaoMatematica();
    }

    Console.WriteLine("Deseja continuar na calculadora? Digite 1 para não e 0 para sim: ");
    i = Convert.ToInt32(Console.ReadLine());


}

  

    


