using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerup : MonoBehaviour
{
    #region Singleton
    public static SpawnPowerup instance;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }
    #endregion

    public GameObject[] powerupPrefabs;
    public GameObject player;

    [HideInInspector]
    public Collider playerCollider;
    [HideInInspector]
    public PlayerHealth playerHealth;
    [HideInInspector]
    public PlayerMovement playerMovement;

    private void Start()
    {
        playerCollider = player.GetComponent<CapsuleCollider>();
        playerHealth = player.GetComponent<PlayerHealth>();
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    public void Spawn(Vector3 position)
    {
        Instantiate(powerupPrefabs[Random.Range(0,powerupPrefabs.Length)], position, Quaternion.identity);
    }
}
