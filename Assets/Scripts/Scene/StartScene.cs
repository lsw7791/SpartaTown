using UnityEngine;

public class StartScene : MonoBehaviour
{
    public GameObject penguinPrefab;
    public GameObject rtanPrefab;

    void Start()
    {
        string selectedCharacter = PlayerPrefs.GetString("SelectedCharacter", "");

        if (selectedCharacter.ToLower() == "penguin")
        {
            Instantiate(penguinPrefab, new Vector3(-10, -17, 0), Quaternion.identity);
        }
        else if (selectedCharacter.ToLower() == "rtan")
        {
            Instantiate(rtanPrefab, new Vector3(-10, -17, 0), Quaternion.identity);
        }
    }
}
