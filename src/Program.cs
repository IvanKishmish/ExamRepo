using System.Security.Cryptography;

Console.WriteLine("Enter folder path: ");
string folder = Console.ReadLine()!;
if (folder == null)
    throw new Exception("You must type the path of folder!");

if(!Directory.Exists(folder))
{
    Console.WriteLine("Folder does not exist!");
    return;
}
//=======================================================================1 commit

string[] files = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);
Console.WriteLine($"Total files found: {files.Length}");

//====================================================================================2 commit

