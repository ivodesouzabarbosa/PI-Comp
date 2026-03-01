using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneResetter : MonoBehaviour
{
    public InputActionReference restartActionReference;

    private void OnEnable() => restartActionReference.action.performed += ResetScene;
    private void OnDisable() => restartActionReference.action.performed -= ResetScene;

    private void ResetScene(InputAction.CallbackContext context)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}