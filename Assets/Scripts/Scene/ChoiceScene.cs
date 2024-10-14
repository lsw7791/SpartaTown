using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChoiceScene : MonoBehaviour
{
    [SerializeField] private GameObject choicePanel; 
    [SerializeField] private GameObject inputPanel;  
    [SerializeField] private InputField nameInputField;
    [SerializeField] private Text messageText;

    private bool isCharacterSelected = false;

    void Start()
    {
        
    }

    public void OnPenguinClicked()
    {
        OnCharacterClicked("Penguin");
    }

    public void OnRtanClicked()
    {
        OnCharacterClicked("Rtan");
    }

    public void OnCharacterClicked(string characterName)
    {
        if (!isCharacterSelected)
        {
            DataManager.Instance.SelectedCharacter = characterName;

            choicePanel.SetActive(false);

            inputPanel.SetActive(true);

            nameInputField.Select();

            messageText.text = "이름을 입력하세요";

            isCharacterSelected = true;
        }
    }

    public void OnStartButtonClicked()
    {
        OnSubmit();
    }

    public void OnSubmit()
    {
        string playerName = nameInputField.text;

        if (!string.IsNullOrEmpty(playerName))
        {
            DataManager.Instance.PlayerName = playerName;

            DataManager.Instance.SaveData();

            SceneManager.LoadScene("StartScene");
        }
        else
        {
            messageText.text = "이름을 입력하세요";
        }
    }
}
