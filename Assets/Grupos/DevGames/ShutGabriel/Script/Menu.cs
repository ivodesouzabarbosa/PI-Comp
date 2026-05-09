using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class Menu : MonoBehaviour
{
    [SerializeField] private string Cena;
    public void SelecionarCurso(string curso)
    {
        Debug.Log("Curso de " + curso + "Selecionado");
    }
    public void Jogar()
    {
        SceneManager.LoadScene(Cena);
    }

}
