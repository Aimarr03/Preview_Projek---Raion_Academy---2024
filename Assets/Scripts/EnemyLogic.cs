using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public float movementSpeed = 8f;
    public GameManagerLogic gameManagerLogic;

    private void Update()
    {
        if (gameManagerLogic.GameOver) return;
        transform.position -= Vector3.forward * movementSpeed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            gameManagerLogic.SetGameOver();
        }
        else if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
