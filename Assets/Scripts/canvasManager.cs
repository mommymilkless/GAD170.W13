using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class canvasManager : MonoBehaviour
{
    public CharacterStats playerLink;
    public TextMeshProUGUI playerName;
    public TextMeshProUGUI playerRizz;
    public GameObject awardForJoe;
    // Start is called before the first frame update
    void Start()
    {
        // Subscribing to the event
        playerLink.playerNameChange+=ChangeName;
        playerLink.playerRizzChange+=ChangeRizz;
    }

    public void ChangeName()
    {
        playerName.text = playerLink.currentName;
    }

    public void ChangeRizz()
    {
        playerRizz.text = $"Your rizz is {playerLink.rizzLevels} you fucking loser";
    }

    void Update()
    {
        if(Input.GetKeyDown("c"))
        {
            awardForJoe.SetActive(true);
        }
    }
}
