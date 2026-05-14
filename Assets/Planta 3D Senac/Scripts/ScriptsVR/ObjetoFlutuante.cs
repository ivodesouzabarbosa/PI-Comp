using UnityEngine;

public class ObjetoFlutuante : MonoBehaviour
{
    [Header("Configurações de Rotação")]
    [Tooltip("Velocidade de giro em cada eixo (X, Y, Z)")]
    public Vector3 velocidadeRotacao = new Vector3(0f, 50f, 0f);

    [Header("Configurações de Flutuação")]
    [Tooltip("O quão rápido o objeto sobe e desce")]
    public float velocidadeFlutuacao = 2f;

    [Tooltip("A altura máxima que ele sobe e desce (amplitude)")]
    public float alturaFlutuacao = 0.2f;

    // Armazena a posição inicial do objeto no cenário
    private Vector3 posicaoInicial;

    void Start()
    {
        // Salva a posição original do objeto assim que o jogo começa
        posicaoInicial = transform.position;
    }

    void Update()
    {
        // 1. LÓGICA DE ROTAÇÃO
        // Gira o objeto continuamente no tempo da Unity (Time.deltaTime garante giro suave independente do FPS)
        transform.Rotate(velocidadeRotacao * Time.deltaTime);

        // 2. LÓGICA DE FLUTUAÇÃO
        // Calcula a nova altura usando a curva de Seno com base no tempo do jogo
        float novaAltura = posicaoInicial.y + (Mathf.Sin(Time.time * velocidadeFlutuacao) * alturaFlutuacao);

        // Aplica a nova posição mantendo o X e o Z originais
        transform.position = new Vector3(posicaoInicial.x, novaAltura, posicaoInicial.z);
    }
}