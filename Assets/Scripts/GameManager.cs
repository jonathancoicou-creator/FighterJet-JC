using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float verticalScreenSize;
    public float horizontalScreenSize;

    public int score;

    public GameObject enemyOnePrefab;
    public GameObject enemyTwoPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        horizontalScreenSize = 10f;
        verticalScreenSize = 6.5f;
        InvokeRepeating("CreateEnemyOne", 2f, 3f);
        InvokeRepeating("CreateEnemyTwo", 4f, 4f); 
        score = 0;
    }

  
    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-8f, 8f), 6.5f, 0), Quaternion.identity);

    }
    void CreateEnemyTwo()
    {
        Instantiate(enemyTwoPrefab, new Vector3(10f, Random.Range(-6.5f, 6.5f), 0), Quaternion.identity);
    }


    public void AddScore(int pointsToAdd)
    {
        score += pointsToAdd;
    }
}
