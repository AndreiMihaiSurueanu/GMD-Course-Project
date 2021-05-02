using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Use")]
public class Use : InputAction
{
    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        if (separatedInputWords.Length > 1)
        {
            controller.interactableItems.UseItem(separatedInputWords);
        }
        else
        {
            controller.LogStringWithReturn("You did not specify an object to use, try skull. ;)");
        }
    }
}