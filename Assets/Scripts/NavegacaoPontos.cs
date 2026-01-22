using UnityEngine;
using DG.Tweening; 

public class NavegacaoPontos : MonoBehaviour
{
    
    public GameObject cmCamera;
    public float velocidade = 1.5f;

    public void IrParaPonto(Transform pontoDestino)
    {
        
        cmCamera.transform.DOMove(pontoDestino.position, velocidade).SetEase(Ease.InOutQuad);

        
        cmCamera.transform.DORotate(pontoDestino.eulerAngles, velocidade);
    }
}