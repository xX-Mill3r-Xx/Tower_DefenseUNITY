using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawPoint;
    public float timeBetweenWaves = 5f;

    private float countDown = 2f;
    private int waveIndex = 0;

    public Text waveCountDownText;

    private void Update()
    {
        if(countDown <= 0f)
        {
            StartCoroutine(SpawWave());
            countDown = timeBetweenWaves;
        }
        countDown -= Time.deltaTime;
        waveCountDownText.text = Mathf.Round(countDown).ToString();
    }

    IEnumerator SpawWave()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void SpawEnemy()
    {
        Instantiate(enemyPrefab, spawPoint.position, spawPoint.rotation);
    }
}
