using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ittem : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    //[SerializeField] private Sound _sound;
    [SerializeField] private GameObject _item;
    [SerializeField] private float _scaleChange;

    public static Transform DragFrom;
    public static Item DraggingItem;

    public void OnPointerDown(PointerEventData eventData)
    {
        //_sound.PlayClickSound();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _item.transform.localScale *= _scaleChange;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _item.transform.localScale = new Vector3(1f, 1f);
    }

    public void Drop(Transform transform)
    {
        _item.transform.SetParent(transform);
        _item.transform.localPosition = Vector2.zero;
        DragFrom = null;
        DraggingItem = null;
    }

}
