using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public GameObject spikes8_prefab;
    float timer;
    public float spawnRateInSeconds;

    public int score = 0;

    private void Update()
    {
        if (timer == 0f)
            SpawnSpikes();

        timer += Time.deltaTime;

        if(timer >= spawnRateInSeconds)
        {
            timer = 0f;
        }
    }

    public void SpawnSpikes()
    {
        Instantiate(spikes8_prefab, new Vector3(15, Random.Range(-1.7f, 1.7f), 107.8691f), Quaternion.identity);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
