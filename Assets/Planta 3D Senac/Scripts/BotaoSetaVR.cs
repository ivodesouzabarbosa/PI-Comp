using UnityEngine;

public class BotaoSetaVR : MonoBehaviour
{
    public LocalPonto destino;

    
    public void AtivarViagemVR()
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
