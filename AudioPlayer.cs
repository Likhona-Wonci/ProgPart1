using System;
using System.Diagnostics;
using System.IO;

namespace SecureNetAssistant
{
    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                // 🔊 Gets the bin/Debug folder automatically
                string filePath = Path.Combine(AppContext.BaseDirectory, "hello.wav");

                // ❌ stop if file not found
                if (!File.Exists(filePath))
                    return;

                // ✅ Plays using Windows default audio handler (no dependencies)
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch
            {
                // silently ignore errors so app never crashes
            }
        }
    }
}