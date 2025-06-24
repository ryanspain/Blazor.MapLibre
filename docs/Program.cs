using System.Diagnostics;

Process.Start(new ProcessStartInfo {
    FileName = "dotnet",
    Arguments = "docfx serve dist --open-browser",
    UseShellExecute = false
})!.WaitForExit();