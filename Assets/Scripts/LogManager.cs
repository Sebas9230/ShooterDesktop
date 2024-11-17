using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;

public static class LogManager
{
    private static string logFilePath;

    static LogManager()
    {
        // Define the file path for the log file
        logFilePath = Path.Combine(Application.persistentDataPath, "GameLogs.txt");

        // Optionally, clear the log file when the game starts
        if (File.Exists(logFilePath))
        {
            File.WriteAllText(logFilePath, ""); // Clear previous logs
        }

        Debug.Log($"Log file initialized at: {logFilePath}");
    }

    public static void LogEvent(string eventType, string message)
    {
        // Create the log entry
        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss},{eventType},{message}";

        // Write the log entry to the file
        try
        {
            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
        }
        catch (Exception e)
        {
            Debug.LogError($"Failed to write log: {e.Message}");
        }

        // Also log the event to the console for debugging
        Debug.Log(logEntry);
    }
}
