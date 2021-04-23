using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public static class SaveSystem
{
    public static GameManager gm;
    public static WeaponsScript ws;

    public static void SaveData(GameManager gm)
    {
        string path = Application.persistentDataPath + "/savefile";

        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(gm);

        binaryFormatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadData()
    {
        string path = Application.persistentDataPath + "/savefile";

        if (File.Exists(path))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = binaryFormatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("No save file found at: " + path);
            return null;
        }
    }
}

[System.Serializable]
//This is where you put the values of everything you want to save.
public class PlayerData
{
    [Header("Characteristics")]
    public int brawnValue;
    public int agilityValue;
    public int intellectValue;
    public int cunningValue;
    public int willpowerValue;
    public int presenceValue;

    [Header ("PlayerSkills")]
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

    [Header("Skills")]
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

    //     WEAPONS
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


    //     CUSTOM SKILLS
    public int numberOfCreatedSkills;
    public string[] customSkillNames = new string [11];
    public string[] customSkillCharacteristics = new string [11];
    public int[] customSkillValues = new int [11];

    public string notes;
    [TextArea(2,5)]public string inventory;


    //     CAREER SKILLS
    public bool careerSkill1;
    public bool careerSkill2;
    public bool careerSkill3;
    public bool careerSkill4;
    public bool careerSkill5;
    public bool careerSkill6;
    public bool careerSkill7;
    public bool careerSkill8;
    public bool careerSkill9;
    public bool careerSkill10;
    public bool careerSkill11;
    public bool careerSkill12;
    public bool careerSkill13;
    public bool careerSkill14;
    public bool careerSkill15;
    public bool careerSkill16;
    public bool careerSkill17;
    public bool careerSkill18;
    public bool careerSkill19;
    public bool careerSkill20;
    public bool careerSkill21;
    public bool careerSkill22;
    public bool careerSkill23;
    public bool careerSkill24;
    public bool careerSkill25;
    public bool careerSkill26;
    public bool careerSkill27;
    public bool careerSkill28;
    public bool careerSkill29;
    public bool careerSkill30;
    public bool careerSkill31;
    public bool careerSkill32;
    public bool careerSkill33;

    
    public PlayerData (GameManager gm)
    {
        //     CHARACTERISTICS
        brawnValue = gm.brawnValue;
        agilityValue = gm.agilityValue;
        intellectValue = gm.intellectValue;
        cunningValue = gm.cunningValue;
        willpowerValue = gm.willpowerValue;
        presenceValue = gm.presenceValue;


        //     SKILLS
        astrogation = gm.astrogation;
        athletics = gm.athletics;
        charm = gm.charm;
        coercion = gm.coercion;
        computers = gm.computers;
        cool = gm.cool;
        coordination = gm.coordination;
        deception = gm.deception;
        discipline = gm.discipline;
        leadership = gm.leadership;
        mechanics= gm.mechanics;
        medicine = gm.medicine;
        negotiation = gm.negotiation;
        perception = gm.perception;
        pilotingPlanetary = gm.pilotingPlanetary;
        pilotingSpace = gm.pilotingSpace;
        resilience = gm.resilience;
        skullduggery = gm.skullduggery;
        stealth = gm.stealth;
        streetwise = gm.streetwise;
        survival = gm.survival;
        vigilance = gm.vigilance;
        brawl = gm.brawl;
        gunnery = gm.gunnery;
        melee = gm.melee;
        rangedLight = gm.rangedLight;
        rangedHeavy = gm.rangedHeavy;
        coreWorlds = gm.coreWorlds;
        education = gm.education;
        lore = gm.lore;
        outerRim = gm.outerRim;
        underworld = gm.underworld;
        xenology = gm.xenology;


        characterName = gm.characterName;
        speciesName = gm.speciesName;
        career = gm.career;
        specialization = gm.specialization;
        incumberence = gm.incumberence;
        maxIncumberence = gm.maxIncumberence;
        soak = gm.soak;
        wounds = gm.wounds;
        maxWounds = gm.maxWounds;
        strain = gm.strain;
        maxStrain = gm.maxStrain;
        rangedDefense = gm.rangedDefense;
        meleeDefense = gm.meleeDefense;
        creditsHand = gm.creditsHand;
        creditsBank = gm.creditsBank;


        //     WEAPONS
        weapon1 = gm.weapon1;
        weapon2 = gm.weapon2;
        weapon3 = gm.weapon3;
        weapon4 = gm.weapon4;
        weapon5 = gm.weapon5;
        weapon6 = gm.weapon6;
        weapon7 = gm.weapon7;
        weapon8 = gm.weapon8;
        weapon9 = gm.weapon9;
        weapon10 = gm.weapon10;


        //     CUSTOM SKILLS
        numberOfCreatedSkills = gm.numberOfCreatedSkills;
        customSkillNames = gm.customSkillNames;
        customSkillCharacteristics = gm.customSkillCharacteristics;
        customSkillValues = gm.customSkillValues;

        notes = gm.notes;
        inventory = gm.inventory;


        //     CAREER SKILLS
        careerSkill1 = gm.careerSkill1;
        careerSkill2 = gm.careerSkill2;
        careerSkill3 = gm.careerSkill3;
        careerSkill4 = gm.careerSkill4;
        careerSkill5 = gm.careerSkill5;
        careerSkill6 = gm.careerSkill6;
        careerSkill7 = gm.careerSkill7;
        careerSkill8 = gm.careerSkill8;
        careerSkill9 = gm.careerSkill9;
        careerSkill10 = gm.careerSkill10;
        careerSkill11 = gm.careerSkill11;
        careerSkill12 = gm.careerSkill12;
        careerSkill13 = gm.careerSkill13;
        careerSkill14 = gm.careerSkill14;
        careerSkill15 = gm.careerSkill15;
        careerSkill16 = gm.careerSkill16;
        careerSkill17 = gm.careerSkill17;
        careerSkill18 = gm.careerSkill18;
        careerSkill19 = gm.careerSkill19;
        careerSkill20 = gm.careerSkill20;
        careerSkill21 = gm.careerSkill21;
        careerSkill22 = gm.careerSkill22;
        careerSkill23 = gm.careerSkill23;
        careerSkill24 = gm.careerSkill24;
        careerSkill25 = gm.careerSkill25;
        careerSkill26 = gm.careerSkill26;
        careerSkill27 = gm.careerSkill27;
        careerSkill28 = gm.careerSkill28;
        careerSkill29 = gm.careerSkill29;
        careerSkill30 = gm.careerSkill30;
        careerSkill31 = gm.careerSkill31;
        careerSkill32 = gm.careerSkill32;
        careerSkill33 = gm.careerSkill33;
    }
}