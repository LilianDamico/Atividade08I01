// Menu
int op;
Console.SetCursorPosition(5, 3)
Console.WriteLine("===============================================");
Console.WriteLine("informe a opção desejada");
Console.WriteLine("1 - Bhaskara");
Console.WriteLine("2 - Força");
Console.WriteLine("3 - Velocidade");
Console.WriteLine("4 - Não sei qual eu quero...");
op = Convert.ToInt32(Console.ReadLine());
switch (op)
{
    case 1:
        double a, b, c, delta, x1, x2;
        Console.WriteLine("Informe o valor de a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor de b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor de c: ");
        c = Convert.ToDouble(Console.ReadLine());
        delta = Math.Pow(b, 2) - (4 * a * c);
        x1 = (-(b) + Math.Sqrt(delta)) / 2 * a;
        x2 = (-(b) - Math.Sqrt(delta)) / 2 * a;
        Console.WriteLine("O valor de x1 é  " + x1 + "e o valor de x2 é " + x2);
        break;
    case 2:
        int f, m, ac;
        Console.WriteLine("Informe o valor de m: ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o valor de ac: ");
        ac= Convert.ToInt32(Console.ReadLine());
        f = m * ac;
        Console.WriteLine("O valor da variável f é: " + f);
        break;
    case 3:
        int v, v0, t, acl;
        Console.WriteLine("Informe o valor de v0: ");
        v0 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o valor de acl: ");
        acl = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o valor de t: ");
        t = Convert.ToInt32(Console.ReadLine());
        v = v0 + (acl);
        Console.WriteLine("O valor de v é: " + v);
        break;
    case 4:
        Console.WriteLine("Decida-se meu bem...");
        break;

    default:
        Console.WriteLine("Opção inválida :):):)");
        break;
}
Console.ReadKey();