using UnityEngine;
using UnityEngine.UI;

public class ComponentOutput : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void OnEnable()
    {
        ComponentInput.onChanged += ChangeText;
    }

    private void OnDisable()
    {
        ComponentInput.onChanged -= ChangeText;
    }

    private void ChangeText(string value)
    {
        _text.text = value;
    }
}
