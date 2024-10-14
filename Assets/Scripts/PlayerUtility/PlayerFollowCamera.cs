using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    [SerializeField] public Transform player; 
    [SerializeField] private Vector3 offset; 

    void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}
