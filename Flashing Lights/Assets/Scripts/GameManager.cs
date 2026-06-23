using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public bool isPaused = false;
    [SerializeField] public bool busted = false;
    [SerializeField] public float SecurityLvl = 0;
    [SerializeField] public float hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
        SecurityLvl = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SecurityLvl = Mathf.Clamp(SecurityLvl,0, 100);
    }
}
