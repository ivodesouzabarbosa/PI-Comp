using DG.Tweening;
using UnityEngine;

public class TourManager_Vr : MonoBehaviour
{
    public static TourManager_Vr Instance;

    [Header("Referências")]
    public Transform cameraVirtualObj;
    public CameraLook scriptDeOlhar;

    // --- NOSSA NOVA TELA PRETA ---
    public CanvasGroup telaPreta;

    [Header("Ajustes")]
    public float tempoPiscada = 0.15f; // Pisca bem rápido (0.15 segundos) para não entediar o jogador

    public LocalPonto _localAtual;

    void Awake()
    {
        Instance = this;
    }

    public void IrParaLocal(LocalPonto novoLocal)
    {
        if (scriptDeOlhar != null) scriptDeOlhar.enabled = false;

        // Se a tela preta foi colocada lá no Unity, faz a mágica:
        if (telaPreta != null)
        {
            // 1. Escurece a tela até o Alpha 1
            telaPreta.DOFade(1, tempoPiscada).OnComplete(() =>
            {
                // 2. Quando ficar 100% escuro, faz o teleporte invisível
                FazerTeleporte(novoLocal);

                // 3. Clareia a tela de volta pro Alpha 0
                telaPreta.DOFade(0, tempoPiscada);
            });
        }
        else
        {
            // Sistema de segurança: Se você esquecer de ligar a tela no Unity, ele teleporta direto
            FazerTeleporte(novoLocal);
        }
    }

    // Separei o teleporte aqui embaixo para o código ficar mais limpo
    private void FazerTeleporte(LocalPonto novoLocal)
    {
        if (_localAtual != null) _localAtual.DesativarSetas();
        _localAtual = novoLocal;

        cameraVirtualObj.position = novoLocal.transform.position;
        cameraVirtualObj.eulerAngles = novoLocal.transform.eulerAngles;

        if (novoLocal.proximoPontoAutomatico != null)
        {
            IrParaLocal(novoLocal.proximoPontoAutomatico);
        }
        else
        {
            _localAtual.AtivarSetas();
            if (scriptDeOlhar != null) scriptDeOlhar.enabled = true;
        }
    }
}