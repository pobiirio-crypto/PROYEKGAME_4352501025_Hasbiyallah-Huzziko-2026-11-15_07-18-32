using UnityEngine;

public class WorldInstaller : MonoBehaviour
{
    [SerializeField] private PlayerMovement player;
    [SerializeField] private PlayerInteractor interactor;

    public void Install(IMoveInput moveInput, IActionInput actionInput)
    {
        if (player != null) player.Construct(moveInput);
        if (interactor != null) interactor.Construct(actionInput);
    }
}