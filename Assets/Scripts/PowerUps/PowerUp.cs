using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour
{
    public int value;
    
    public float duration;

    public virtual void Use()
    {
        if(duration > 0)
        {
            StartCoroutine(Count(duration));
        }
    }

    public virtual IEnumerator Count(float time)
    {
        //add

        yield return new WaitForSeconds(time);

        //remove
        AfterCount();
    }

    public virtual void AfterCount()
    {

    }
}