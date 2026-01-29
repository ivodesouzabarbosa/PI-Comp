using UnityEngine;
using System.Collections.Generic;

public class LocalPonto : MonoBehaviour
{
    [Header("Configurações")]
    [SerializeField] bool _pontoInicio = false;

    [Header("Referências")]
    public List<GameObject> minhasSetas;

    // (Opcional) Se você quiser deixar fixo no script para onde ele vai
    public LocalPonto proximoPontoAutomatico;

    void Start()
    {
        // Garante o estado inicial correto assim que o jogo abre
        if (_pontoInicio)
            AtivarSetas();
        else
            DesativarSetas();
    }

    // --- FUNÇÃO MÁGICA PARA O BOTÃO ---
    // Use ESTA função no evento OnClick da Seta
    public void IrParaPonto(LocalPonto proximoPonto)
    {
        // 1. Desliga as setas deste ponto (onde estou agora)
        DesativarSetas();

        // 2. Liga as setas do ponto de destino
        if (proximoPonto != null)
        {
            proximoPonto.AtivarSetas();
        }
    }

    public void AtivarSetas()
    {
        foreach (var seta in minhasSetas)
            if (seta != null) seta.SetActive(true);
    }

    public void DesativarSetas()
    {
        foreach (var seta in minhasSetas)
            if (seta != null) seta.SetActive(false);
    }
}