using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewSkill : MonoBehaviour
{
    public static CreateSkill cs;
    public static GameManager gm;
    public static DiceScript ds;
    public static SkillsScript ss;

    public string skillName;
    public string skillChar;
    public int skillValue;
    public int skillNumber;

    public GameObject upgradeButton;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        cs = FindObjectOfType<CreateSkill>();
        ds = FindObjectOfType<DiceScript>();
        ss = FindObjectOfType<SkillsScript>();

        //skillNumber = cs.skillNumber;
        //upgradeButton = cs.upgradeButton;

        if(skillNumber >= 0)
        {
            skillName = gm.customSkillNames[skillNumber];
            skillChar = gm.customSkillCharacteristics[skillNumber];
            skillValue = gm.customSkillValues[skillNumber];
            //upgradeButton.SetActive(true);
            gameObject.transform.GetChild(0).GetComponent<Text>().text = skillName + " (" + skillChar + "): " + skillValue;
            ss.custom1Button = gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpgradePhaseCompleted()
    {
        if(skillNumber >= 0)
        {
            skillName = gm.customSkillNames[skillNumber];
            skillChar = gm.customSkillCharacteristics[skillNumber];
            skillValue = gm.customSkillValues[skillNumber];
            //upgradeButton.SetActive(true);
            gameObject.transform.GetChild(0).GetComponent<Text>().text = skillName + " (" + skillChar + "): " + skillValue;
            ss.custom1Button = gameObject;
        }
    }

    public void ExecuteSkill()
    {
        if (skillChar == "Brawn")
        {
            if(skillValue <= gm.brawnValue)
            {
                ds.greenDie = gm.brawnValue - skillValue;
                ds.yellowDie = skillValue;
            }
            else if (skillValue > gm.brawnValue)
            {
                ds.greenDie = skillValue - gm.brawnValue;
                ds.yellowDie = gm.brawnValue;
            }
        }
        else if (skillChar == "Agility")
        {
            if(skillValue <= gm.agilityValue)
            {
                ds.greenDie = gm.agilityValue - skillValue;
                ds.yellowDie = skillValue;
            }
            else if (skillValue > gm.agilityValue)
            {
                ds.greenDie = skillValue - gm.agilityValue;
                ds.yellowDie = gm.agilityValue;
            }
        }
        else if (skillChar == "Intellect")
        {
            if(skillValue <= gm.intellectValue)
            {
                ds.greenDie = gm.intellectValue - skillValue;
                ds.yellowDie = skillValue;
            }
            else if (skillValue > gm.intellectValue)
            {
                ds.greenDie = skillValue - gm.intellectValue;
                ds.yellowDie = gm.intellectValue;
            }
        }
        else if (skillChar == "Cunning")
        {
            if(skillValue <= gm.cunningValue)
            {
                ds.greenDie = gm.cunningValue - skillValue;
                ds.yellowDie = skillValue;
            }
            else if (skillValue > gm.cunningValue)
            {
                ds.greenDie = skillValue - gm.cunningValue;
                ds.yellowDie = gm.cunningValue;
            }
        }
        else if (skillChar == "Willpower")
        {
            if(skillValue <= gm.willpowerValue)
            {
                ds.greenDie = gm.willpowerValue - skillValue;
                ds.yellowDie = skillValue;
            }
            else if (skillValue > gm.willpowerValue)
            {
                ds.greenDie = skillValue - gm.willpowerValue;
                ds.yellowDie = gm.willpowerValue;
            }
        }
        else if (skillChar == "Presence")
        {
            if(skillValue <= gm.presenceValue)
            {
                ds.greenDie = gm.presenceValue - skillValue;
                ds.yellowDie = skillValue;
            }
            else if (skillValue > gm.presenceValue)
            {
                ds.greenDie = skillValue - gm.presenceValue;
                ds.yellowDie = gm.presenceValue;
            }
        }
        ds.PlayDice();
    }

}
