using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float minModifier;
    public float maxModifier;
    public float maxSpeed;

    Vector3 _velocity = Vector3.zero;
    bool _isFollowing = false;

    private void Start()
    {
        target = SpawnPowerup.instance.player.transform;
    }

    private void Update()
    {
        if (_isFollowing)
        {
            transform.position = Vector3.SmoothDamp(transform.position, target.position, ref _velocity, Time.deltaTime * Random.Range(minModifier, maxModifier), maxSpeed);
        }
    }

    public void StartFollowing()
    {
        _isFollowing = true;
    }
}
