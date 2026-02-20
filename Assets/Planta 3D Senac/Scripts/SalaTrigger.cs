using UnityEngine;

public class SalaTrigger : MonoBehaviour
{
   
    public GameObject conteudoDaSala;

    public GameObject girarPorta;

    void Start() => conteudoDaSala.SetActive(false);

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("MainCamera"))conteudoDaSala.SetActive(true);
        AbrirPorta();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))conteudoDaSala.SetActive(false);
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