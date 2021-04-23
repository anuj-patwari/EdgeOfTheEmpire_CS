using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static Characteristics characteristics;
    public static WeaponsScript ws;
    public static UpgradeScript us;
    public static CreateSkill cs;
    public static NewSkill ns;
    public static SkillsScript ss;

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

    [Header ("Player Skills")]
    public int astrogation;
    public int athletics;
    public int charm; 
    public int coercion;
    public int computers;
    public int cool;
    public int coordination;
    public int deception;
    public int discipline;
    public int leadership;
    public int mechanics;
    public int medicine;
    public int negotiation;
    public int perception;
    public int pilotingPlanetary;
    public int pilotingSpace;
    public int resilience;
    public int skullduggery;
    public int stealth;
    public int streetwise;
    public int survival;
    public int vigilance;
    public int brawl;
    public int gunnery;
    public int melee;
    public int rangedLight;
    public int rangedHeavy;
    public int coreWorlds;
    public int education;
    public int lore;
    public int outerRim;
    public int underworld;
    public int xenology;

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

    [Header("Custom Skills")]
    public int numberOfCreatedSkills = 0;
    public string[] customSkillNames = new string [11];
    public string[] customSkillCharacteristics = new string [11];
    public int[] customSkillValues = new int [11];

    [SerializeField] GameObject saveFileLocation;

    public TMP_InputField notesText;
    [TextArea(2,5)]public string notes;
    public TMP_InputField inventoryText;
    [TextArea(2,5)]public string inventory;

    // Start is called before the first frame update
    void Start()
    {
        ws = FindObjectOfType<WeaponsScript>();
        cs = FindObjectOfType<CreateSkill>();
        ns = FindObjectOfType<NewSkill>();
        ss = FindObjectOfType<SkillsScript>();
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
            SaveGame();
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Delete))
        {
            if (File.Exists(Application.persistentDataPath + "/savefile"))
            {
                File.Delete(Application.persistentDataPath + "/savefile");
                saveFileLocation.SetActive(true);
                saveFileLocation.GetComponent<Text>().text = "Save file has been deleted.";
                StartCoroutine(SaveFileLocation(5));
            }
        }
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
            skillsGroup.SetActive(true);
            characteristics.SetUpgradeButtons();
            ss.UpgradePhaseCompleted();
            upgradeGroup.SetActive(false);
        }
    }

    public void SaveGame()
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
        notes = notesText.text;
        inventory = inventoryText.text;
        
        SaveSystem.SaveData(this);
        
        saveFileLocation.SetActive(true);
        saveFileLocation.GetComponent<Text>().text = "Save file located at: " + Application.persistentDataPath + "/savefile";
        StartCoroutine(SaveFileLocation(5));

    }

    IEnumerator SaveFileLocation(float delay)
    {
        yield return new WaitForSeconds(delay);
        saveFileLocation.SetActive(false);
    }

    public void ReloadGame()
    {
        PlayerData data = SaveSystem.LoadData();
        if (data != null)
        {
            //     CHARACTERISTICS
            brawnValue = data.brawnValue;
            agilityValue = data.agilityValue;
            intellectValue = data.intellectValue;
            cunningValue = data.cunningValue;
            willpowerValue = data.willpowerValue;
            presenceValue = data.presenceValue;


            //     SKILLS
            astrogation = data.astrogation;
            athletics = data.athletics;
            charm = data.charm;
            coercion = data.coercion;
            computers = data.computers;
            cool = data.cool;
            coordination = data.coordination;
            deception = data.deception;
            discipline = data.discipline;
            leadership = data.leadership;
            mechanics= data.mechanics;
            medicine = data.medicine;
            negotiation = data.negotiation;
            perception = data.perception;
            pilotingPlanetary = data.pilotingPlanetary;
            pilotingSpace = data.pilotingSpace;
            resilience = data.resilience;
            skullduggery = data.skullduggery;
            stealth = data.stealth;
            streetwise = data.streetwise;
            survival = data.survival;
            vigilance = data.vigilance;
            brawl = data.brawl;
            gunnery = data.gunnery;
            melee = data.melee;
            rangedLight = data.rangedLight;
            rangedHeavy = data.rangedHeavy;
            coreWorlds = data.coreWorlds;
            education = data.education;
            lore = data.lore;
            outerRim = data.outerRim;
            underworld = data.underworld;
            xenology = data.xenology;


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

            //     CUSTOM SKILLS
            numberOfCreatedSkills = data.numberOfCreatedSkills;
            customSkillNames = data.customSkillNames;
            customSkillCharacteristics = data.customSkillCharacteristics;
            customSkillValues = data.customSkillValues;

            if(numberOfCreatedSkills >= 1)
            {
                ss.custom1Button.SetActive(true);
                Destroy(ss.customCreator1);
                ss.custom1Button.GetComponent<NewSkill>().skillName = customSkillNames[0];
                ss.custom1Button.GetComponent<NewSkill>().skillChar = customSkillCharacteristics[0];
                ss.custom1Button.GetComponent<NewSkill>().skillValue = customSkillValues[0];
                ss.custom1Button.GetComponent<NewSkill>().upgradeButton.SetActive(true);
                if(numberOfCreatedSkills == 1)
                {
                    ss.customCreator2.SetActive(true);
                }
            }
            if(numberOfCreatedSkills >= 2)
            {
                ss.custom2Button.SetActive(true);
                Destroy(ss.customCreator2);
                ss.custom2Button.GetComponent<NewSkill>().skillName = customSkillNames[1];
                ss.custom2Button.GetComponent<NewSkill>().skillChar = customSkillCharacteristics[1];
                ss.custom2Button.GetComponent<NewSkill>().skillValue = customSkillValues[1];
                ss.custom2Button.GetComponent<NewSkill>().upgradeButton.SetActive(true);
                if(numberOfCreatedSkills == 2)
                {
                    ss.customCreator3.SetActive(true);
                }
            }
            if(numberOfCreatedSkills >= 3)
            {
                ss.custom3Button.SetActive(true);
                Destroy(ss.customCreator3);
                ss.custom3Button.GetComponent<NewSkill>().skillName = customSkillNames[2];
                ss.custom3Button.GetComponent<NewSkill>().skillChar = customSkillCharacteristics[2];
                ss.custom3Button.GetComponent<NewSkill>().skillValue = customSkillValues[2];
                if(numberOfCreatedSkills == 3)
                {
                    ss.customCreator4.SetActive(true);
                }
            }
            if(numberOfCreatedSkills >= 4)
            {
                ss.custom4Button.SetActive(true);
                Destroy(ss.customCreator4);
                ss.custom4Button.GetComponent<NewSkill>().skillName = customSkillNames[3];
                ss.custom4Button.GetComponent<NewSkill>().skillChar = customSkillCharacteristics[3];
                ss.custom4Button.GetComponent<NewSkill>().skillValue = customSkillValues[3];
                if(numberOfCreatedSkills == 4)
                {
                    ss.customCreator5.SetActive(true);
                }
            }
            if(numberOfCreatedSkills >= 5)
            {
                ss.custom5Button.SetActive(true);
                Destroy(ss.customCreator5);
                ss.custom5Button.GetComponent<NewSkill>().skillName = customSkillNames[4];
                ss.custom5Button.GetComponent<NewSkill>().skillChar = customSkillCharacteristics[4];
                ss.custom5Button.GetComponent<NewSkill>().skillValue = customSkillValues[4];
                if(numberOfCreatedSkills == 5)
                {
                    ss.customCreator6.SetActive(true);
                }
            }
            if(numberOfCreatedSkills >= 6)
            {
                ss.custom6Button.SetActive(true);
                Destroy(ss.customCreator6);
                ss.custom6Button.GetComponent<NewSkill>().skillName = customSkillNames[5];
                ss.custom6Button.GetComponent<NewSkill>().skillChar = customSkillCharacteristics[5];
                ss.custom6Button.GetComponent<NewSkill>().skillValue = customSkillValues[5];
                if(numberOfCreatedSkills == 6)
                {
                    ss.customCreator7.SetActive(true);
                }
            }
            if(numberOfCreatedSkills >= 7)
            {
                ss.custom7Button.SetActive(true);
                Destroy(ss.customCreator7);
                ss.custom7Button.GetComponent<NewSkill>().skillName = customSkillNames[6];
                ss.custom7Button.GetComponent<NewSkill>().skillChar = customSkillCharacteristics[6];
                ss.custom7Button.GetComponent<NewSkill>().skillValue = customSkillValues[6];
                if(numberOfCreatedSkills == 7)
                {
                    ss.customCreator8.SetActive(true);
                }
            }
            if(numberOfCreatedSkills >= 8)
            {
                ss.custom8Button.SetActive(true);
                Destroy(ss.customCreator8);
                ss.custom8Button.GetComponent<NewSkill>().skillName = customSkillNames[7];
                ss.custom8Button.GetComponent<NewSkill>().skillChar = customSkillCharacteristics[7];
                ss.custom8Button.GetComponent<NewSkill>().skillValue = customSkillValues[7];
                if(numberOfCreatedSkills == 8)
                {
                    ss.customCreator9.SetActive(true);
                }
            }
            if(numberOfCreatedSkills >= 9)
            {
                ss.custom9Button.SetActive(true);
                Destroy(ss.customCreator9);
                ss.custom9Button.GetComponent<NewSkill>().skillName = customSkillNames[8];
                ss.custom9Button.GetComponent<NewSkill>().skillChar = customSkillCharacteristics[8];
                ss.custom9Button.GetComponent<NewSkill>().skillValue = customSkillValues[8];
                if(numberOfCreatedSkills == 9)
                {
                    ss.customCreator10.SetActive(true);
                }
            }
            if(numberOfCreatedSkills >= 10)
            {
                ss.custom10Button.SetActive(true);
                Destroy(ss.customCreator10);
                ss.custom10Button.GetComponent<NewSkill>().skillName = customSkillNames[9];
                ss.custom10Button.GetComponent<NewSkill>().skillChar = customSkillCharacteristics[9];
                ss.custom10Button.GetComponent<NewSkill>().skillValue = customSkillValues[9];
                if(numberOfCreatedSkills == 10)
                {
                    ss.customCreator11.SetActive(true);
                }
            }
            if(numberOfCreatedSkills >= 11)
            {
                ss.custom11Button.SetActive(true);
                Destroy(ss.customCreator11);
                ss.custom11Button.GetComponent<NewSkill>().skillName = customSkillNames[10];
                ss.custom11Button.GetComponent<NewSkill>().skillChar = customSkillCharacteristics[10];
                ss.custom11Button.GetComponent<NewSkill>().skillValue = customSkillValues[10];
            }

            notes = data.notes;
            notesText.text = notes;
            inventory = data.inventory;
            inventoryText.text = inventory;
        }
    }
}