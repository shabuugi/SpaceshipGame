using UnityEngine;
using UnityEngine.InputSystem;

public class Restart : MonoBehaviour
{
    [SerializeField] InputAction restartAction = new InputAction(type: InputActionType.Button);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        restartAction.AddBinding("<Keyboard>/r");
    }
    private void OnEnable()
    {
        restartAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (restartAction.WasPerformedThisFrame())
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
        
    }
}
