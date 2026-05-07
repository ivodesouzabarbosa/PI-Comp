using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
public class UIHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Escalando")]
    [SerializeField] private float hoverScale = 1.1f;

    [Header("AnimaçãoTop")]
    [SerializeField] private float duration = 0.2f;
    [SerializeField] private Ease ease = Ease.OutBack;

    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(originalScale * hoverScale, duration)
            .SetEase(ease);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(originalScale, duration)
            .SetEase(ease);
    }
}
