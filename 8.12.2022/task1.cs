Console.WriteLine("Reqem daxil edin");
int N=Convert.ToInt32(Console.ReadLine());
if(N%2==0)
{
    N = N / 2;
    Console.WriteLine(N);
}
else
{
    N = N * 2;
    Console.WriteLine(N);
}