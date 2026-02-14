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

    [SerializeField] GameObject girarPorta;

    public List<GameObject> objetosDaSala;

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
        foreach (var obj in objetosDaSala)
            if (obj != null) obj.SetActive(true);
        AbrirPorta();
    }

    public void DesativarSetas()
    {
        foreach (var seta in minhasSetas)
            if (seta != null) seta.SetActive(false);
        foreach (var obj in objetosDaSala)
            if (obj != null) obj.SetActive(false);
        FechaPorta();
    }

    void AbrirPorta()
    {
        if (girarPorta != null)
        {
            var porta = girarPorta.GetComponent<PortaControlador>();
            if (porta != null) porta.Abrir();
        }
    }

    void FechaPorta()
    {
        if (girarPorta != null)
        {
            var porta = girarPorta.GetComponent<PortaControlador>();
            if (porta != null) porta.Fechar();
        }
    }
}