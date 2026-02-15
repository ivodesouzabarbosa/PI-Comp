using UnityEngine;

public class Pinicial : MonoBehaviour
{
    public RectTransform pontoInicial;
    public float intervalo = 1.5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnWave), 0f, intervalo);
    }

    void SpawnWave()
    {
        GameObject wave = OndaPool.Instance.GetObject();
        wave.SetActive(true);

        RectTransform rect = wave.GetComponent<RectTransform>();
        rect.position = pontoInicial.position;
    }
}
