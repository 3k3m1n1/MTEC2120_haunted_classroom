# MTEC2120: Haunted Classroom
Projection mapping + Unity project of a door to a haunted classroom.


## Outline:

1. Wait 5 seconds. **(timeUntilNextScare)**

2. Then, open the door & select a scenario at random:
  * Zombie stands twitching in the classroom, notices you watching him, and lunges at you.
  * Desks and chairs float around the room.
  * Creepy twins stare and laugh ominously. (maybe)

3. Instantiate/enable any GameObjects specific to that scenario. (Zombie, twins, etc.)

4. Start a timer for 4 seconds. **(scareDuration)**

5. Play the creepy animations & sound effects for the chosen scenario.

6. When **scareDuration** runs out, slam the door shut and destroy those GameObjects. 

7. Repeat.

## Team members:

* Shequana Garnett - @SilverMew22
* Ekemini Nkanta - @3k3m1n1
* David Calixto - @davidc11
* Quenton Blake - @Quantomcube
