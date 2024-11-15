using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public float movementSpeed = 5;
    public Transform AimTransform;
    public Transform prefabBullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementInput = Input.GetAxisRaw("Horizontal");
        if (movementInput != 0)
        {
            Vector3 movementDirection = new Vector3 (movementInput, 0, 0);
            transform.position += movementDirection * Time.deltaTime * movementSpeed;
            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x, -10, 10),
                transform.position.y,
                transform.position.z
            );
        }
        if (Input.GetMouseButtonDown(0))
        {
            Transform bullet = Instantiate(prefabBullet, AimTransform.position, Quaternion.identity);
            Destroy(bullet.gameObject, 5);
        }

    }
}
