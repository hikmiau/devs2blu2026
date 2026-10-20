namespace LivrosApi;

public static class IsbnValidator
{
    /// <summary>Remove hifens/espaços e coloca em maiúsculas.</summary>
    public static string Normalizar(string? isbn) =>
        new string((isbn ?? "").Where(c => char.IsDigit(c) || c is 'X' or 'x').ToArray()).ToUpperInvariant();

    public static bool EhValido(string isbnNormalizado) =>
        isbnNormalizado.Length switch
        {
            10 => ValidarIsbn10(isbnNormalizado),
            13 => ValidarIsbn13(isbnNormalizado),
            _ => false
        };

    private static bool ValidarIsbn10(string s)
    {
        int soma = 0;
        for (int i = 0; i < 10; i++)
        {
            int valor;
            if (s[i] == 'X' && i == 9) valor = 10;
            else if (char.IsDigit(s[i])) valor = s[i] - '0';
            else return false;
            soma += valor * (10 - i);
        }
        return soma % 11 == 0;
    }

    private static bool ValidarIsbn13(string s)
    {
        if (!s.All(char.IsDigit)) return false;
        int soma = 0;
        for (int i = 0; i < 13; i++)
            soma += (s[i] - '0') * (i % 2 == 0 ? 1 : 3);
        return soma % 10 == 0;
    }
}
