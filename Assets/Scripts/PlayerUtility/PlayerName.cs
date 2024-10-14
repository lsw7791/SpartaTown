using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    [SerializeField] private Text playerNameText;

    void Start()
    {
        string playerName = DataManager.Instance.PlayerName;

        playerNameText.text = playerName;
    }
}