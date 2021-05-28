using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSC : MonoBehaviour
{
    public GameObject Play;
    public GameObject Rule;
    public GameObject Setting;
    public GameObject Quit;

    // Start is called before the first frame update
    void Start()
    {
        Play.GetComponent<Button>().onClick.AddListener(StartPlay);
        Rule.GetComponent<Button>().onClick.AddListener(StartRule);
        Setting.GetComponent<Button>().onClick.AddListener(StartSetting);
        Quit.GetComponent<Button>().onClick.AddListener(StartQuit);
    }

    void StartPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void StartRule()
    {
        SceneManager.LoadScene("intro");
    }

    void StartSetting()
    {
        SceneManager.LoadScene("setting");
    }

    void StartQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
