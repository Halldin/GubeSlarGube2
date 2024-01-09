using UnityEngine;

[CreateAssetMenu(menuName = "Capcha")]
public class CapchaScriptableObject : ScriptableObject
{
    public Sprite[] correctImages;
    public Sprite[] incorrectImages;
    public string prompt;
}
