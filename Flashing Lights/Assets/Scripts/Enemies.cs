using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    [SerializeField] private List<Transform> targets;
    [SerializeField] private Transform cur_target;
    [SerializeField] private float speed;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("Patrol",0,5);
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, cur_target.position, speed);
    }
    void Patrol()
    {
        cur_target = targets[Random.Range(0,targets.Count)];
    }
}
