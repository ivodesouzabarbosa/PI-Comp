using UnityEngine;
using UnityEngine.EventSystems; 

public class BotaoSeta : MonoBehaviour, IPointerClickHandler
{
    public LocalPonto destino;

   
    private void OnMouseDown()
    {
        
        AtivarViagem();
    }

    
    public void OnPointerClick(PointerEventData eventData)
    {
        
        AtivarViagem();
    }

    
    void AtivarViagem()
    {
        if (destino != null)
        {
            if (TourManager.Instance != null)
            {
                TourManager.Instance.IrParaLocal(destino);
            }
            
        }
        
    }
}