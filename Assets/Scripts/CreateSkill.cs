using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateSkill : MonoBehaviour
{
    public static GameManager gm;

    [SerializeField] GameObject selectedButton;

    [SerializeField] GameObject newSkillGroup;
    [SerializeField] InputField newSkillName;
    [SerializeField] InputField newSkillChar;
    [SerializeField] InputField newSkillVal;
    bool creatingSkillPhase = false;
    public int skillNumber;
    public GameObject skillToCreate;
    public GameObject parentObject;

    public GameObject upgradeButton;

    [SerializeField] GameObject newSkillButton;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    public void SelectedButton(GameObject button)
    {
        selectedButton = button;
        newSkillButton = button.GetComponent<CreateSkill>().newSkillButton;
    }

    public void OpenNewSkillMenu()
    {
        newSkillGroup.SetActive(true);
        creatingSkillPhase = true;
        skillNumber = selectedButton.GetComponent<CreateSkill>().skillNumber;
        upgradeButton = selectedButton.GetComponent<CreateSkill>().upgradeButton;
    }

    public void CancelNewSkill()
    {
        newSkillGroup.SetActive(false);
        creatingSkillPhase = false;
    }

    public void ConfirmingNewSkill()
    {
        if(newSkillChar.text == "Brawn" || newSkillChar.text == "Agility" || newSkillChar.text == "Intellect" || newSkillChar.text == "Cunning" || newSkillChar.text == "Willpower" || newSkillChar.text == "Presence")
        {
            if(skillNumber == 0)
            {
                gm.customSkillNames[0] = newSkillName.text;
                gm.customSkillCharacteristics[0] = newSkillChar.text;
                gm.customSkillValues[0] = int.Parse(newSkillVal.text);
            }
            else if(skillNumber == 1)
            {
                gm.customSkillNames[1] = newSkillName.text;
                gm.customSkillCharacteristics[1] = newSkillChar.text;
                gm.customSkillValues[1] = int.Parse(newSkillVal.text);
            }
            else if(skillNumber == 2)
            {
                gm.customSkillNames[2] = newSkillName.text;
                gm.customSkillCharacteristics[2] = newSkillChar.text;
                gm.customSkillValues[2] = int.Parse(newSkillVal.text);
            }
            else if(skillNumber == 3)
            {
                gm.customSkillNames[3] = newSkillName.text;
                gm.customSkillCharacteristics[3] = newSkillChar.text;
                gm.customSkillValues[3] = int.Parse(newSkillVal.text);
            }
            else if(skillNumber == 4)
            {
                gm.customSkillNames[4] = newSkillName.text;
                gm.customSkillCharacteristics[4] = newSkillChar.text;
                gm.customSkillValues[4] = int.Parse(newSkillVal.text);
            }
            else if(skillNumber == 5)
            {
                gm.customSkillNames[5] = newSkillName.text;
                gm.customSkillCharacteristics[5] = newSkillChar.text;
                gm.customSkillValues[5] = int.Parse(newSkillVal.text);
            }
            else if(skillNumber == 6)
            {
                gm.customSkillNames[6] = newSkillName.text;
                gm.customSkillCharacteristics[6] = newSkillChar.text;
                gm.customSkillValues[6] = int.Parse(newSkillVal.text);
            }
            else if(skillNumber == 7)
            {
                gm.customSkillNames[7] = newSkillName.text;
                gm.customSkillCharacteristics[7] = newSkillChar.text;
                gm.customSkillValues[7] = int.Parse(newSkillVal.text);
            }
            else if(skillNumber == 8)
            {
                gm.customSkillNames[8] = newSkillName.text;
                gm.customSkillCharacteristics[8] = newSkillChar.text;
                gm.customSkillValues[8] = int.Parse(newSkillVal.text);
            }
            else if(skillNumber == 9)
            {
                gm.customSkillNames[9] = newSkillName.text;
                gm.customSkillCharacteristics[9] = newSkillChar.text;
                gm.customSkillValues[9] = int.Parse(newSkillVal.text);
            }
            else if(skillNumber == 10)
            {
                gm.customSkillNames[10] = newSkillName.text;
                gm.customSkillCharacteristics[10] = newSkillChar.text;
                gm.customSkillValues[10] = int.Parse(newSkillVal.text);
            }
            Instantiate(skillToCreate, selectedButton.transform.position, selectedButton.transform.rotation, parentObject.transform);
            Destroy(selectedButton);
            gm.numberOfCreatedSkills++;
            upgradeButton.SetActive(true);
            upgradeButton.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[skillNumber] + " (" + gm.customSkillCharacteristics[skillNumber] + "): " + gm.customSkillValues[skillNumber];

            if(gm.numberOfCreatedSkills < 11)
            {
                newSkillButton.SetActive(true);
            }

            creatingSkillPhase = false;
            newSkillName.text = "";
            newSkillChar.text = "";
            newSkillVal.text = "";
            newSkillGroup.SetActive(false);
            gm.SaveGame();
        }
    }
}
