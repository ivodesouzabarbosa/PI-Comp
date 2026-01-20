using UnityEngine;
using Unity.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class MenuController : MonoBehaviour
{
    [SerializeField] private string                             _nomeDoJogo;
    [SerializeField] private GameObject                         _PainelMenuInicial;
    [SerializeField] private GameObject                         _PainelOpções;
    private string                                              _FocusPainel;
    public List<Transform> menu1 = new List<Transform>();
    public List<Transform> menu2 = new List<Transform>();
    //DOTWEEN PARA BOTÕES
    void Start()
    {
        for (int i = 0; i < menu1.Count; i++)
        {
            menu1[i].transform.localScale = new Vector2 (0, 0);
        }
        for (int i = 0; i < menu2.Count; i++)
        {
            menu2[i].transform.localScale = new Vector2(0, 0);
        }
        StartCoroutine(TimeONMenu());
    }
    IEnumerator TimeONMenu()
    {
        for (int i = 0; i < menu1.Count; i++)
        {
            menu1[i].DOScale(2f, .5f);
            yield return new WaitForSeconds(.25f);
        }
        
        for (int i = 0; i < menu2.Count; i++)
        {
            menu2[i].DOScale(1f, .5f);
            yield return new WaitForSeconds(.25f);
        }
    }
    //BOTÕES
    public void Jogar()
    {
        SceneManager.LoadScene(_nomeDoJogo);
    }
    public void AbrirOpcoes()
    {
        _PainelMenuInicial.SetActive(false);
        _PainelOpções.SetActive(true);

    }
    public void FecharOpcoes()
    {
        _PainelMenuInicial.SetActive(true);
        _PainelOpções.SetActive(false);
    }
    public void Sair()
    {
        Debug.Log("Saiu do Jogo");
        Application.Quit();
    }
    // DG para Painel Opções
    public void Movepainel(string panel)
    {
        GameObject.Find(panel).transform.DOLocalMove(new Vector3(0, 0, 0), .5f);
        _FocusPainel = panel;
    }
    public void BACKpainel(string panel)
    {
        GameObject.Find(_FocusPainel).transform.DOLocalMove(new Vector3(1500, 0, 0), .5f);
    }
}