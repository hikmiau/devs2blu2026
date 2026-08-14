namespace ArdenaSolucoes.Services.Validacao;

public static class CpfValidator
{
    public static bool EhCpfValido(string cpfInformado)
    {
        string cpfLimpo = ObterApenasNumeros(cpfInformado);

        if (cpfLimpo.Length != 11)
        {
            return false;
        }

        if (cpfLimpo.Distinct().Count() == 1)
        {
            return false;
        }

        int somaDosPrimeirosDigitosVerificadores = 0;
        for (int indice = 0; indice < 9; indice++)
        {
            somaDosPrimeirosDigitosVerificadores += (cpfLimpo[indice] - '0') * (10 - indice);
        }

        int restoDoPrimeiroDigitoVerificador = somaDosPrimeirosDigitosVerificadores % 11;
        int primeiroDigitoVerificador = restoDoPrimeiroDigitoVerificador < 2 ? 0 : 11 - restoDoPrimeiroDigitoVerificador;

        if (primeiroDigitoVerificador != cpfLimpo[9] - '0')
        {
            return false;
        }

        int somaDoSegundoDigitoVerificador = 0;
        for (int indice = 0; indice < 10; indice++)
        {
            somaDoSegundoDigitoVerificador += (cpfLimpo[indice] - '0') * (11 - indice);
        }

        int restoDoSegundoDigitoVerificador = somaDoSegundoDigitoVerificador % 11;
        int segundoDigitoVerificador = restoDoSegundoDigitoVerificador < 2 ? 0 : 11 - restoDoSegundoDigitoVerificador;

        return segundoDigitoVerificador == cpfLimpo[10] - '0';
    }

    public static string ObterApenasNumeros(string valorInformado)
    {
        return new string(valorInformado.Where(char.IsDigit).ToArray());
    }

    public static string FormatarCpf(string cpfInformado)
    {
        string cpfLimpo = ObterApenasNumeros(cpfInformado);

        if (cpfLimpo.Length != 11)
        {
            return cpfLimpo;
        }

        return $"{cpfLimpo[..3]}.{cpfLimpo[3..6]}.{cpfLimpo[6..9]}-{cpfLimpo[9..]}";
    }
}


