
ShowMenu();
int number = int.Parse(Console.ReadLine());
int Bullets = 30;
bool status = true;
while (status)
{
    switch (number)
    {
        case 1:
            Console.Clear();
            Bullets=Shoot(Bullets);
            break;

        case 2:
            Console.Clear();
            Bullets=ShootAuto(Bullets);

            
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Mermini yeniden doldur");
            Bullets = 30;
            break;
        case 4:
            status = false;
            break;
        case 5:
            Console.Clear();
            Console.WriteLine(Bullets);
            break;

        default:
            Console.Clear();
            Console.WriteLine("Duzgun reqem daxil edin");
            break;
    }
    if (status)
    { 
    ShowMenu(); 

    number = int.Parse(Console.ReadLine());

    }




} 

static void ShowMenu()
{
    Console.WriteLine("1.Gulleni tek tek at");
    Console.WriteLine("2.Gullenin hamisini at");
    Console.WriteLine("3.Mermini yeniden doldur");
    Console.WriteLine("4.Oyundan cix");
    Console.WriteLine("Mermi sayini goster");

}
static int Shoot(int data)

{   if (data > 0)
    {
        Console.WriteLine("gulle atildi");
        data--;
        return data;
    }
    else
    {
        Console.WriteLine("Gulle yoxdur");
        return 0;
    }
}

static int ShootAuto(int data)

{

    if (data > 0)
    {
        Console.WriteLine("hamisi atildi");
        data = 0;
        return data;
    }
    else
    {
        Console.WriteLine("Gulle yoxdur");
        return 0;
    }
    
}