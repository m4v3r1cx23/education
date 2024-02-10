using System.Text;

string _FILE_NAME = "data.txt";

var matrix = generateMatrix();

await saveData(matrix);
await readData();

static int[,] generateMatrix()
{
    int[,] matrix = new int[10, 10];

    for (var i = 0; i < 10; i++)
    {
        for (var j = 0; j < 10; j++)
        {
            matrix[i, j] = 1;
        }
    }

    return matrix;
}

async Task saveData(int[,] data)
{
    try
    {
        var path = GetPath();
        var content = convertData(data);

        await File.WriteAllTextAsync(path, content, Encoding.UTF8);
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
        try
        {
            var path = GetPath();
            var content = await File.ReadAllTextAsync(path, Encoding.UTF8);

            foreach(var c in content.Split('\n'))
            {
                Console.WriteLine(c);
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

string convertData(int[,] data)
{
    var builder = new StringBuilder();

    for (var i = 0; i < 10; i++)
    {
        for (var j = 0; j < 10; j++)
        {
            builder.Append(data[i, j]);
            builder.Append(' ');
        }

        builder.Append('\n');
    }

    return builder.ToString();
}

string GetPath()
{
    return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), _FILE_NAME);
}