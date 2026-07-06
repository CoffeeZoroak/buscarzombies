using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Collectible : MonoBehaviour
{
    [SerializeField] private int point;
    [SerializeField] private GameManager gm;
    [SerializeField] private int type;

    private void Update()
    {
        if (type == gm.round)
        {
            gameObject.SetActive(true);
        }
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
