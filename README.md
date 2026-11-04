# Shutdown Timer

Windows console utility that shuts down the computer after a countdown.

## Run

Install the .NET 8 SDK, then:

```powershell
dotnet run --project shutdownTimer.csproj
```

Enter a whole number of minutes from 1 to 1440. Press Ctrl+C before the countdown ends to cancel. At zero the app runs `shutdown.exe /s /t 0`, which starts a Windows shutdown immediately. Save open work before using it.

## Status

The original file mixed C# with JavaFX-style button code and had no project file. The cleanup makes it a console app with input validation and an explicit Windows check. A Windows shutdown was not executed during this review.
## Related projects

See the [project index](https://github.com/Jaeger790#projects) for the rest of my work.
