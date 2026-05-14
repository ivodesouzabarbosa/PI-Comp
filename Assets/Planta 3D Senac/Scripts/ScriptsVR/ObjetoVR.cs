using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables; 

public class ObjetoVR : MonoBehaviour
{
    [Header("Interface")]
    public GameObject painel;

    [Header("Limpeza de Cena")]
    public GameObject[] gameObjectsAtrapaiando;

    private XRSimpleInteractable interactable;

    void Start()
    {
       
        if (painel != null)
        {
            painel.SetActive(false);
        }

        
        

        
        interactable = GetComponent<XRSimpleInteractable>();


        interactable.selectEntered.AddListener(clickVR);
    }

   
    private void clickVR(SelectEnterEventArgs arg0)
    {
         
           bool estadoAtual = painel.activeSelf;
           painel.SetActive(!estadoAtual);
           gameObject.SetActive(false);
        foreach (GameObject objAtrapalhando in gameObjectsAtrapaiando)
        {
            if (objAtrapalhando != null)
            {
                objAtrapalhando.SetActive(false);
            }
        }

    }

   
    public void Reinciarcena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnDestroy()
    {
          
       //interactable.selectEntered.RemoveListener(clickVR);
        
    }
}