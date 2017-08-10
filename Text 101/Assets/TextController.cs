using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
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
        text.text = "You try to open the door in vain. It was locked from the outside. " +
            "You have to find something to pick the lock.\n\n"+
            "Press [R] to return";
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
}
