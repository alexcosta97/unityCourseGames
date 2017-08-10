using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0, stairs_0, closet_door, floor, corridor_1, stairs_1, in_closet,
            corridor_2, stairs_2, corridor_3, courtyard};
    private States sceneState;

	// Use this for initialization
	void Start () {
        sceneState = States.cell;
        text.text = "Welcome to Text101, a word adventure game.\n\n" +
            "Press space to continue";
	}
	
	// Update is called once per frame
	void Update () {
        print(sceneState);
        switch (sceneState)
        {
            case States.cell:
                state_cell();
                break;
            case States.sheets_0:
                state_sheets0();
                break;
            case States.lock_0:
                state_lock0();
                break;
            case States.mirror:
                state_mirror();
                break;
            case States.cell_mirror:
                state_cell_mirror();
                break;
            case States.sheets_1:
                state_sheets1();
                break;
            case States.lock_1:
                state_lock1();
                break;
            case States.corridor_0:
                state_corridor0();
                break;
            case States.floor:
                state_floor();
                break;
            case States.stairs_0:
                state_stairs0();
                break;
            case States.corridor_1:
                state_corridor1();
                break;
            case States.in_closet:
                state_in_closet();
                break;
            case States.stairs_1:
                state_stairs_1();
                break;
            case States.corridor_2:
                state_corridor2();
                break;
            case States.stairs_2:
                state_stairs2();
                break;
            case States.corridor_3:
                state_corridor3();
                break;
            case States.courtyard:
                state_courtyard();
                break;
        }
	}

    //method to be ran the first time the user is inside the cell (first state of game)
    private void state_cell()
    {
        text.text = "You are locked up on a prison cell, but you must escape " +
                 "because the city of Ogygia is about to fall. You look at your right " +
                 "and you see your bed with the sheets. You look at you left and there " +
                 "is a broken mirror. In front of you is the door.\n\n" +
                 "Press [S] to go to the bed sheets, [M] to go to the mirror and [L] to go to " +
                 "the door lock";
        if (Input.GetKeyDown(KeyCode.S))
            sceneState = States.sheets_0;
        else if (Input.GetKeyDown(KeyCode.M))
            sceneState = States.mirror;
        else if (Input.GetKeyDown(KeyCode.L))
        {
            sceneState = States.lock_0;
        }
    }

    //Runs when the user first tries to look at the sheets
    private void state_sheets0()
    {
        text.text = "You could use the sheets to escape from the window, but you " +
            "can't break the grille on the window and the sheets aren't long enough " +
            "to avoid a dangerous fall.\n\n" +
            "Press [R] to return";
        if (Input.GetKeyDown(KeyCode.R))
            sceneState = States.cell;
    }

    //Runs when the user first tries to look at the lock
    private void state_lock0()
    {
        text.text = "This is one of those button locks. You have no idea what the " +
                    "combination is. You wish you could somehow see where the dirty " +
                    "fingerprints were, maybe that would help.\n\n" +
                    "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
            sceneState = States.cell;
    }

    //Runs when the user looks at the mirror
    private void state_mirror()
    {
        text.text = "You look at your reflection and think about your situation. " +
            "If you don't get out of here soon you will be dead. You become desperate " +
            "and punch the mirror, and, as if it was a revelation, its broken pieces " +
            "reminded you of the lock picks you used on the old cars. This is your gateaway.\n\n" +
            "Press [T] to take a broken piece of the mirror";

        if (Input.GetKeyDown(KeyCode.T))
            sceneState = States.cell_mirror;
    }

    //Runs when the user goes back to the cell with the piece of mirror
    private void state_cell_mirror()
    {
        text.text = "You are back in the middle of your cell and you have the broken piece of mirror. " +
            "What are you going to do now?\n\n" +
            "Press [S] to look at the sheets or [L] to look at the lock";
        if (Input.GetKeyDown(KeyCode.S))
            sceneState = States.sheets_1;
        else if (Input.GetKeyDown(KeyCode.L))
            sceneState = States.lock_1;
    }

    //Runs when the user has the mirror and looks at the sheets
    private void state_sheets1()
    {
        text.text = "You could use the sheets to get out through the window, " +
            "but you can't break the grilles outside of it, and it is too high " +
            "of a fall. Besides, you now have the piece of broken mirror.\n\n" +
            "Press [R] to return to the center of the cell";

        if (Input.GetKeyDown(KeyCode.R))
            sceneState = States.cell_mirror;
    }

    //Runs when the user goes to the lock after picking up the mirror
    private void state_lock1()
    {
        text.text = "You carefully put the mirror through the bars, and turn it round " +
            "so you can see the lock. You can just make out fingerprints around " +
            "the buttons. You press the dirty buttons, and hear a click.\n\n" +
            "Press O to Open, or R to Return to your cell";

        if (Input.GetKeyDown(KeyCode.O))
            sceneState = States.corridor_0;
        else if (Input.GetKeyDown(KeyCode.R))
            sceneState = States.cell_mirror;
    }

    //Runs when the user has gotten out of the cell
    private void state_corridor0()
    {
        text.text = "You got out of your cell and now you're in the middle " +
            "of a corridor. You hide away in a corner and look at your options. " +
            "There are some stairs and a closet and the floor in front of you.\n\n" +
            "Press [S] to go to the stairs, [F] to inspect the floor, [C] to go to the closet";

        if (Input.GetKeyDown(KeyCode.S))
            sceneState = States.stairs_0;
        else if (Input.GetKeyDown(KeyCode.F))
            sceneState = States.floor;
        else if (Input.GetKeyDown(KeyCode.C))
            sceneState = States.closet_door;
    }

    //Runs when the user looks at the stairs from corridor_0
    private void state_stairs0()
    {
        text.text = "You look at the stairs and know that they lead to "+
            "the courtyard. If you go outside with your inmate clothes you "+
            "know that you will be recognized straight away.\n\n" +
            "Press [R] to return to your hideout";

        if (Input.GetKeyDown(KeyCode.R))
            sceneState = States.corridor_0;
    }

    //Runs when the user inspects the floor from corridor_0
    private void state_floor()
    {
        text.text = "You look at the floor in front of you. You find a " +
            "hairclip at the middle of the corridor, just by the closet. " +
            "You know that that may be useful and think that it might help " +
            "you to pick it up.\n\n" +
            "Press [H] to pick the hair clip up or [R] to return to your hideout";

        if (Input.GetKeyDown(KeyCode.H))
            sceneState = States.corridor_1;
        else if (Input.GetKeyDown(KeyCode.R))
            sceneState = States.corridor_0;
    }

    //Runs when the user looks at the closet from corridor_0
    private void state_closet_door()
    {
        text.text = "You go to the closet and try to open it. The door is closed. " +
            "Thankfully, it has a very simple lock that you could easily pick " +
            "if only you had something to pick it.\n\n" +
            "Press [R] to return to your hideout";

        if (Input.GetKeyDown(KeyCode.R))
            sceneState = States.corridor_0;
    }

    //Runs when the user has picked up the hairclip
    private void state_corridor1()
    {
        text.text = "You return to your hideout. You now have a hairclip that you " +
            "could use to pick a lock. Where could you use it?\n\n" +
            "Press [S] to look at the stairs or [P] to pick the closet door";

        if (Input.GetKeyDown(KeyCode.S))
            sceneState = States.stairs_1;
        else if (Input.GetKeyDown(KeyCode.P))
            sceneState = States.in_closet;
    }

    //Runs when the user looks at the stairs from corridor_1
    private void state_stairs_1()
    {
        text.text = "You look at the stairs, now with that hairclip in your " +
            "hands. It won't change the fact that you will be recognized as an " +
            "inmate.\n\n" +
            "Press [R] to return to your hideout";

        if (Input.GetKeyDown(KeyCode.R))
            sceneState = States.corridor_1;
    }

    //Runs when the user picks the closet door
    private void state_in_closet()
    {
        text.text = "You go to the closet with the hairclip, look around to make " +
            "sure that no one is around and start picking the lock. After a few " +
            "very stressful minutes, you finally manage to unlock the door. " +
            "There are some janitor clothes inside it.\n\n" +
            "Press [R] to go back to the corridor or [D] to get dressed";

        if (Input.GetKeyDown(KeyCode.R))
            sceneState = States.corridor_2;
        else if (Input.GetKeyDown(KeyCode.D))
            sceneState = States.corridor_3;
    }

    //Runs when the user goes back to the corridor after picking the closet
    private void state_corridor2()
    {
        text.text = "You can get changed to the janitors clothes, " +
            "or try your luck and go outside with your inmate clothes.\n\n" +
            "Press [S] to try your luck or [B] to go back to the closet";

        if (Input.GetKeyDown(KeyCode.S))
            sceneState = States.stairs_2;
        else if (Input.GetKeyDown(KeyCode.B))
            sceneState = States.in_closet;
    }

    //Runs when the user tries to go out the stairs without changing in corridor_2
    private void state_stairs2()
    {
        text.text = "You are just about to go up the stairs and try your " +
            "chance and go up the stairs, but then you stop and think for " +
            "a second. You know that you will be found out as soon as you " +
            "get out.\n\n" +
            "Press [R] to go back to the corridor";

        if (Input.GetKeyDown(KeyCode.R))
            sceneState = States.corridor_2;
    }

    //Runs when the user has changed the character's clothes
    private void state_corridor3()
    {
        text.text = "You just got dressed as a janitor. Even though " +
            "the clothes have a really strong bleach smell, you know " +
            "that you won't be recognized whilst wearing those.\n\n" +
            "Press [U] to undress or [S] to go up the stairs";

        if (Input.GetKeyDown(KeyCode.U))
            sceneState = States.in_closet;
        else if (Input.GetKeyDown(KeyCode.S))
            sceneState = States.courtyard;
    }

    //Runs when the user goes out the stairs after corridor_3
    private void state_courtyard()
    {
        text.text = "You are now out in the courtyard and no one has " +
            "recognized you. You crossed it and went outside without any " +
            "trouble. You are now free from the Ogygia prison!\n\n" +
            "Press [P] to play again";

        if (Input.GetKeyDown(KeyCode.P))
            sceneState = States.cell;
    }
}
