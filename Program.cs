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

Console.WriteLine("Hello, World!");