using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "classList/baseClasses")]
public class CharacterStats : ScriptableObject
{
    public int hpValue;
    // enumerations baybey. Technically secret arrays lol
    public enum characterClasses {rizzard,warrior,rogue};
    public characterClasses currentClass;
    
    public int _rizzLevels;
    public int rizzLevels
    {
        get{return _rizzLevels;}
        set{
            _rizzLevels = value;
            playerRizzChange();
        }
    }
    
    private string _currentName;
    public string currentName
    {
        get{return _currentName;}
        set{
            _currentName = value;
            playerNameChange();
        }
    }

    [Header("DEFAULT VALUES")]
    [SerializeField]
    private int defaultHP = 10;
    [SerializeField]
    private characterClasses defaultClass = characterClasses.rizzard;
    [SerializeField]
    private int defaultRizz = -20;
    [SerializeField]
    private string defaultName = "defaultCharacter";

    public void ResetPlayer()
    {
        hpValue = defaultHP;
        currentClass = defaultClass;
        rizzLevels = defaultRizz;
        currentName = defaultName;
    }

    void Start()
    {
        ResetPlayer();
    }

    public event Action playerNameChange;
    public event Action playerRizzChange;
}
