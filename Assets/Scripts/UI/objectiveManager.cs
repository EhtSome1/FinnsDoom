using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class objectiveManager : MonoBehaviour
{
    GameObject player;
    GameObject ovi;
    GameObject secondMapDeathCounter;
    GameObject finalMapDoor;
    GameObject finalMapDeathCounter;

    public switchWeapon SwitchWeapon;
    public TextMeshProUGUI text;
    canOpenDoor door;
    deathcounter secondMapDeathCounterScript;
    deathcounter finalMapDeathCounterScript;
    buttoncheck buttons;

    bool changeObjective2 = false;
    bool changeObjective3 = false;
    bool changeObjective4 = false;
    bool changeObjective5 = false;
    public bool inBattle;

    // all objective texts
    string[] firstMapObjectives = {"Get The Saltgun", "Get The Key", "Get To The Door" };
    string[] SecondMapObjectives = {"Get The Shotgun And Kill All Enemies!", "Get To Next Level Through The Door!"};
    string[] thirdMapObjectives = {"Get To The Top Of The Tower!" };
    string[] finalMapObjectives = {"Find All Three Buttons", "Go Prepairing Room To Prepaire To Save The Bucket", "KILL THE ALL!!!", "Get The Bucket"};

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
        // Set all objectives for all levels
        if (SceneManager.GetActiveScene().name == "The_first_Map")
        {
            if (door == null)
            {
                getNeededFirstMap();
            }
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
            if (secondMapDeathCounter == null)
            {
                getNeededSecondMap();
            }

            if (!SwitchWeapon.hasShotgun)
            {
                secondObjective1();
            }

            if (secondMapDeathCounterScript.deadEnemys == secondMapDeathCounterScript.needed_deaths && !changeObjective4)
            {

                secondObjective2();
                changeObjective4 = true;
            }
        }
        if (SceneManager.GetActiveScene().name == "the_fourth_map")
        {
            thirdObjective1();
        }
        if (SceneManager.GetActiveScene().name == "The_Final_Map")
        {
            if (finalMapDoor == null)
            {
                getNeededFinalMap();
            }
            if (!buttons.A_Button && !buttons.B_Button && !buttons.C_Button)
            {
                finalObjective1();
            }
            if (buttons.A_Button && buttons.B_Button && buttons.C_Button && !changeObjective5)
            {
                finalObjective2();
                changeObjective5 = true;
            }
            if (inBattle)
            {
                finalObjective3();
            }
            if (finalMapDeathCounterScript.deadEnemys == finalMapDeathCounterScript.needed_deaths)
            {
                inBattle = false;
                finalObjective4();
            }
        }
    }
    void getNeededFirstMap()
    {
        ovi = GameObject.Find("ovi");
        door = ovi.gameObject.GetComponent<canOpenDoor>();
    }
    void getNeededSecondMap()
    {
        secondMapDeathCounter = GameObject.Find("deathCounter");
        secondMapDeathCounterScript = secondMapDeathCounter.gameObject.GetComponent<deathcounter>();
    }
    void getNeededFinalMap()
    {
        finalMapDoor = GameObject.Find("door");
        buttons = finalMapDoor.gameObject.GetComponent<buttoncheck>();
        finalMapDeathCounter = GameObject.Find("deathCounter");
        finalMapDeathCounterScript = finalMapDeathCounter.gameObject.GetComponent<deathcounter>();
    }
    // first = 1. level      second = 2.level ...
    void firstObjective2()
    {
        text.text = firstMapObjectives[1];
    }
    void firstObjective3()
    {
        text.text = firstMapObjectives[2];
    }
    void secondObjective1()
    {
        text.text = SecondMapObjectives[0];
    }
    void secondObjective2()
    {
        text.text = SecondMapObjectives[1];
    }
    void thirdObjective1()
    {
        text.text = thirdMapObjectives[0];
    }
    void finalObjective1()
    {
        text.text = finalMapObjectives[0];
    }
    void finalObjective2()
    {
        text.text = finalMapObjectives[1];
    }
    void finalObjective3()
    {
        text.text = finalMapObjectives[2];
    }
    void finalObjective4()
    {
        text.text = finalMapObjectives[3];
    }
}
