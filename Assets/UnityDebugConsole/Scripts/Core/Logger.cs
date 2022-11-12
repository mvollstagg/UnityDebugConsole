using System.Linq;
using DilmerGames.Core.Singletons;
using TMPro;
using UnityEngine;
using System;

public class Logger : Singleton<Logger>
{
    [SerializeField]
    private bool enableDebug = false;

    void OnEnable()
    {
        DebugConsoleManager.Instance.enabled = enableDebug;
        enabled = enableDebug;

        if (enabled)
        {
            DebugConsoleManager.Instance.SendDebugMessage(DebugConsoleManager.DebugState.Info,
                                                $"<color=\"white\">[{DateTime.Now.ToString("HH:mm:ss.fff")}]</color> {this.GetType().Name} enabled\n");
        }
    }

    public void LogInfo(string message)
    {
        DebugConsoleManager.Instance.SendDebugMessage(DebugConsoleManager.DebugState.Info,
                                            $"<color=\"white\">[{DateTime.Now.ToString("HH:mm:ss.fff")}]</color> {message}\n");
    }

    public void LogError(string message)
    {
        DebugConsoleManager.Instance.SendDebugMessage(DebugConsoleManager.DebugState.Error,
                                            $"<color=\"white\">[{DateTime.Now.ToString("HH:mm:ss.fff")}]</color> {message}\n");
    }

    public void LogWarning(string message)
    {
        DebugConsoleManager.Instance.SendDebugMessage(DebugConsoleManager.DebugState.Warning,
                                            $"<color=\"white\">[{DateTime.Now.ToString("HH:mm:ss.fff")}]</color> {message}\n");
    }
    public void LogSuccess(string message)
    {
        DebugConsoleManager.Instance.SendDebugMessage(DebugConsoleManager.DebugState.Success,
                                            $"<color=\"white\">[{DateTime.Now.ToString("HH:mm:ss.fff")}]</color> {message}\n");
    }
}