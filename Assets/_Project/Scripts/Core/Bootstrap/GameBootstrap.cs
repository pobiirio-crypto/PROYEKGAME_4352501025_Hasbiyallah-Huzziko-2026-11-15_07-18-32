using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameBootstrap : MonoBehaviour
{
    [SerializeField] private string firstScene = "Scn_World";
    private IMoveInput moveInput;
    private IActionInput actionInput;

    private void Awake()
    {
        InputSystem.actions.Enable();

        moveInput = new InputSystemMoveInput();
        actionInput = new InputSystemActionInput();
    }

    private IEnumerator Start()
    {
        yield return SceneManager.LoadSceneAsync(firstScene, LoadSceneMode.Additive);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(firstScene));

        WorldInstaller installer = FindFirstObjectByType<WorldInstaller>();
        if (installer != null)
        {
            installer.Install(moveInput, actionInput);
        }
    }
}