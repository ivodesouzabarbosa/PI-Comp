using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TimerUpdate : MonoBehaviour
{
    [Header("Tempo em minutos")]
    public float minutos = 10f;

    private float tempoAtual;

    public TextMeshProUGUI _time;

    private bool rodando;


    void Start()
    {
        // Converte minutos para segundos
        tempoAtual = minutos * 60;

        rodando = false;
    }

    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Tour_Virtual_Windows");
        }

        if (rodando)
        {
            tempoAtual -= Time.deltaTime;

            if (tempoAtual <= 0)
            {
                tempoAtual = 0;
                rodando = false;

                Debug.Log("Tempo acabou");
                SceneManager.LoadScene("Tour_Virtual_Windows");
            }

            int min = Mathf.FloorToInt(tempoAtual / 60);
            int seg = Mathf.FloorToInt(tempoAtual % 60);

            _time.text = string.Format("{0:00}:{1:00}", min, seg);
        }
    }

    public void StartTimer()
    {
        rodando = true;
    }

    public void StopTimer()
    {
        rodando = false;
    }

    public void ResetTimer()
    {
        tempoAtual = minutos * 60;
    }
}