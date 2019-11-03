# MTEC2120_haunted_classroom
Projection mapping + Unity project of a haunted classroom setting.


## How it works:

Wait 5 seconds to open the door. **(timeUntilNextScare)**
Door slams shut after 4 seconds. **(scareDuration)**

There are 3(?) scenarios. **(scareOptions[])**
1. Zombie stands idle in the classroom, notices you watching, then lunges at you
2. Desks and chairs float
3. Creepy twins stare and laugh ominously??

One scenario is selected at random every time the door opens. **(randomRange: 0, 1, 2)**

The room, door, furniture, and outdoor scenery should always remain active (checkbox checked), no matter which scenario is picked.
But any game objects that are unique to the scenario chosen (ex. zombie, twins) should only be activated when the scenario is first called, and deactivated once the timer is up.

## Team members:

* Shequana Garnett - @SilverMew22
* Ekemini Nkanta - @3k3m1n1
* David Calixto - @davidc11
* Quenton Blake - @Quantomcube