using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static DebugConsoleManager;

public class DebugConsoleTest : MonoBehaviour
{
    public void ErrorDebugMessage(string Message)
    {
        Logger.Instance.LogError(Message);
    }
    public void WarningDebugMessage(string Message)
    {
        Logger.Instance.LogWarning(Message);
    }
    public void InfoDebugMessage(string Message)
    {
        Logger.Instance.LogInfo(Message);
    }
    public void SuccessDebugMessage(string Message)
    {
        Logger.Instance.LogSuccess(Message);
    }
}