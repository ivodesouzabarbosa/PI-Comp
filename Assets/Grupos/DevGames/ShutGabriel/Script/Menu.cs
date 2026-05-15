using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    [SerializeField] private string Cena;
    [SerializeField] public TesouroHuntManager _tesouroHuntManager;
    [SerializeField] public TimerUpdate timerUpdate;
    [SerializeField] Transform _menuIni;
    public void SelecionarCurso(int value)
    {
        //  Debug.Log(gameObject.name);
        timerUpdate.StartTimer();
        _menuIni.DOScale(0, .25f);
        _tesouroHuntManager.EscolherObjeto(value);
        switch (value)
        {

            case 0:
                Debug.Log("Curso de " + "Desenvolvimento de sistemas" + " Selecionado");
                break;
            case 1:
                Debug.Log("Curso de " + "Fotografia" + " Selecionado");
                break;
            case 2:
                Debug.Log("Curso de " + "Analise de Dados" + " Selecionado");
                break;
            case 3:
                Debug.Log("Curso de " + "Idomas" + " Selecionado");
                break;
            case 4:
                Debug.Log("Curso de " + "Moda" + " Selecionado");
                break;
            case 5:
                Debug.Log("Curso de " + "Manutenção de redes" + " Selecionado");
                break;

        }
    }
  

}
