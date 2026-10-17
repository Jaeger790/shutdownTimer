using System.Diagnostics;

if (!OperatingSystem.IsWindows())
{
    Console.Error.WriteLine("This shutdown timer requires Windows.");
    return 1;
}

Console.Write("Enter duration in minutes: ");
if (!int.TryParse(Console.ReadLine(), out var minutes) || minutes <= 0 || minutes > 1440)
{
    Console.Error.WriteLine("Enter a whole number from 1 to 1440.");
    return 1;
}

Console.WriteLine("Press Ctrl+C to cancel before the countdown ends.");
var deadline = DateTimeOffset.UtcNow.AddMinutes(minutes);
while (DateTimeOffset.UtcNow < deadline)
{
    var remaining = Math.Ceiling((deadline - DateTimeOffset.UtcNow).TotalSeconds);
    Console.Write($"\rSeconds remaining: {remaining:0}   ");
    await Task.Delay(1000);
}

Process.Start(new ProcessStartInfo("shutdown.exe", "/s /t 0") { UseShellExecute = false });
return 0;
