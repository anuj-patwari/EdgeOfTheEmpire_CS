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
        print ("Game has been saved!");
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
        ws.damage1Text.text = weapon1[2];
        ws.range1Text.text = weapon1[3];
        ws.crit1Text.text = weapon1[4];
        ws.special1Text.text = weapon1[5];
        
        ws.weapon2Text.text = weapon2[0];
        ws.skill2Text.text = weapon2[1];
        ws.damage2Text.text = weapon2[2];
        ws.range2Text.text = weapon2[3];
        ws.crit2Text.text = weapon2[4];
        ws.special2Text.text = weapon2[5];

        ws.weapon3Text.text = weapon3[0];
        ws.skill3Text.text = weapon3[1];
        ws.damage3Text.text = weapon3[2];
        ws.range3Text.text = weapon3[3];
        ws.crit3Text.text = weapon3[4];
        ws.special3Text.text = weapon3[5];

        ws.weapon4Text.text = weapon4[0];
        ws.skill4Text.text = weapon4[1];
        ws.damage4Text.text = weapon4[2];
        ws.range4Text.text = weapon4[3];
        ws.crit4Text.text = weapon4[4];
        ws.special4Text.text = weapon4[5];

        ws.weapon5Text.text = weapon5[0];
        ws.skill5Text.text = weapon5[1];
        ws.damage5Text.text = weapon5[2];
        ws.range5Text.text = weapon5[3];
        ws.crit5Text.text = weapon5[4];
        ws.special5Text.text = weapon5[5];

        ws.weapon6Text.text = weapon6[0];
        ws.skill6Text.text = weapon6[1];
        ws.damage6Text.text = weapon6[2];
        ws.range6Text.text = weapon6[3];
        ws.crit6Text.text = weapon6[4];
        ws.special6Text.text = weapon6[5];

        ws.weapon7Text.text = weapon7[0];
        ws.skill7Text.text = weapon7[1];
        ws.damage7Text.text = weapon7[2];
        ws.range7Text.text = weapon7[3];
        ws.crit7Text.text = weapon7[4];
        ws.special7Text.text = weapon7[5];

        ws.weapon8Text.text = weapon8[0];
        ws.skill8Text.text = weapon8[1];
        ws.damage8Text.text = weapon8[2];
        ws.range8Text.text = weapon8[3];
        ws.crit8Text.text = weapon8[4];
        ws.special8Text.text = weapon8[5];

        ws.weapon9Text.text = weapon9[0];
        ws.skill9Text.text = weapon9[1];
        ws.damage9Text.text = weapon9[2];
        ws.range9Text.text = weapon9[3];
        ws.crit9Text.text = weapon9[4];
        ws.special9Text.text = weapon9[5];	

        ws.weapon10Text.text = weapon10[0];
        ws.skill10Text.text = weapon10[1];
        ws.damage10Text.text = weapon10[2];
        ws.range10Text.text = weapon10[3];
        ws.crit10Text.text = weapon10[4];
        ws.special10Text.text = weapon10[5];	
    }
}