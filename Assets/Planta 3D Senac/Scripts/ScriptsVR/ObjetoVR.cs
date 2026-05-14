using UnityEngine;
using UnityEngine.InputSystem;

public class ObjetoVR : MonoBehaviour
{

    public Camera camerad;
    public GameObject painel;

    void Start()
    {

        painel.SetActive(false);

    }

    void Update()
    {

        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (camerad == null) return;

            Vector2 mousePos = Mouse.current.position.ReadValue();
            Ray raioDoMouse = camerad.ScreenPointToRay(mousePos);
            RaycastHit acerto;


            if (Physics.Raycast(raioDoMouse, out acerto))
            {
                if (acerto.collider.gameObject == gameObject)
                {

                    if (painel != null)
                    {
                        bool estadoAtual = painel.activeSelf;
                        painel.SetActive(!estadoAtual);
                    }
                }
            }
        }
    }
}