using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ComponentInput : MonoBehaviour
{
    public static Action<string> onChanged;

    private string _inputText;

    [SerializeField] private InputField _inputField;

    public void Click()
    {
        _inputText = _inputField.text;
        onChanged?.Invoke(_inputText);
    }
}