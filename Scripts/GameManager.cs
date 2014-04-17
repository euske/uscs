// -*- tab-width: 4 -*-
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject enemyPrefab;
    public int score = 0;

    // Use this for initialization
    void Start () {
        UpdateScore();
        SpawnEnemy();
    }
    
    void ScoreEnemy () {
        score++;
        UpdateScore();
        SpawnEnemy();
    }

    void UpdateScore()
    {
        guiText.text = "Score: "+score;
    }

    void SpawnEnemy () {
        Vector3 pos = new Vector3(5, 10, 5);
        GameObject enemy = Instantiate(enemyPrefab, pos, 
                                       Quaternion.identity) as GameObject;
        enemy.GetComponent<EnemyBehaviour>().manager = this;
    }
}
