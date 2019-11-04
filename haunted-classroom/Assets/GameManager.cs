using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float timeUntilNextScare = 0f;
    float scareDuration = 0f;
    int whichScare;

    public Animator door;

    public AudioSource open;
    public AudioSource close;

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
            TwinsScare();
          }

          // open door
          door.SetBool("open", true);

          // reset timer
          timeUntilNextScare = 0f;

          // DEBUG: print result to console
          Debug.Log(whichScare);

        }

        // only count to 5 while the door is closed!
        if (!door.GetBool("open") && timeUntilNextScare < 5f) {
          timeUntilNextScare += Time.deltaTime;
        }

        // while the door is open, count to 4 seconds. this will be the length of the "show"
        if (door.GetBool("open") && scareDuration < 4f) {
          scareDuration += Time.deltaTime;
        }

        // show's over, close the door and destroy stuff
        if (scareDuration >= 4f) {
          // close door
          door.SetBool("open", false);

          // reset timer
          scareDuration = 0f;

          // search scene for gameobjects to destroy, based on random # called earlier (whichScare)
        }
    }

    void ZombieScare() {
      // instantiate zombie

      // play animations
      // and groaning sound effects
    }

    void FloatingObjectsScare() {
      // play desk/chair animations
      // and spooky theme
    }

    void TwinsScare() {
      // instantiate zombie

      // animations? i don't think they need any
      // and creepy laughter sound effects
    }

    void doorOpenSoundEffect() {
      open.Play();
    }
    void doorCloseSoundEffect() {
      close.Play();
    }
}
