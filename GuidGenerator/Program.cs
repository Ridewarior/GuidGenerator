using TextCopy;

var guid = Guid.NewGuid().ToString();
ClipboardService.SetText(guid);

Console.Write("GUID copied to clipboard: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(guid);
Console.ResetColor();