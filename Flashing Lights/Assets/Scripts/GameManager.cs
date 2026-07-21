using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public bool isPaused = false;
    [SerializeField] public bool busted = false;
    [SerializeField] public bool ded = false;
    [SerializeField] public float SecurityLvl, hp, maxhp, speed, collectibles, goal;
    [SerializeField] public int round;
    [SerializeField] public TextMeshProUGUI TextCounter;
    [SerializeField] public GameObject prefab, dedCanvas, powerup;
    [SerializeField] public List<Transform> spawn;
    // Start is called before the first frame update
    void Start()
    {
        ded = false;
        dedCanvas.SetActive(false);
        maxhp = 100;
        hp = 100;
        speed = 5;
        SecurityLvl = 0;
        Obstucalo();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            ded = true;
            dedCanvas.SetActive(true);
        }
        else
        {
            TextCounter.text = collectibles.ToString() + "/" + goal.ToString();
            SecurityLvl = Mathf.Clamp(SecurityLvl,0, 100);
            if (collectibles >= goal)
            {
                Obstucalo();
            }
        }
    }
    
    void Obstucalo()
    {
        isPaused = true;
        powerup.SetActive(true);
        collectibles = 0;
        goal = 0;
        round++;
        for (int i = 0; i < round; i++)
        {
            goal++;
        }
    }
}
