using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Spwan : MonoBehaviour
{
    public GameObject penguinPrefab; 
    public GameObject rtanPrefab;
    public Text nameTagText; 
    public Canvas mainCanvas;

    private Dictionary<string, Vector3> portalSpawnPositions = new Dictionary<string, Vector3>()
    {
        { "Kim", new Vector3(0, 16, 0) },      
        { "Ann", new Vector3(20.02f, -1.1f, 0) },    
        { "Han", new Vector3(0, -16, 0) },  
        { "Kang", new Vector3(-20.02f, -1.1f, 0) }   
    };

    private Transform playerTransform;

    void Start()
    {
        string activePortalID = PlayerPrefs.GetString("ActivePortalID", "");

        Vector3 spawnPosition;
        if (portalSpawnPositions.ContainsKey(activePortalID))
        {
            spawnPosition = portalSpawnPositions[activePortalID];
        }
        else
        {
            spawnPosition = new Vector3(0, 0, 0); 
        }

        string selectedCharacter = DataManager.Instance.SelectedCharacter;

        GameObject player; 

        if (selectedCharacter == "Penguin")
        {
            player = Instantiate(penguinPrefab, spawnPosition, Quaternion.identity); 
        }
        else if (selectedCharacter == "Rtan")
        {
            player = Instantiate(rtanPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            player = Instantiate(penguinPrefab, spawnPosition, Quaternion.identity);
        }

        playerTransform = player.transform;

        Camera.main.GetComponent<PlayerFollowCamera>().player = player.transform;

        if (nameTagText != null)
        {
            nameTagText.text = DataManager.Instance.PlayerName; 
        }

        StartCoroutine(UpdateNameTagPosition());
    }

    IEnumerator UpdateNameTagPosition()
    {
        Vector3 offset = new Vector3(0, 0, 0); 

        while (true)
        {
            if (playerTransform != null)
            {
                nameTagText.transform.localPosition = playerTransform.localPosition + offset;
            }
            yield return null; 
        }
    }
}
