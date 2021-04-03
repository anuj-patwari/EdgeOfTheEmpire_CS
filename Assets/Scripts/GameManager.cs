using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static Characteristics characteristics;
    public static UpgradeScript us;
    public GameObject upgradeGroup;
    public GameObject skillsGroup;
    public bool upgradePhase = false;
    public int brawnValue, agilityValue, intellectValue, cunningValue, willpowerValue, presenceValue;

    // Start is called before the first frame update
    void Start()
    {
        //ReloadGame();
        characteristics = FindObjectOfType<Characteristics>();
        us = FindObjectOfType<UpgradeScript>();
        upgradeGroup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharacterUpgrade()
    {
        if(upgradePhase == false)
        {
            upgradePhase = true;
            upgradeGroup.SetActive(true);
            skillsGroup.SetActive(false);
            characteristics.SetUpgradeButtons();
            us.SetUpgradeButtons();
        }
        else if(upgradePhase == true)
        {
            upgradePhase = false;
            upgradeGroup.SetActive(false);
            skillsGroup.SetActive(true);
            characteristics.SetUpgradeButtons();
        }
    }

    public void SaveGame()
    {
        
    }

    public void ReloadGame()
    {
        
    }
}