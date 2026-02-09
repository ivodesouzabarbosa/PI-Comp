using UnityEngine;

public class AnimacaoOnda : MonoBehaviour
{
    public float speed = 100f;      // velocidade em pixels por segundo
    public float resetX = -800f;    // posição onde a onda reseta

    private RectTransform rect;
    private float startX;

    void Start()
    {
        rect = GetComponent<RectTransform>();
        startX = rect.anchoredPosition.x;
    }

    void Update()
    {
        rect.anchoredPosition += Vector2.left * speed * Time.deltaTime;

        if (rect.anchoredPosition.x <= resetX)
        {
            rect.anchoredPosition = new Vector2(startX, rect.anchoredPosition.y);
        }
    }
}
