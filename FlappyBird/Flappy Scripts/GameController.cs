using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float spawnTimer;
    float spawnRate = 3f;
    public GameObject tubo;
    public static bool gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameover)
        {
            spawnTimer += Time.deltaTime;
            if (spawnTimer > spawnRate)
            {
                spawnTimer -= spawnRate;
                Vector2 spawnPos = new Vector2(2f, Random.Range(-1f, 2f));
                Instantiate(tubo, spawnPos, Quaternion.identity);
            }
        }
           
    }
}
