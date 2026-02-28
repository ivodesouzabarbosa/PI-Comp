using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TourManager : MonoBehaviour
{
    public static TourManager Instance;

    [Header("Referências")]
    public Transform cameraVirtualObj;
    public CameraLook scriptDeOlhar;  

    [Header("Ajustes")]
    public float tempoViagem = 2.0f;

    public LocalPonto _localAtual;

    void Awake()
    {
        Instance = this;
    }

    public void IrParaLocal(LocalPonto novoLocal)
    {
        
        // if (scriptDeOlhar != null) scriptDeOlhar.enabled = false;

        
        if (_localAtual != null) _localAtual.DesativarSetas();
        _localAtual = novoLocal;

       
        cameraVirtualObj.DOKill();

      
        cameraVirtualObj.DOMove(novoLocal.transform.position, tempoViagem).SetEase(Ease.InOutQuad).OnComplete(() => 
        {
           if (novoLocal.proximoPontoAutomatico != null)
           {
               IrParaLocal(novoLocal.proximoPontoAutomatico); 
           }
           else
           {
                    
               _localAtual.AtivarSetas();
               if (scriptDeOlhar != null) scriptDeOlhar.enabled = true;
           }
        });

       
        cameraVirtualObj.DORotate(novoLocal.transform.eulerAngles, tempoViagem).SetEase(Ease.InOutQuad);
    }

   
}