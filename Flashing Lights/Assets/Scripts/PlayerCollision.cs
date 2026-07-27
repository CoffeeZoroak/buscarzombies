using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private GameManager gm;

    private void FixedUpdate()
    {
        if (!gm.busted)
        {
            gm.SecurityLvl -= 0.01f;
        }
    }
    private void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.CompareTag("Light"))
        {
            gm.SecurityLvl += 0.1f;
        }
        if (coll.gameObject.CompareTag("Enemy"))
        {
            gm.hp -= 0.5f;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gm.hp -= 0.5f;
        }
    }
}
