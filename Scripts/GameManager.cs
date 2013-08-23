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
	GameObject enemy = Instantiate(enemyPrefab, new Vector3(5, 10, 5), Quaternion.identity) as GameObject;
	enemy.GetComponent<EnemyBehaviour>().manager = this;
    }
}
