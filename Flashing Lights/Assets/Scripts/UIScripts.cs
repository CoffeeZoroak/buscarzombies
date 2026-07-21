using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void HPBoost()
    {
        gm.isPaused = false;
        gm.maxhp += 10;
        gm.hp += 10;
        gm.powerup.SetActive(false);
    }

    public void Speed()
    {
        gm.isPaused = false;
        gm.speed += 2;
        gm.powerup.SetActive(false);
    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
