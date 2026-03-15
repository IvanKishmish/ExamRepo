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

Dictionary<string, string> hashes = new Dictionary<string, string>();

//=====================================================================================3 commit

foreach (string file in files)
{
    try
    {
        string hash = GetFileHash(file);

        if (hashes.ContainsKey(hash))
        {
            Console.WriteLine("Duplicate found:");
            Console.WriteLine(file);
            Console.WriteLine("Duplicate of:");
            Console.WriteLine(hashes[hash]);
            Console.WriteLine();
        }
        else
        {
            hashes[hash] = file;
        }
    }
    catch
    {
        Console.WriteLine("Cannot read file: " + file);
    }
}
Console.WriteLine("Scan finished.");

//======================================================================4 commit