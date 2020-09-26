using System;
using UnityEngine;

public class EnemyFactory : MonoBehaviour, IFactory
{
    [SerializeField]
    public EnemyManager[] enemies;

    public GameObject FactoryMethod(GameObject enemyPrefab, Transform spawnPosition)
    {
        GameObject enemy = Instantiate(enemyPrefab, spawnPosition.position, spawnPosition.rotation);
        return enemy;
    }
}
