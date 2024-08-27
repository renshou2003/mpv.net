
using MpvNet.ExtensionMethod;
using System.Reflection;

namespace MpvNet;

public class Folder
{
    static Folder()
    {
#if NET
        var processPath = Environment.ProcessPath!;
#else
        var processPath = Assembly.GetEntryAssembly().Location;
#endif
        Startup = Path.GetDirectoryName(processPath)!.AddSep();
    }
    public static string Startup { get; }
    public static string AppData { get; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).AddSep();
}
