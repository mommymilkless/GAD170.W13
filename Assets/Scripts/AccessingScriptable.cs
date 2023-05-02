using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessingScriptable : MonoBehaviour
{
    public scriptableInt linkMachine;
    public CharacterStats playerStats;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(linkMachine.theInt);
        Debug.Log($"Henlo sluts, my name is {playerStats.currentName}");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("a"))
        {
            playerStats.currentName="Joseph the Rizzless";
        }

        if(Input.GetKeyDown("b"))
        {
            playerStats.rizzLevels=-20;
        }
    }
}
