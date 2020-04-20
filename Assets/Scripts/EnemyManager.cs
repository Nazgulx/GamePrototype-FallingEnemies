using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float timeBetweenSpawns = 1f;
    public float nextSpawnTime;

    Vector2 screenBordersWidth;

    void Start(){
        screenBordersWidth = new Vector2 (Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
    }

    void Update(){

        if(Time.time > nextSpawnTime){
            nextSpawnTime = Time.time + timeBetweenSpawns;

            Vector3 spawnPosition = new Vector3 (Random.Range(-screenBordersWidth.x, screenBordersWidth.x), screenBordersWidth.y, enemyPrefab.transform.position.z);

            GameObject newEnemy = (GameObject)Instantiate(enemyPrefab, spawnPosition, Quaternion.identity );
            newEnemy.transform.parent = transform;
        }

        
    }

}
