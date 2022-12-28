// See https://aka.ms/new-console-template for more information
int derece;
Console.WriteLine("Suyun sıcaklık derecesini giriniz ");
derece = Convert.ToInt32(Console.ReadLine());
if (derece < 0)
{
    Console.WriteLine("0 derecenin altında olduğundan katı halde");
}
else if (0 < derece || derece < 100)
{
    Console.WriteLine("0 - 100 derece arasında olduğundan sıvı halde");
}
else 
{
    Console.WriteLine("100 dereceden fazla olduğundan gaz halde");
}

