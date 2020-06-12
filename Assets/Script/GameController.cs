using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject textPoint;
    public GameObject button;
    public GameObject panel;
    public GameObject wolf;
    private GameObject bomb;
    public int diem;
    public bool isQuit;
    // Start is called before the first frame update
    void Start()
    {
        isQuit = false;
        diem = 0;
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(diem);
    }
    public void GetPoint()
    {
       diem++;
       textPoint.GetComponent<Text>().text = diem.ToString();
    }
    public void EndGame()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
        button.GetComponent<Button>().onClick.AddListener(Click);
    }
    public void Click()
    {
        SceneManager.LoadScene(0);
    }
}
