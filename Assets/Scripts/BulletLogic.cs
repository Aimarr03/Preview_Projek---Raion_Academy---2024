using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    public float movementSpeed = 10f;
    

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
    }
}
