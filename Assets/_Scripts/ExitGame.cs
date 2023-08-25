using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Experimental.UIElements;

public class ExitGame : MonoBehaviour
{
    public GameObject panel;
    public Button cancel;
    public Button exit;

    void Start()
    {
        cancel.onClick.AddListener(Resume);
        exit.onClick.AddListener(Quit);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    void Pause()
    {
        Time.timeScale = 0f;
        panel.SetActive(true);
    }
    void Resume()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
    }

    void Quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif

    }
}
