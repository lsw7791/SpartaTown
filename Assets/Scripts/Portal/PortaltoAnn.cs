using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortaltoAnn : MonoBehaviour
{
    public string sceneToLoad = "MainScene"; 
    public Vector3 spawnPosition; 
    public string PortalID; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            PlayerPrefs.SetString("ActivePortalID", PortalID);
            PlayerPrefs.SetFloat("X", spawnPosition.x);
            PlayerPrefs.SetFloat("Y", spawnPosition.y);
            PlayerPrefs.SetFloat("Z", spawnPosition.z);
            PlayerPrefs.Save();

            SceneManager.LoadScene(sceneToLoad);
        }
    }
}