using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateSkill : MonoBehaviour
{
    /*public static SkillsScript ss;

    public int newSkillNumber = 1;

    [Header ("Skill Buttons")]
    public Button cs1;
    public Button cs2;
    public Button cs3;
    public Button cs4;
    public Button cs5;
    public Button cs6;
    public Button cs7;
    public Button cs8;
    public Button cs9;
    public Button cs10;
    public Button cs11;

    [Header ("Name of Skills")]
    public InputField newSkillName;
    public string customSkill1Text;
    public string customSkill2Text;
    public string customSkill3Text;
    public string customSkill4Text;
    public string customSkill5Text;
    public string customSkill6Text;
    public string customSkill7Text;
    public string customSkill8Text;
    public string customSkill9Text;
    public string customSkill10Text;
    public string customSkill11Text;

    [Header ("Name of Selected Characteristic")]
    public string selectedChar;
    public string customSkill1Char;
    public string customSkill2Char;
    public string customSkill3Char;
    public string customSkill4Char;
    public string customSkill5Char;
    public string customSkill6Char;
    public string customSkill7Char;
    public string customSkill8Char;
    public string customSkill9Char;
    public string customSkill10Char;
    public string customSkill11Char;


    [Header("Is skill created?")]
    public bool customSkill1Created;
    public bool customSkill2Created;
    public bool customSkill3Created;
    public bool customSkill4Created;
    public bool customSkill5Created;
    public bool customSkill6Created;
    public bool customSkill7Created;
    public bool customSkill8Created;
    public bool customSkill9Created;
    public bool customSkill10Created;
    public bool customSkill11Created;

    [SerializeField] GameObject newSkillGroup;


    // Start is called before the first frame update
    void Start()
    {
        ss = FindObjectOfType<SkillsScript>();

        newSkillGroup.SetActive(false);

        if (customSkill1Created)
        {
            cs1.transform.GetChild(0).GetComponent<Text>().text = customSkill1Text + ": " + ss.customSkill1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenNewSkillMenu()
    {
        customSkill1Created = true;
        newSkillGroup.SetActive(true);
    }
    public void CancelNewSkill()
    {
        selectedChar = "";
        newSkillGroup.SetActive(false);
    }

    public void SelectedCharacteristic(int val)
    {
        if (val == 0)
        {
            selectedChar = " (Brawn)";
        }
        else if (val == 1)
        {
            selectedChar = " (Agility)";
        }
        else if (val == 2)
        {
            selectedChar = " (Intellect)";
        }
        else if (val == 3)
        {
            selectedChar = " (Cunning)";
        }
        else if (val == 4)
        {
            selectedChar = " (Willpower)";
        }
        else if (val == 5)
        {
            selectedChar = " (Presence)";
        }
    }

    public void ConfirmNewSkill()
    {
        if(newSkillNumber == 1)
        {
            customSkill1Text = newSkillName.text;
            customSkill1Char = selectedChar;
            cs1.transform.GetChild(0).GetComponent<Text>().text = customSkill1Text + customSkill1Char;
        }
        newSkillNumber++;
        selectedChar = "";
        newSkillGroup.SetActive(false);
    }*/

    /*public List<string> skillNames = new List<string>();
    public List<string> skillCharacteristics = new List<string>();
    public List<int> skillValues = new List<int>();

    public InputField skillName;
    public InputField skillCharacteristic;
    public InputField skillValue;

    public void CreateSkills()
    {
        skillNames.Add(skillName.text);
        skillCharacteristics.Add(skillCharacteristic.text);
        //skillValues.Add(skillValue.text);
        int.Parse(skillValue.text);
    }*/

    public static GameManager gm;

    [SerializeField] GameObject selectedButton;

    [SerializeField] GameObject newSkillGroup;
    [SerializeField] InputField newSkillName;
    [SerializeField] InputField newSkillChar;
    [SerializeField] InputField newSkillVal;
    bool creatingSkillPhase = false;
    public int skillNumber;
    public GameObject skillToCreate;
    int numberOfCreatedSkills = 0;
    public GameObject parentObject;

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
            numberOfCreatedSkills++;

            if(numberOfCreatedSkills < 11)
            {
                newSkillButton.SetActive(true);
            }

            creatingSkillPhase = false;
            newSkillName.text = "";
            newSkillChar.text = "";
            newSkillVal.text = "";
            newSkillGroup.SetActive(false);
        }
    }
}
