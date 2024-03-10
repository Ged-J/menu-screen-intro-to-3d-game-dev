using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Animator StartButton;
    public Animator SettingsButton;

    public Animator dialog;
    
    public void StartGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }

    public void OpenSettings()
    {
        StartButton.SetBool("isHidden", true);
        SettingsButton.SetBool("isHidden", true);

        dialog.SetBool("isHidden", false);
    }

    public void CloseSettings()
    {
        StartButton.SetBool("isHidden", false);
        SettingsButton.SetBool("isHidden", false);

        dialog.SetBool("isHidden", true);
    }




}
