using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public bool isPaused = false;
    [SerializeField] public bool shopping = false;
    [SerializeField] public bool busted = false;
    [SerializeField] public bool ded = false;
    [SerializeField] public float SecurityLvl, maxhp, hp, collectibles, goal;
    [SerializeField] public int round;
    [SerializeField] public TextMeshProUGUI TextCounter;
    [SerializeField] public GameObject prefab, dedCanvas;
    [SerializeField] public List<Transform> spawn;
    // Start is called before the first frame update
    void Start()
    {
        dedCanvas.SetActive(false);
        maxhp = 100;
        hp = 100;
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
        TextCounter.text = collectibles.ToString() + "/" + goal.ToString();
        SecurityLvl = Mathf.Clamp(SecurityLvl,0, 100);
        hp = Mathf.Clamp(hp, 0, maxhp);
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
        goal = round;
    }
}
