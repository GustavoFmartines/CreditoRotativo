    Double valorFatura;
    Double jurosMensais;
    Double pagamentoMin;
    Double percentualMin;
    Double vnp;
    Double Vprox;
    Double juros;
    Double iof;
    Double custoRotativo;

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkCyan;

Console.WriteLine("--- Crédito Rotativo de Cartão de Crédito ---");

    Console.ResetColor();

Console.Write("Digite o valor da fatura: ");
valorFatura = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o percentual do pagamento minimo: ");
percentualMin = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite a taxa de juros mensais: ");
jurosMensais = Convert.ToDouble(Console.ReadLine()!);

        pagamentoMin = (percentualMin / 100) * valorFatura;
        vnp = valorFatura - pagamentoMin;
        juros = (jurosMensais / 100) * vnp;
        iof = (0.0038 + 0.000082 * 30) * vnp;
        Vprox = vnp + juros + iof;
        custoRotativo = juros + iof;

Console.WriteLine($"Pagamento Mínimo: R${pagamentoMin, 2}");

    Console.ForegroundColor = ConsoleColor.DarkCyan;

Console.WriteLine("Caso seja pago o valor mínimo: ");

    Console.ResetColor();

Console.WriteLine($"Valor não pago: R${vnp, 2}");
Console.WriteLine($"Juros: R${juros, 2}");
Console.WriteLine($"IOF: R${iof, 2}");
Console.WriteLine($"Valor da próxima fatura: R${Vprox:F2}");
Console.WriteLine($"Custo de crédito rotativo: R${custoRotativo:F2}");
