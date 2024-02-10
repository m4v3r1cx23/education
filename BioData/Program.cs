using System.Text;

string _FILE_NAME = "library.txt";
string _DATA = "Sekwencja kwasów nukleinowych: 5-AATTGGCC-3";

await saveData();
await readData();
deleteData();
clearConsole();

async Task saveData()
{
    try
    {
        var path = GetPath();
        await File.WriteAllBytesAsync(path, Encoding.UTF8.GetBytes(_DATA));
    }
    catch (PathTooLongException)
    {
        Console.WriteLine("The path is too long.");
    }
    catch (DirectoryNotFoundException)
    {
        Console.WriteLine("The directory was not found.");
    }
    catch (IOException)
    {
        Console.WriteLine("The file could not be opened.");
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("You do not have permission to write to this file.");
    }
    catch (NotSupportedException)
    {
        Console.WriteLine("The path is not in a valid format.");
    }
    catch (System.Security.SecurityException)
    {
        Console.WriteLine("You do not have permission to write to this file.");
    }
}

async Task readData()
{
    try
    {
        var path = GetPath();

        try
        {
            using (var file = File.OpenRead(path))
            {
                var index = _DATA.LastIndexOf(' ') + 1;
                var length = Encoding.UTF8.GetByteCount(_DATA);
                var subLength = Encoding.UTF8.GetByteCount(_DATA[index..]);
                var position = length - subLength;

                if (position >= file.Length)
                {
                    Console.WriteLine("The file is too short.");

                    return;
                }

                var bufferSize = file.Length - position;
                var buffer = new byte[bufferSize];

                file.Seek(position, SeekOrigin.Begin);

                var task = await file.ReadAsync(buffer);

                if (task != bufferSize)
                {
                    Console.WriteLine("Invalid data!");

                    return;
                }

                Console.WriteLine(Encoding.UTF8.GetString(buffer));
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory was not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("The file could not be opened.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permission to write to this file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The path is not in a valid format.");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("You do not have permission to write to this file.");
        }
        catch (ObjectDisposedException)
        {
            Console.WriteLine("The file has already been closed.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The position is negative or larger than the file size.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The buffer length minus index is less than count.");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("The stream is currently in use by a previous read operation.");
        }
    }
    catch (PathTooLongException)
    {
        Console.WriteLine("The path is too long.");
    }
    catch (DirectoryNotFoundException)
    {
        Console.WriteLine("The directory was not found.");
    }
    catch (IOException)
    {
        Console.WriteLine("The file could not be opened.");
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("You do not have permission to write to this file.");
    }
    catch (NotSupportedException)
    {
        Console.WriteLine("The path is not in a valid format.");
    }
    catch (System.Security.SecurityException)
    {
        Console.WriteLine("You do not have permission to write to this file.");
    }
}

void deleteData()
{
    try
    {
        try
        {
            var path = GetPath();

            File.Delete(path);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory was not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("The file could not be opened.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permission to write to this file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The path is not in a valid format.");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("You do not have permission to write to this file.");
        }
    }
    catch (PathTooLongException)
    {
        Console.WriteLine("The path is too long.");
    }
    catch (DirectoryNotFoundException)
    {
        Console.WriteLine("The directory was not found.");
    }
    catch (IOException)
    {
        Console.WriteLine("The file could not be opened.");
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("You do not have permission to write to this file.");
    }
    catch (NotSupportedException)
    {
        Console.WriteLine("The path is not in a valid format.");
    }
    catch (System.Security.SecurityException)
    {
        Console.WriteLine("You do not have permission to write to this file.");
    }
}

void clearConsole()
{
    Console.WriteLine("Press any key to continue...");
    Console.Read();
    Console.Clear();
}

string GetPath()
{
    return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), _FILE_NAME);
}