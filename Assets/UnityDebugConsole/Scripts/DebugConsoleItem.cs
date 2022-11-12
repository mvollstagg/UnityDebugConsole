using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class DebugConsoleItem : MonoBehaviour
{
    [SerializeField]
    public string DebugName;
    [SerializeField]
    private Color ForegroundColor;
    [SerializeField]
    private Color BackgroundColor;
    [SerializeField]
    private Sprite Icon;
    private string Message;
    [SerializeField]
    private Image SpriteObject;
    [SerializeField]
    private Image BackgroundObject;
    [SerializeField]
    private TMPro.TMP_Text TextObject;

    private void OnEnable() {
        SpriteObject.sprite = Icon;
        TextObject.color = ForegroundColor;
        BackgroundObject.color = BackgroundColor;
    }
}


