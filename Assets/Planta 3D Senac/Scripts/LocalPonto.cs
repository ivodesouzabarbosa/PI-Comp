using UnityEngine;
using System.Collections.Generic;

public class LocalPonto : MonoBehaviour
{
    
    public List<GameObject> minhasSetas;

    public LocalPonto proximoPontoAutomatico;

    void Start()
    {
        DesativarSetas();
    }

    public void AtivarSetas()
    {
        foreach (var seta in minhasSetas) if (seta != null) seta.SetActive(true);
    }

    public void DesativarSetas()
    {
        foreach (var seta in minhasSetas) if (seta != null) seta.SetActive(false);
    }
}