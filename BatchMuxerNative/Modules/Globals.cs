using System.IO;
using BatchMuxerNative.Properties;

namespace BatchMuxerNative.Modules
{
    public static class Globals
    {
        public
            static string Mmpath = Path.Combine(Settings.Default.mkvmergePATH, "mkvmerge.exe");
        public static string Language = Settings.Default.language;
        public static readonly string[] Extensions = { ".mkv", ".webm", ".mp4" };
        public static FileInfo[] Fi;
    }
}
