using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfController : MonoBehaviour
{
    public GameObject boom;
    GameObject boomtemp1;
    GameObject boomtemp;
    public float minBomTime = 2;
    public float maxBomTime = 4;
    private float BomTime = 0;
    public float lastboomtime ;
    private GameObject gameController;
   
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindObjectOfType<GameController>().gameObject;
        lastboomtime = Time.time;
        BomTime = Random.Range(minBomTime, maxBomTime + 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > BomTime + lastboomtime)
        {
            NemBom();
        }
    }
    public void NemBom()
    {
        boomtemp= Instantiate(boom, transform.position, Quaternion.identity);
        UpdateTime();
        gameController.GetComponent<GameController>().GetPoint();
    }
    void UpdateTime()
    {
        lastboomtime = Time.time;
        BomTime = Random.Range(minBomTime, maxBomTime + 1);
    }
   
}
