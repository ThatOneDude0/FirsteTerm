using UnityEngine;

public class ManagerCanvas1 : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;
    [SerializeField] private PlayerInformation _playerInformation;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {           
            if (!_canvas.activeInHierarchy)
            {
                _canvas.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (_playerInformation.NameInputField.text == "")
            {
                _playerInformation.NameException();                
            }
            else
            {
                _canvas.SetActive(false);
            }
        }
    }
}
