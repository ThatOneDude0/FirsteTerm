using UnityEngine;
using UnityEngine.EventSystems;

public class SphereMovment : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private RectTransform _rectTransform;
    private Vector2 _startPosition;
    [SerializeField] private CanvasGroup _canvasGroup;

    public void OnBeginDrag(PointerEventData eventData)
    {
        _startPosition = _rectTransform.position;
        _canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        _rectTransform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _rectTransform.position = eventData.position;
        _canvasGroup.blocksRaycasts = true;

    }
}
