using UnityEngine;

public class Pfinal : MonoBehaviour
{
    public float speed = 100f;
    [SerializeField]  private RectTransform rect;
    [SerializeField] private RectTransform pontoFinal;

    private Vector3 startPos;
    private float time;
    void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    void Start()
    {
        pontoFinal = GameObject.Find("P-FINAL").GetComponent<RectTransform>();
    }

    void OnEnable()
    {
        startPos = rect.position;
        time = 0f;
    }
    void Update()
    {
        if (!gameObject.activeInHierarchy) return;

        rect.position = Vector3.MoveTowards(
            rect.position,
            pontoFinal.position,
            speed * Time.deltaTime
        );

        if (Vector3.Distance(rect.position, pontoFinal.position) < 5f)
        {
            gameObject.SetActive(false);
        }
    }

    /*void Update()
    {
        time += Time.deltaTime;

        Vector3 direction = (pontoFinal.position - startPos).normalized;

        float distance = speed * time;

        Vector3 basePosition = startPos + direction * distance;

        float wave = Mathf.Sin(time * 5f) * 20f;

        rect.position = basePosition + new Vector3(0, wave, 0);

        if (direction.x < 0 && rect.position.x <= pontoFinal.position.x)
        {
            gameObject.SetActive(false);
        }
        else if (direction.x > 0 && rect.position.x >= pontoFinal.position.x)
        {
            gameObject.SetActive(false);
        }
    }*/
}


