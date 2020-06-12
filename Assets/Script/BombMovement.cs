using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMovement : MonoBehaviour
{
    public GameObject target;
    public GameObject wolf;
    public float destroyTime;
    private float lastboomtime = 0;
    Vector3 vector3;
    Vector3 vector;
    public GameObject No;
    // Start is called before the first frame update

    void Start()
    {
        lastboomtime = Time.time;
        target = GameObject.FindObjectOfType<SheepMovement>().gameObject;
        vector =target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>lastboomtime+2)
        {
            vector3 = transform.position;
            Destroy(gameObject);
            No = Instantiate(No, vector3, Quaternion.identity) as GameObject;
            Destroy(No, 0.5f);
        }
        transform.Translate((transform.position - vector) * 1 * Time.deltaTime * -1);
        //Debug.Log(wolf.GetComponent<WolfController>().lastboomtime1);
    }
    
}
