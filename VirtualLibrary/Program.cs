using System.Text;

string _FILE_NAME = "library.txt";

var authorName = getStringFromUser("Enter author name: ", "Author name cannot be empty");
var bookName = getStringFromUser("Enter book name: ", "Book name cannot be empty");

await saveBook(authorName, bookName);
await readBook();

string getStringFromUser(string promptMessage, string errorMessage)
{
    string? userInput;
    bool success;

    do
    {
        Console.Write(promptMessage);

        userInput = Console.ReadLine();

        success = userInput != null && userInput.Length > 0;

        if (!success)
        {
            Console.WriteLine(errorMessage);
        }
    } while (!success);

    return userInput ?? string.Empty;
}

async Task saveBook(string authorName, string bookName)
{
    var content = $"The book \"{bookName}\" was written by {authorName}.";

    try
    {
        var path = GetPath();
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

async Task readBook()
{
    try
    {
        var path = GetPath();
        var content = await File.ReadAllTextAsync(path, Encoding.UTF8);

        Console.WriteLine(content);
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

string GetPath()
{
    return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), _FILE_NAME);
}