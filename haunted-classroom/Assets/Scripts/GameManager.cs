using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // VARIABLES
    float timeUntilNextScare = 0f;
    float scareDuration = 0f;
    int whichScare;

    public Animator door;

    GameObject temp;
    public GameObject zombie;
    public GameObject crawler;

    public AudioSource open;
    public AudioSource close;

    [HideInInspector]
    public static bool moveStuff;

    // Update is called once per frame
    void Update()
    {
        // wait 5 seconds before opening the door!
        if (timeUntilNextScare >= 5f) {

          // choose one of 3 scares at random.
          whichScare = Random.Range(0, 3);

          if (whichScare == 0) {
            ZombieScare();
          } else if (whichScare == 1) {
            FloatingObjectsScare();
          } else if (whichScare == 2) {
            CrawlerScare();
          }

          Debug.Log(whichScare);

          // open door
          door.SetBool("open", true);

          // reset timer
          timeUntilNextScare = 0f;

        }

        // only count to 5 while the door is closed!
        if (!door.GetBool("open") && timeUntilNextScare < 5f) {
          timeUntilNextScare += Time.deltaTime;
        }

        // while the door is open, count to 4 seconds. this will be the length of the "show"
        if (door.GetBool("open") && scareDuration < 4f) {
          scareDuration += Time.deltaTime;
        }

        // show's over. close the door and destroy stuff
        if (scareDuration >= 4f) {
          // close door
          door.SetBool("open", false);

          // reset timer
          scareDuration = 0f;

          // destroy temp gameobject in .4 seconds
          Destroy(temp, 0.4f);
          moveStuff = false;
        }
    }

    void ZombieScare() {
      // spawn zombie
      temp = Instantiate(zombie);
      temp.GetComponent<AudioSource>().Play();
    }

    void FloatingObjectsScare() {
      // this variable is our cue to move. if it equals true, the stuff floats. if not, they stay on the ground.
      moveStuff = true;
    }

    void CrawlerScare() {
      // spawn crawler
      temp = Instantiate(crawler);
    }

    void doorOpenSoundEffect() {
      open.Play();
    }

    void doorCloseSoundEffect() {
      close.Play();
    }
}
