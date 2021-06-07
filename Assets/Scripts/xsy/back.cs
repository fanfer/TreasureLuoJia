using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class back : MonoBehaviour
{
    public GameObject Back;
    // Start is called before the first frame update
    void Start()
    {
        Back.GetComponent<Button>().onClick.AddListener(StartBack);
    }

    void StartBack()
    {
        SceneManager.LoadScene("menu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
