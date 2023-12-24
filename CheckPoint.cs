using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private Vector3 spawnPoint;

    void Start()
    {
        spawnPoint = transform.position; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            TeleportToCheckPoint(); 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CheckPoint")) 
        {
            SetCheckPoint(other.transform.position);
            Destroy(other.gameObject); 
        }
    }

    void TeleportToCheckPoint()
    {
        transform.position = spawnPoint; 
    }

    void SetCheckPoint(Vector3 checkpointPosition)
    {
        spawnPoint = checkpointPosition; 
    }
}
