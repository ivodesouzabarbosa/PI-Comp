using UnityEngine;

public class Pinicial : MonoBehaviour
{
    public RectTransform pontoInicial;
    public float intervalo = 1.5f;
    public float maxintervalo = 1.5f;

    void Start()
    {
       // InvokeRepeating(nameof(SpawnWave), 0f, intervalo * Time.deltaTime);
       // InvokeRepeating(nameof(SpawnWave), 0f, intervalo * Time.deltaTime);
    }
    void FixedUpdate()
    {
        intervalo -= Time.deltaTime;
        if (intervalo < 0f)
        {

            SpawnWave();
            intervalo = maxintervalo;
        }
            

    }

    void SpawnWave()
    {
        Debug.Log("Spawnado");
        GameObject wave = OndaPool.Instance.GetObject();
        wave.SetActive(true);

        RectTransform rect = wave.GetComponent<RectTransform>();
        rect.position = pontoInicial.position;
    }
}
