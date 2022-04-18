using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemySlot : MonoBehaviour, IDropHandler
{
    [SerializeField] private GameObject _gameObject;
    

    public void OnDrop(PointerEventData eventData)
    {
        var otherItemTransform = eventData.pointerDrag.transform;        
        this.transform.SetParent(otherItemTransform, false);

        otherItemTransform.transform.localScale = otherItemTransform.transform.localScale 
            + _gameObject.transform.localScale;

        Destroy(_gameObject);
        
    }
}
