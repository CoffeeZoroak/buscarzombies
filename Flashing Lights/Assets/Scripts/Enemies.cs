using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemies : MonoBehaviour
{
    [SerializeField] private Transform cur_target, player;
    [SerializeField] private float speed, patrolrate, range, distance;
    [SerializeField] private GameManager gm;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("Patrol",0,patrolrate);
    }
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);
        if (!gm.isPaused)
        {
            transform.position = Vector3.MoveTowards(transform.position, cur_target.position, speed);
        }
        
    }
    void Patrol()
    {
        if (gm.SecurityLvl > 80 || distance < range)
        {
            cur_target = player;
            gm.busted = true;
        }
        else
        {
            cur_target = gm.spawn[Random.Range(0, gm.spawn.Count)];
            gm.busted = false;
        }
    }
}
