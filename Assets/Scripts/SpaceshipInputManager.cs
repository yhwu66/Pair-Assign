using UnityEngine;
using System;

public class SpaceshipInputManager : MonoBehaviour
{
    public enum InputType
    {
        HumanDesktop,
        HumanMobile,
        Bot
    }

    public static IMovementController GetInputControls(InputType inputType)
    {
        return inputType switch
        {
            InputType.HumanDesktop => new DesktopMovementController(),
            InputType.HumanMobile => null,
            InputType.Bot => null,
            _ => throw new ArgumentOutOfRangeException(nameof(inputType), inputType, null)
        };
    }
}
