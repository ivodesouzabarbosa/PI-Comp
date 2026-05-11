using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class Menu : MonoBehaviour
{
    [SerializeField] private string Cena;
    public void SelecionarCurso(int value)
    {
        switch (value)
        {
           case 0:
            break;
           case 1:
            Debug.Log("Curso de " + "Fotografia" + " Selecionado");
            break;
           case 2:
            Debug.Log("Curso de " + "Idomas" + " Selecionado");
            break;
           case 3:
            Debug.Log("Curso de " + "Moda" + " Selecionado");
            break;
           case 4:
            Debug.Log("Curso de " + "Analise de Dados" + " Selecionado");
            break;
           case 5:
            Debug.Log("Curso de " + "Desenvolvimento de sistemas" + " Selecionado");
            break;
           case 6:
            Debug.Log("Curso de " + "Manutenção de redes" + " Selecionado");
            break;

        }

     
    }
  

}
