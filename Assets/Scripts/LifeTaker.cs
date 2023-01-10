using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTaker : MonoBehaviour
{
    public int damage;
    public bool ignoreInvencible;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
     //       collision.GetComponent<LifeController>().Damage(damage, ignoreInvencible);
        }
    }
}

