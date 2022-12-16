using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class objectiveManager : MonoBehaviour
{
    GameObject player;
    GameObject Door;

    public switchWeapon SwitchWeapon;

    public TextMeshProUGUI text;
    canOpenDoor door;

    bool changeObjective2 = false;
    bool changeObjective3 = false;

    string[] firstMapObjectives = {"Get The Saltgun", "Get The Key", "Get To The Door" };
    string[] SecondMapObjectives = {"Get the shotgun and kill all enemies!", "Get to next level through the door!"};
    string[] thirdMapObjectives = {"Get to the top of the tower!" };
    string[] finalMapObjectives = { "Find all three buttons", "Go prepairing room to prepaire to save the bucket", "KILL THE ALL!!!" };

    int currentScene;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        SwitchWeapon = player.gameObject.GetComponent<switchWeapon>();

        text.text = firstMapObjectives[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "The_first_Map")
        {
            if (door == null)
            {
                getNeededFirstMap();
            }
            Debug.Log("has saltgun = " + SwitchWeapon.hasSaltgun);

            if (SwitchWeapon.hasSaltgun && !changeObjective2)
            {
                firstObjective2();
                changeObjective2 = true;
            }
            if (door.hasKey && !changeObjective3)
            {
                firstObjective3();
                changeObjective3 = true;
            }
        }
        if (SceneManager.GetActiveScene().name == "The_second_map")
        {

        }
    }
    void getNeededFirstMap()
    {
        Door = GameObject.Find("ovi");
        door = Door.gameObject.GetComponent<canOpenDoor>();
    }

    void firstObjective2()
    {
        text.text = firstMapObjectives[1];
    }
    void firstObjective3()
    {
        text.text = firstMapObjectives[2];
    }
}
