using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static Characteristics characteristics;
    public static WeaponsScript ws;
    public static UpgradeScript us;
    public GameObject upgradeGroup;
    public GameObject skillsGroup;
    public bool upgradePhase = false;


    [Header ("Player Details Objects")]
    [SerializeField] InputField characterNameText;
    [SerializeField] InputField speciesNameText;
    [SerializeField] InputField careerText;
    [SerializeField] InputField specializationText;
    [SerializeField] InputField incumberenceText;
    [SerializeField] InputField maxIncumberenceText;
    [SerializeField] InputField soakText;
    [SerializeField] InputField woundsText;
    [SerializeField] InputField maxWoundsText;
    [SerializeField] InputField strainText;
    [SerializeField] InputField maxStrainText;
    [SerializeField] InputField rangedDefenseText;
    [SerializeField] InputField meleeDefenseText;
    [SerializeField] InputField creditsHandText;
    [SerializeField] InputField creditsBankText;

    [Header ("Player Details")]
    public string characterName;
    public string speciesName;
    public string career;
    public string specialization;
    public string incumberence;
    public string maxIncumberence;
    public string soak;
    public string wounds;
    public string maxWounds;
    public string strain;
    public string maxStrain;
    public string rangedDefense;
    public string meleeDefense;
    public string creditsHand;
    public string creditsBank;

    [Header("Player Characteristics")]
    public int brawnValue;
    public int agilityValue;
    public int intellectValue;
    public int cunningValue;
    public int willpowerValue;
    public int presenceValue;

    [Header ("Weapons")]
    public string[] weapon1 = new string [6];
    public string[] weapon2 = new string [6];
    public string[] weapon3 = new string [6];
    public string[] weapon4 = new string [6];
    public string[] weapon5 = new string [6];
    public string[] weapon6 = new string [6];
    public string[] weapon7 = new string [6];
    public string[] weapon8 = new string [6];
    public string[] weapon9 = new string [6];
    public string[] weapon10 = new string [6];

    // Start is called before the first frame update
    void Start()
    {
        ws = FindObjectOfType<WeaponsScript>();
        ReloadGame();
        characteristics = FindObjectOfType<Characteristics>();
        us = FindObjectOfType<UpgradeScript>();
        upgradeGroup.SetActive(false);        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp (KeyCode.Return))
        {
            PlayerDetails();
            SaveGame();
        }
    }

    public void PlayerDetails()
    {
        characterName = characterNameText.text;
        speciesName = speciesNameText.text;
        career = careerText.text;
        specialization = specializationText.text;
        incumberence = incumberenceText.text;
        maxIncumberence = maxIncumberenceText.text;
        soak = soakText.text;
        wounds = woundsText.text;
        maxWounds = maxWoundsText.text;
        strain = strainText.text;
        maxStrain = maxStrainText.text;
        rangedDefense = rangedDefenseText.text;
        meleeDefense = meleeDefenseText.text;
        creditsHand = creditsHandText.text;
        creditsBank = creditsBankText.text;
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
        SaveSystem.SaveData(this);
    }

    public void ReloadGame()
    {
        PlayerData data = SaveSystem.LoadData();

        brawnValue = data.brawnValue;
        agilityValue = data.agilityValue;
        intellectValue = data.intellectValue;
        cunningValue = data.cunningValue;
        willpowerValue = data.willpowerValue;
        presenceValue = data.presenceValue;

        characterName = data.characterName;
        speciesName = data.speciesName;
        career = data.career;
        specialization = data.specialization;
        incumberence = data.incumberence;
        maxIncumberence = data.maxIncumberence;
        soak = data.soak;
        wounds = data.wounds;
        maxWounds = data.maxWounds;
        strain = data.strain;
        maxStrain = data.maxStrain;
        rangedDefense = data.rangedDefense;
        meleeDefense = data.meleeDefense;
        creditsHand = data.creditsHand;
        creditsBank = data.creditsBank;


        characterNameText.text = characterName;
        speciesNameText.text = speciesName;
        careerText.text = career;
        specializationText.text = specialization;
        incumberenceText.text = incumberence;
        maxIncumberenceText.text = maxIncumberence;
        soakText.text = soak;
        woundsText.text = wounds;
        maxWoundsText.text = maxWounds;
        strainText.text = strain;
        maxStrainText.text = maxStrain;
        rangedDefenseText.text = rangedDefense;
        meleeDefenseText.text = meleeDefense;
        creditsHandText.text = creditsHand;
        creditsBankText.text = creditsBank;



        //     WEAPONS
        //     RELOADING ARRAYS FROM SAVE FILE
        weapon1 = data.weapon1;
        weapon2 = data.weapon2;
        weapon3 = data.weapon3;
        weapon4 = data.weapon4;
        weapon5 = data.weapon5;
        weapon6 = data.weapon6;
        weapon7 = data.weapon7;
        weapon8 = data.weapon8;
        weapon9 = data.weapon9;
        weapon10 = data.weapon10;

        //     CHANGING TEXT BASED ON SAVE FILE
        ws.weapon1Text.text = weapon1[0];
        ws.skill1Text.text = weapon1[1];
    }
}