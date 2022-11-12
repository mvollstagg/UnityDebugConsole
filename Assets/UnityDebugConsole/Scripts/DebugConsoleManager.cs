using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using StarterAssets;
using UnityEngine.InputSystem;

public class DebugConsoleManager : MonoBehaviour
{
    public enum DebugState
    {
        Error,
        Warning,
        Success,
        Info
    }
    [SerializeField]
    private List<GameObject> DebugConsoleItems;
    [SerializeField]
    private GameObject DebugConsoleGameObject;
    private bool consoleStatus;
    [SerializeField]
    private ScrollRect myScrollRect;

    public void DebugMessage(DebugState debugState, string message)
    {
        var DebugConsolePrefab = DebugConsoleItems.FirstOrDefault(x => x.name.Contains(debugState.ToString()));
        GameObject debugConsoleObject = Instantiate(DebugConsolePrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        debugConsoleObject.GetComponentInChildren<TextMeshProUGUI>().text = message;
        debugConsoleObject.transform.SetParent(DebugConsoleGameObject.transform, false);
        myScrollRect.normalizedPosition = new Vector2(myScrollRect.normalizedPosition.x, 0f);
    }

    void Update() 
    {        
        if(Keyboard.current.f1Key.wasPressedThisFrame)
        {
            consoleStatus = !consoleStatus;
            DebugConsoleGameObject.transform.root.gameObject.SetActive(consoleStatus);
        }            
    }
}
