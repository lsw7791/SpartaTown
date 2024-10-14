using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }

    public string SelectedCharacter { get; set; } 
    public string PlayerName { get; set; } 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("SelectedCharacter", SelectedCharacter);
        PlayerPrefs.SetString("PlayerName", PlayerName); 
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        SelectedCharacter = PlayerPrefs.GetString("SelectedCharacter", "");
        PlayerName = PlayerPrefs.GetString("PlayerName", ""); 
    }
}
