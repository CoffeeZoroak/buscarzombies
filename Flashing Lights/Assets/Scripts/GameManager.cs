using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public bool isPaused = false;
    [SerializeField] public bool busted = false;
    [SerializeField] public float SecurityLvl, hp, collectibles, goal;
    [SerializeField] public int round;
    [SerializeField] public TextMeshProUGUI TextCounter;
    [SerializeField] public GameObject prefab;
    [SerializeField] public List<Transform> spawn;
    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
        SecurityLvl = 0;
        Obstucalo();
    }

    // Update is called once per frame
    void Update()
    {
        TextCounter.text = collectibles.ToString() + "/" + goal.ToString();
        SecurityLvl = Mathf.Clamp(SecurityLvl,0, 100);
        if (collectibles == goal)
        {
            Obstucalo();
        }
    }
    
    void Obstucalo()
    {
        collectibles = 0;
        goal = 0;
        round++;
        for (int i = 0; i < round; i++)
        {
            goal++;
        }
    }
}
