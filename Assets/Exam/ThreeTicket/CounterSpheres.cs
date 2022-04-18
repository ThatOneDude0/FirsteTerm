using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CounterSpheres : MonoBehaviour, IDropHandler
{
    [SerializeField] private Text _counterText;
    [SerializeField] private GameObject _counterContainer;
 

    public void OnDrop(PointerEventData eventData)
    {
        var otherItemTransform = eventData.pointerDrag.transform;
        otherItemTransform.SetParent(transform);
        otherItemTransform.localPosition = Vector3.zero;       
    }

    private void Update()
    {
        _counterText.text = _counterContainer.transform.childCount.ToString();
    }
}
