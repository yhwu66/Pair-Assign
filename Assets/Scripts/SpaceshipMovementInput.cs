using UnityEngine;

public class SpaceshipMovementInput : MonoBehaviour
{
    [SerializeField] SpaceshipInputManager.InputType _inputType = SpaceshipInputManager.InputType.HumanDesktop;

    public IMovementController MovementController { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        MovementController = SpaceshipInputManager.GetInputControls(_inputType);
    }

    void OnDestroy()
    {
        MovementController = null;
    }
}
