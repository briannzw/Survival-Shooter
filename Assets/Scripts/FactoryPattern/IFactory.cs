using UnityEngine;

public interface IFactory
{
    GameObject FactoryMethod(GameObject enemyPrefab, Transform spawnTransform);
}
