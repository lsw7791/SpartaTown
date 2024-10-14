using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceButton : MonoBehaviour
{
    public ChoiceScene choiceScene;

    public void OnClickCharacter()
    {
        if (gameObject.tag == "Penguin")
        {
            choiceScene.OnPenguinClicked();
        }
        else if (gameObject.tag == "Rtan")
        {
            choiceScene.OnRtanClicked();
        }
    }
}
