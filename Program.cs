// See https://aka.ms/new-console-template for more information
using tpmodul4_1302204035;

HaloGeneric halo = new HaloGeneric();

//input name 
Console.WriteLine("Masukkan nama user : ");
string nama;
halo.SetNama(nama = Console.ReadLine());
//return nama
Console.Clear();//Clear screen console
Console.WriteLine("Halo user : " + halo.SapaUser());


namespace tpmodul4_1302204035
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<int> data1 = new DataGeneric<int>();
            data1.Add(1302204035);
            data1.PrintData();
            //System.Console.WriteLine("Nim : " + data1.PrintData(0));
        }
    }
}