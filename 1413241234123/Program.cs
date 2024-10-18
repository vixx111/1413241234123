try
{
    Console.WriteLine("Введите сумму");
    Double sum = Double.Parse(Console.ReadLine());
    Console.WriteLine("Введите срок");
    Double years = Double.Parse(Console.ReadLine());
    Double stavka = 8 / 100;
    Double j = Math.Sqrt(sum) * Math.Sqrt(stavka) * Math.Sqrt(years);
    Console.WriteLine($"Итог: {j}");
}
catch
{

}