using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeObjectFloat : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
      if(GameManager.moveStuff)
      {
          transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, 3), transform.position.z);
      } else {
          transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
      }
    }
}
