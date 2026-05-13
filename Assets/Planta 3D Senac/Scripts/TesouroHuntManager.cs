using UnityEngine;
using UnityEngine.UI;

public class TesouroHuntManager : MonoBehaviour
{

    public GameObject[] botoes;
    public GameObject[] objetosDoMapa;
    public LocalPonto pontoInicialDoTour;
    void Start()
    {
        foreach (GameObject obj in objetosDoMapa)
        {
            obj.SetActive(false);
        }
    }

    public void EscolherObjeto(int indiceEscolhido)
    {
        foreach (GameObject btn in botoes)
        {
            //btn.interactable = false;
        }

        
       
        

        if (objetosDoMapa[indiceEscolhido] != null)
        {
            objetosDoMapa[indiceEscolhido].SetActive(true);
         
        }

        if (pontoInicialDoTour != null)
        {
            pontoInicialDoTour.AtivarSetas();
            
        }
    }
}