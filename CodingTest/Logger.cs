using System;
using System.IO;
using CodingTest.Enums;

namespace CodingTest {
public class Logger
{
    public static void LogMessage(string filePath, string message, LogLevel level)
    {
        if (filePath == null || filePath == "") {
            filePath = "application.log";
        };
        
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string logEntry = $"[{timestamp}] [{level}] {message}";

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(logEntry);
        }
    }
}
}
