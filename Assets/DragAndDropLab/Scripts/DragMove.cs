using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragMove : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private RectTransform _rectTransform;
    private Vector2 _startPosition;
    [SerializeField] private Image _image;

    public void OnBeginDrag(PointerEventData eventData)
    {
        _startPosition = _rectTransform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        _rectTransform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _rectTransform.position = _startPosition;

        _image.raycastTarget = true;
    }
}
