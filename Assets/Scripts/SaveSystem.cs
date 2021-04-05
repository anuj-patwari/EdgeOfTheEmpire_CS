using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

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
    
    public PlayerData (GameManager gm)
    {
        brawnValue = gm.brawnValue;
        agilityValue = gm.agilityValue;
        intellectValue = gm.intellectValue;
        cunningValue = gm.cunningValue;
        willpowerValue = gm.willpowerValue;
        presenceValue = gm.presenceValue;


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
    }
}