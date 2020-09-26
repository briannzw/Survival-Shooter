using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParent : MonoBehaviour
{
    public Collider playerCollider;

    public PowerUp[] powerUps;

    private void Start()
    {
        playerCollider = SpawnPowerup.instance.playerCollider;
    }

    private void OnTriggerEnter(Collider other)
    {
        float maxDuration = -1;
        if (other.CompareTag("Player") && other == playerCollider)
        {
            for(int i = 0; i<powerUps.Length; i++)
            {
                powerUps[i].Use();
                maxDuration = Mathf.Max(maxDuration, powerUps[i].duration);
            }

            GetComponent<Collider>().enabled = false;
            if(maxDuration <= 0)
            {
                Destroy(transform.parent.gameObject);
            }
            else StartCoroutine(DestroyAfter(maxDuration));
        }
    }

    IEnumerator DestroyAfter(float time)
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<TrailRenderer>().enabled = false;
        yield return new WaitForSeconds(time + 1f);
        Destroy(transform.parent.gameObject);
    }
}
