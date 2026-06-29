using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Collectible : MonoBehaviour
{
    [SerializeField] private int point;
    [SerializeField] private GameManager gm;

    private void Start()
    {
        //transform.position = gm.spawn[Random.Range(0, gm.spawn.Count)].position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gm.collectibles++;
            Destroy(gameObject);
        }
    }
}
