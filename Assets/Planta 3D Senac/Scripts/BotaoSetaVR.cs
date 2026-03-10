using UnityEngine;

public class BotaoSetaVR : MonoBehaviour
{
    public LocalPonto destino;

    
    public void AtivarViagemVR()
    {
        if (destino != null)
        {
            if (TourManager_Vr.Instance != null)
            {
                TourManager_Vr.Instance.IrParaLocal(destino);
            }
        }
    }
}
