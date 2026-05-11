using UnityEngine;
using UnityEngine.UI;

public class TesouroHuntManager : MonoBehaviour
{

    public Button[] botoes;
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
        foreach (Button btn in botoes)
        {
            btn.interactable = false;
        }

        ColorBlock colors = botoes[indiceEscolhido].colors;
        colors.disabledColor = Color.green;
        botoes[indiceEscolhido].colors = colors;

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