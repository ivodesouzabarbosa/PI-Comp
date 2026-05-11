using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
public class Menu : MonoBehaviour
{
    [SerializeField] private string Cena;
    [SerializeField] private GerenciadorObjetosMapa _gerenciadorObjetosMapa;
    [SerializeField] Transform _menuIni;
    public void SelecionarCurso(int value)
    {
        _menuIni.DOScale(0, .25f);
        _gerenciadorObjetosMapa.EscolherObjeto(value);
        Debug.Log("Ativar botoes do chão para navegar");


    }
  

}
