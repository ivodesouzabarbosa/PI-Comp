using UnityEngine;
using DG.Tweening;

public class PortaControlador : MonoBehaviour
{
    [Header("Configurações de Aberta")]
    public Vector3 rotacaoAberta;

    [Header("Ajustes")]
    public float tempoAbertura = 1.0f;

    private Vector3 _rotacaoInicial;

    void Start()
    {

        _rotacaoInicial = transform.localEulerAngles;

    }

    public void Abrir()
    {

        transform.DOLocalRotate(rotacaoAberta, tempoAbertura).SetEase(Ease.OutQuad);
    }

    public void Fechar()
    {
        transform.DOLocalRotate(_rotacaoInicial, tempoAbertura).SetEase(Ease.InQuad);
    }
}