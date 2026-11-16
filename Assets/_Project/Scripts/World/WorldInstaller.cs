using UnityEngine;

public class WorldInstaller : MonoBehaviour
{
    [SerializeField] private PlayerMovement player;

    public void Install(IMoveInput moveInput)
    {
        if (player != null)
        {
            player.Construct(moveInput);
        }
    }
}