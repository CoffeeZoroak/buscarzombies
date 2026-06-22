using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private GameManager gm;
    [SerializeField] private Collider coll;

    private void FixedUpdate()
    {
        gm.SecurityLvl -= 0.01f;
    }
    private void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.CompareTag("Light"))
        {
            gm.SecurityLvl += 0.1f;
        }
    }
}
