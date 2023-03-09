Console.WriteLine("выберите способ : формулы = 1 , циклы = 2");
int sbosob = Convert.ToInt32(Console.ReadLine());
if (sbosob == 1)
{
    Console.WriteLine("арифметическая прогрессия");
    Console.WriteLine("введите первый член");  
    double aformuli = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите разность");
    double dformuli = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите номер последнего члена"); 
    double nformuli = Convert.ToDouble(Console.ReadLine());
    double sformuli = (aformuli + dformuli) /2 * nformuli;
    Console.WriteLine($"сумма арифметической прогрессии = {sformuli}");

    Console.WriteLine("геометрическая прогрессия");  
    Console.WriteLine("введите первый член"); 
    double bformuli = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите знаменатель  прогрессии"); 
    double qformuli = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите номер последнего члена"); 
    double n2formuli = Convert.ToDouble(Console.ReadLine());
    double s2formuli = bformuli * (Math.Pow(qformuli, n2formuli) / qformuli - 1);
    Console.WriteLine($"сумма геометрической прогрессии = {s2formuli}");
}

if (sbosob == 2)
    Console.WriteLine("aрифметическая прогрессия"); 
    Console.WriteLine("введите первый член");
    double acycle = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите разность");
    double dcycle = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите число элементов");
    double ncycle = Convert.ToDouble(Console.ReadLine());

    double last = acycle;
    double summa = acycle ;


    for (double i = 0; i < (ncycle - 1); i++)
    {
        last = last + dcycle;
        summa = summa + last;

    }
    Console.WriteLine($"сум = {summa}");

{
    Console.WriteLine("геометрическая прогрессия"); 
    Console.WriteLine("введите первый член"); 
    double bcycle = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите знаменатель  прогрессии");
    double qcycle = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите номер последнего члена"); 
    double n2cycle = Convert.ToDouble(Console.ReadLine());
    double u = bcycle;
    for (double i = 0; i < (ncycle - 1); i++)
    {
        bcycle = bcycle * qcycle;
        u = u + bcycle;

    }
    Console.WriteLine($"u = {u}");


}
