using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerLogic : MonoBehaviour
{
    public Transform EnemyPrefab;
    public bool GameOver = false;

    private float currentDuration = 0f;
    public float intervalToSpawn = 7f;

    public Canvas UI;
    void Start()
    {
        UI.gameObject.SetActive(false);
    }
    void Update()
    {
        if (GameOver) return;
        currentDuration += Time.deltaTime;
        if(currentDuration > intervalToSpawn)
        {
            currentDuration = 0;
            Vector3 spawnPosition = transform.position;
            spawnPosition.x = Random.Range(spawnPosition.x - 8, spawnPosition.x + 8);
            Transform enemy = Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);
            enemy.GetComponent<EnemyLogic>().gameManagerLogic = this;
        }
    }
    public void SetGameOver()
    {
        GameOver = true;
        UI.gameObject.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void OnQuit()
    {
        Application.Quit();
    }
}
