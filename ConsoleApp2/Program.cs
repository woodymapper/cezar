Console.WriteLine("Przesunięcie");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Hasło");
char[] c = Console.ReadLine().ToCharArray();
for (int i = 0; i < c.Length; i++)
{
    if (c[i] >= 'a' && c[i] <= 'z')
    {
        c[i] += (char)n;
        if (c[i] > 'z') c[i] = (char)((c[i] - 'a') % ('z' - 'a') + 'a' - 1);
    }
    else if (c[i] >= 'A' && c[i] <= 'Z')
    {
        c[i] += (char)n;
        if (c[i] > 'Z') c[i] = (char)((c[i] - 'A') % ('Z' - 'A') + 'A' - 1);
    }
    else if (c[i] >= '0' && c[i] <= '9')
    {
        c[i] += (char)n;
        if (c[i] > '9') c[i] = (char)((c[i] - '0') % ('9' - '0') + '0' - 1);
    }
}
Console.WriteLine(new string(c));