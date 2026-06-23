using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScripts : MonoBehaviour
{
    [SerializeField] private Animator camAnim;
    [SerializeField] private GameObject UICanvas;
    [SerializeField] private GameObject PauseCanvas;
    [SerializeField] private GameManager gm;

    public void Pause()
    {
        if (!gm.busted)
        {
            UICanvas.SetActive(false);
            camAnim.Play("pause");
            gm.isPaused = true;
            PauseCanvas.SetActive(true);
        }
    }

    public void Unpause()
    {
        UICanvas.SetActive(true);
        camAnim.Play("unpause");
        gm.isPaused = false;
        PauseCanvas.SetActive(false);
    }
}