using UnityEngine;

public class Pfinal : MonoBehaviour
{
    public float speed = 1f;
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
        Vector3 direcao = (pontoFinal.position - transform.position).normalized;
        transform.position += direcao * speed * Time.deltaTime;

        if (Vector3.Distance(rect.position, pontoFinal.position) < 5f)
        {
            //gameObject.SetActive(false);
        }
    }

   
}


