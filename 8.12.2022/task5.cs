Console.WriteLine("Zehmet olmasa yasinizi daxil edin");
int yas=Convert.ToInt32(Console.ReadLine());
int x;
if(yas>=18)
{
    Console.WriteLine("Suruculuk vesiqesi ala bilersiniz");
}
else
{
    x = 18 - yas;
    Console.WriteLine("Suruculuk vesiqesi ala bilmezsiniz.Suruculuk vesiqesi almaginiza " +x+ " il qalib");
}
