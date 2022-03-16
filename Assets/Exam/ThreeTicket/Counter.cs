using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private GameObject _playZone;
    private GameObject[] target_2;
    [SerializeField] private Text _textCount;
    
    private void FixedUpdate()
    {
        target_2 = GameObject.FindGameObjectsWithTag("Enemy");

        _textCount.text = target_2.Length.ToString();
    }
}
