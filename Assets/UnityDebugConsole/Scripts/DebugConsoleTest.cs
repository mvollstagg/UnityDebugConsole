using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static DebugConsoleManager;

public class DebugConsoleTest : MonoBehaviour
{
    public DebugConsoleManager debugConsoleManager;
    public void ErrorDebugMessage(string Message)
    {
        debugConsoleManager.DebugMessage(DebugState.Error, Message);
    }
    public void WarningDebugMessage(string Message)
    {
        debugConsoleManager.DebugMessage(DebugState.Warning, Message);
    }
    public void InfoDebugMessage(string Message)
    {
        debugConsoleManager.DebugMessage(DebugState.Info, Message);
    }
    public void SuccessDebugMessage(string Message)
    {
        debugConsoleManager.DebugMessage(DebugState.Success, Message);
    }
}