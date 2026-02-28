using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class LocalPonto : MonoBehaviour
{
    [Header("Configurações")]
    [SerializeField] bool _pontoInicio = false;

    [Header("Referências")]
    public List<GameObject> minhasSetas;


    public LocalPonto proximoPontoAutomatico;

   

    void Start()
    {


        if (_pontoInicio)
            AtivarSetas();
            
        else
            DesativarSetas();
    }


    public void IrParaPonto(LocalPonto proximoPonto)
    {

        DesativarSetas();


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