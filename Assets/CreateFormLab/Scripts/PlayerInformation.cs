using TMPro;
using UnityEngine;

public class PlayerInformation : MonoBehaviour
{
    public TMP_InputField NameInputField;
    [SerializeField] private TMP_InputField _explanationInputField;
    [SerializeField] private TMP_Dropdown _raceDropdown;
    [SerializeField] private TMP_Dropdown _classDropdown;
    [SerializeField] private TextMeshProUGUI _textStatus;

    public void UpdateFields()
    {
        string nick = NameInputField.text;

        string classText = _classDropdown
            .options[_classDropdown.value]
            .text;

        _textStatus.text = null;
    }
    public void NameException()
    {
        _textStatus.text = "Nickname field is empty!";
    }
}
