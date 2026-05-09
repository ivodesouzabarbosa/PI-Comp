using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private float _scaleMultiplier = 1.1f;
    [SerializeField] private float _duration = 0.2f;
    private Vector3 _originalScale;
    private void Start()
    {
        _originalScale = transform.localScale;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(_originalScale * _scaleMultiplier, _duration)
            .SetEase(Ease.OutBack);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(_originalScale, _duration)
            .SetEase(Ease.OutBack);
    }

}
