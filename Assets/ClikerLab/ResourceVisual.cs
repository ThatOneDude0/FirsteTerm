using UnityEngine;
using TMPro;

public class ResourceVisual : MonoBehaviour
{
    public GameResource GameResource;
    [SerializeField] private TextMeshProUGUI _resourceText;
    [SerializeField] private ResourceBank _resourceBank;

    void Awake()
    {
        _resourceBank = Game.Intance.ResourceBank;
        UpdateText(_resourceText);

    }
    public void UpdateText(TextMeshProUGUI _resourceText)
    {
        _resourceText.text += " " + _resourceBank.GetResource(GameResource).ToString();
    }
}
