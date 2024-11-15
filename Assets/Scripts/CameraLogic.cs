using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLogic : MonoBehaviour
{
    public Transform Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Player != null)
        {
            Vector3 currentPosition = transform.position;
            currentPosition.x = Player.position.x;
            transform.position = currentPosition;
        }
    }
}
