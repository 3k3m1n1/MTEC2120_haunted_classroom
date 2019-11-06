using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDeskAndChair : MonoBehaviour
{
    //public GameObject DeskAndChairprefab;
    GameObject DeskAndChair;
    void Start()
    {
      // DeskAndChair = Instantiate(DeskAndChairprefab, new Vector3(transform.position.x,transform.position.y,transform.position.z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, 2), transform.position.z);
    }
}
