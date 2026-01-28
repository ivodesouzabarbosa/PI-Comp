using UnityEngine;
using UnityEngine.InputSystem;

public class CameraLook : MonoBehaviour
{
    [Header("Ajuste de Velocidade")]
    public float sensibilidadeMouse = 0.5f;
    public float sensibilidadeToque = 0.05f;

    [Header("Travar Eixos")]
    public bool travarVertical = true;

    private float rotacaoX = 0f;
    private float rotacaoY = 0f;

    void OnEnable()
    {
        Vector3 rotAtual = transform.localEulerAngles;
        rotacaoY = rotAtual.y;
        rotacaoX = rotAtual.x;

        
        if (rotacaoX > 180) rotacaoX -= 360;
    }

    void Update()
    {
        if (Pointer.current == null) return;

        if (Pointer.current.press.isPressed)
        {
            float velocidadeAtual = sensibilidadeMouse;

            if (Pointer.current is Touchscreen)
            {
                velocidadeAtual = sensibilidadeToque;
            }

            float moveX = Pointer.current.delta.x.ReadValue() * velocidadeAtual;

            
            float moveY = 0;
            if (!travarVertical)
            {
                moveY = Pointer.current.delta.y.ReadValue() * velocidadeAtual;
            }

            rotacaoY += moveX;
            rotacaoX -= moveY;

            
            if (travarVertical)
            {
                rotacaoX = 0f; 
            }
            else
            {
                rotacaoX = Mathf.Clamp(rotacaoX, -40f, 40f);
            }

            transform.localRotation = Quaternion.Euler(rotacaoX, rotacaoY, 0f);
        }
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}