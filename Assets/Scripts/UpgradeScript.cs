using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeScript : MonoBehaviour
{
    public static GameManager gm;
    public static Characteristics characteristics;
    public static SkillsScript ss;

    [SerializeField] GameObject skillsGroup;

    [SerializeField] Button brawnButton, agilityButton, intellectButton, cunningButton, willpowerButton, presenceButton;
    [SerializeField] GameObject astrogationButton, athleticsButton, charmButton, coercionButton, computersButton, coolButton, coordinationButton, deceptionButton, disciplineButton, leadershipButton, mechanicsButton, medicineButton, negotiationButton, perceptionButton, pilotingPlanetaryButton, pilotingSpaceButton, resilienceButton, skullduggeryButton, stealthButton, streetwiseButton, survivalButton, vigilanceButton, brawlButton, gunneryButton, meleeButton, rangedLightButton, rangedHeavyButton, coreWorldsButton, educationButton, loreButton, outerRimButton, underworldButton, xenologyButton, custom1Button, custom2Button, custom3Button, custom4Button, custom5Button, custom6Button, custom7Button, custom8Button, custom9Button, custom10Button, custom11Button;
    [SerializeField] GameObject upgradeUI;
    int valueToAdd = 0;
    [SerializeField] Text valueToAddText;
    string characteristicType;

    // Start is called before the first frame update
    void Awake()
    {
        gm = FindObjectOfType<GameManager>();
        characteristics = FindObjectOfType<Characteristics>();
        ss = FindObjectOfType<SkillsScript>();

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(GetSkillsValues(0.02f));
    }

    IEnumerator GetSkillsValues(float delay)
    {
        yield return new WaitForSeconds(delay);
        astrogationButton.transform.GetChild(0).GetComponent<Text>().text = "Astrogation (Intellect): " + skillsGroup.GetComponent<SkillsScript>().astrogation;
        athleticsButton.transform.GetChild(0).GetComponent<Text>().text = "Athletics (Brawn): " + skillsGroup.GetComponent<SkillsScript>().athletics;
        charmButton.transform.GetChild(0).GetComponent<Text>().text = "Charm (Presence): " + skillsGroup.GetComponent<SkillsScript>().charm;
        coercionButton.transform.GetChild(0).GetComponent<Text>().text = "Coercion (Willpower): " + skillsGroup.GetComponent<SkillsScript>().coercion;
        computersButton.transform.GetChild(0).GetComponent<Text>().text = "Computers (Intellect): " + skillsGroup.GetComponent<SkillsScript>().computers;
        coolButton.transform.GetChild(0).GetComponent<Text>().text = "Cool (Presence): " + skillsGroup.GetComponent<SkillsScript>().cool;
        coordinationButton.transform.GetChild(0).GetComponent<Text>().text = "Coordination (Agility): " + skillsGroup.GetComponent<SkillsScript>().coordination;
        deceptionButton.transform.GetChild(0).GetComponent<Text>().text = "Deception (Cunning): " + skillsGroup.GetComponent<SkillsScript>().deception;
        disciplineButton.transform.GetChild(0).GetComponent<Text>().text = "Discipline (Willpower): " + skillsGroup.GetComponent<SkillsScript>().discipline;
        leadershipButton.transform.GetChild(0).GetComponent<Text>().text = "Leadership (Presence): " + skillsGroup.GetComponent<SkillsScript>().leadership;
        mechanicsButton.transform.GetChild(0).GetComponent<Text>().text = "Mechanics (Intellect): " + skillsGroup.GetComponent<SkillsScript>().mechanics;
        medicineButton.transform.GetChild(0).GetComponent<Text>().text = "Medicine (Intellect): " + skillsGroup.GetComponent<SkillsScript>().medicine;
        negotiationButton.transform.GetChild(0).GetComponent<Text>().text = "Negotiation (Presence): " + skillsGroup.GetComponent<SkillsScript>().negotiation;
        perceptionButton.transform.GetChild(0).GetComponent<Text>().text = "Perception (Cunning): " + skillsGroup.GetComponent<SkillsScript>().perception;
        pilotingPlanetaryButton.transform.GetChild(0).GetComponent<Text>().text = "Piloting - Planetary (Agility): " + skillsGroup.GetComponent<SkillsScript>().pilotingPlanetary;
        pilotingSpaceButton.transform.GetChild(0).GetComponent<Text>().text = "Piloting - Space (Agility): " + skillsGroup.GetComponent<SkillsScript>().pilotingSpace;
        resilienceButton.transform.GetChild(0).GetComponent<Text>().text = "Resilience (Brawn): " + skillsGroup.GetComponent<SkillsScript>().resilience;
        skullduggeryButton.transform.GetChild(0).GetComponent<Text>().text = "Skullduggery (Cunning): " + skillsGroup.GetComponent<SkillsScript>().skullduggery;
        stealthButton.transform.GetChild(0).GetComponent<Text>().text = "Stealth (Agility): " + skillsGroup.GetComponent<SkillsScript>().stealth;
        streetwiseButton.transform.GetChild(0).GetComponent<Text>().text = "Streetwise (Cunning): " + skillsGroup.GetComponent<SkillsScript>().streetwise;
        survivalButton.transform.GetChild(0).GetComponent<Text>().text = "Survival (Cunning): " + skillsGroup.GetComponent<SkillsScript>().survival;
        vigilanceButton.transform.GetChild(0).GetComponent<Text>().text = "Vigilance (Willpower): " + skillsGroup.GetComponent<SkillsScript>().vigilance;
        brawlButton.transform.GetChild(0).GetComponent<Text>().text = "Brawl (Brawn): " + skillsGroup.GetComponent<SkillsScript>().brawl;
        gunneryButton.transform.GetChild(0).GetComponent<Text>().text = "Gunnery (Agility): " + skillsGroup.GetComponent<SkillsScript>().gunnery;
        meleeButton.transform.GetChild(0).GetComponent<Text>().text = "Melee (Brawn): " + skillsGroup.GetComponent<SkillsScript>().melee;
        rangedLightButton.transform.GetChild(0).GetComponent<Text>().text = "Ranged - Light (Agility): " + skillsGroup.GetComponent<SkillsScript>().rangedLight;
        rangedHeavyButton.transform.GetChild(0).GetComponent<Text>().text = "Ranged - Heavy (Agility): " + skillsGroup.GetComponent<SkillsScript>().rangedHeavy;
        coreWorldsButton.transform.GetChild(0).GetComponent<Text>().text = "Core Worlds (Intellect): " + skillsGroup.GetComponent<SkillsScript>().coreWorlds;
        educationButton.transform.GetChild(0).GetComponent<Text>().text = "Education (Intellect): " + skillsGroup.GetComponent<SkillsScript>().education;
        loreButton.transform.GetChild(0).GetComponent<Text>().text = "Lore (Intellect): " + skillsGroup.GetComponent<SkillsScript>().lore;
        outerRimButton.transform.GetChild(0).GetComponent<Text>().text = "Outer Rim (Intellect): " + skillsGroup.GetComponent<SkillsScript>().outerRim;
        underworldButton.transform.GetChild(0).GetComponent<Text>().text = "Underworld (Intellect): " + skillsGroup.GetComponent<SkillsScript>().underworld;
        xenologyButton.transform.GetChild(0).GetComponent<Text>().text = "Xenology (Intellect): " + skillsGroup.GetComponent<SkillsScript>().xenology;

        custom1Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[0] + " (" + gm.customSkillCharacteristics[0] + "): " + gm.customSkillValues[0];
        custom2Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[1] + " (" + gm.customSkillCharacteristics[1] + "): " + gm.customSkillValues[1];
        custom3Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[2] + " (" + gm.customSkillCharacteristics[2] + "): " + gm.customSkillValues[2];
        custom4Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[3] + " (" + gm.customSkillCharacteristics[3] + "): " + gm.customSkillValues[3];
        custom5Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[4] + " (" + gm.customSkillCharacteristics[4] + "): " + gm.customSkillValues[4];
        custom6Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[5] + " (" + gm.customSkillCharacteristics[5] + "): " + gm.customSkillValues[5];
        custom7Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[6] + " (" + gm.customSkillCharacteristics[6] + "): " + gm.customSkillValues[6];
        custom8Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[7] + " (" + gm.customSkillCharacteristics[7] + "): " + gm.customSkillValues[7];
        custom9Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[8] + " (" + gm.customSkillCharacteristics[8] + "): " + gm.customSkillValues[8];
        custom10Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[9] + " (" + gm.customSkillCharacteristics[9] + "): " + gm.customSkillValues[9];
        custom11Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[10] + " (" + gm.customSkillCharacteristics[10] + "): " + gm.customSkillValues[10];
    }

    public void SetUpgradeButtons()
    {
        brawnButton.transform.GetChild(0).GetComponent<Text>().text = "Brawn: " + gm.brawnValue;
        agilityButton.transform.GetChild(0).GetComponent<Text>().text = "Agility: " + gm.agilityValue;
        intellectButton.transform.GetChild(0).GetComponent<Text>().text = "Intellect: " + gm.intellectValue;
        cunningButton.transform.GetChild(0).GetComponent<Text>().text = "Cunning: " + gm.cunningValue;
        willpowerButton.transform.GetChild(0).GetComponent<Text>().text = "Willpower: " + gm.willpowerValue;
        presenceButton.transform.GetChild(0).GetComponent<Text>().text = "Presence: " + gm.presenceValue;



        custom1Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[0] + " (" + gm.customSkillCharacteristics[0] + "): " + gm.customSkillValues[0];
        custom2Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[1] + " (" + gm.customSkillCharacteristics[1] + "): " + gm.customSkillValues[1];
        custom3Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[2] + " (" + gm.customSkillCharacteristics[2] + "): " + gm.customSkillValues[2];
        custom4Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[3] + " (" + gm.customSkillCharacteristics[3] + "): " + gm.customSkillValues[3];
        custom5Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[4] + " (" + gm.customSkillCharacteristics[4] + "): " + gm.customSkillValues[4];
        custom6Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[5] + " (" + gm.customSkillCharacteristics[5] + "): " + gm.customSkillValues[5];
        custom7Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[6] + " (" + gm.customSkillCharacteristics[6] + "): " + gm.customSkillValues[6];
        custom8Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[7] + " (" + gm.customSkillCharacteristics[7] + "): " + gm.customSkillValues[7];
        custom9Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[8] + " (" + gm.customSkillCharacteristics[8] + "): " + gm.customSkillValues[8];
        custom10Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[9] + " (" + gm.customSkillCharacteristics[9] + "): " + gm.customSkillValues[9];
        custom11Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[10] + " (" + gm.customSkillCharacteristics[10] + "): " + gm.customSkillValues[10];
    }

    public void EnableUpgradeUI(string pressed)
    {
        upgradeUI.SetActive(true);
        if (pressed == "Brawn")
        {
            characteristicType = "Brawn";
            valueToAdd = gm.brawnValue;
        }
        else if (pressed == "Agility")
        {
            characteristicType = "Agility";
            valueToAdd = gm.agilityValue;
        }
        else if (pressed == "Intellect")
        {
            characteristicType = "Intellect";
            valueToAdd = gm.intellectValue;
        }
        else if (pressed == "Cunning")
        {
            characteristicType = "Cunning";
            valueToAdd = gm.cunningValue;
        }
        else if (pressed == "Willpower")
        {
            characteristicType = "Willpower";
            valueToAdd = gm.willpowerValue;
        }
        else if (pressed == "Presence")
        {
            characteristicType = "Presence";
            valueToAdd = gm.presenceValue;
        }



        else if (pressed == "Astrogation")
        {
            characteristicType = pressed;
            valueToAdd = ss.astrogation;
        }
        else if (pressed == "Athletics")
        {
            characteristicType = pressed;
            valueToAdd = ss.athletics;
        }
        else if (pressed == "Charm")
        {
            characteristicType = pressed;
            valueToAdd = ss.charm;
        }
        else if (pressed == "Coercion")
        {
            characteristicType = pressed;
            valueToAdd = ss.coercion;
        }
        else if (pressed == "Computers")
        {
            characteristicType = pressed;
            valueToAdd = ss.computers;
        }
        else if (pressed == "Cool")
        {
            characteristicType = pressed;
            valueToAdd = ss.cool;
        }
        else if (pressed == "Coordination")
        {
            characteristicType = pressed;
            valueToAdd = ss.coordination;
        }
        else if (pressed == "Deception")
        {
            characteristicType = pressed;
            valueToAdd = ss.deception;
        }
        else if (pressed == "Discipline")
        {
            characteristicType = pressed;
            valueToAdd = ss.discipline;
        }
        else if (pressed == "Leadership")
        {
            characteristicType = pressed;
            valueToAdd = ss.leadership;
        }
        else if (pressed == "Mechanics")
        {
            characteristicType = pressed;
            valueToAdd = ss.mechanics;
        }
        else if (pressed == "Medicine")
        {
            characteristicType = pressed;
            valueToAdd = ss.medicine;
        }
        else if (pressed == "Negotiation")
        {
            characteristicType = pressed;
            valueToAdd = ss.negotiation;
        }
        else if (pressed == "Perception")
        {
            characteristicType = pressed;
            valueToAdd = ss.perception;
        }
        else if (pressed == "Piloting - Planetary")
        {
            characteristicType = pressed;
            valueToAdd = ss.pilotingPlanetary;
        }
        else if (pressed == "Piloting - Space")
        {
            characteristicType = pressed;
            valueToAdd = ss.pilotingSpace;
        }
        else if (pressed == "Resilience")
        {
            characteristicType = pressed;
            valueToAdd = ss.resilience;
        }
        else if (pressed == "Skullduggery")
        {
            characteristicType = pressed;
            valueToAdd = ss.skullduggery;
        }
        else if (pressed == "Stealth")
        {
            characteristicType = pressed;
            valueToAdd = ss.stealth;
        }
        else if (pressed == "Streetwise")
        {
            characteristicType = pressed;
            valueToAdd = ss.streetwise;
        }
        else if (pressed == "Survival")
        {
            characteristicType = pressed;
            valueToAdd = ss.survival;
        }
        else if (pressed == "Vigilance")
        {
            characteristicType = pressed;
            valueToAdd = ss.vigilance;
        }
        else if (pressed == "Brawl")
        {
            characteristicType = pressed;
            valueToAdd = ss.brawl;
        }
        else if (pressed == "Gunnery")
        {
            characteristicType = pressed;
            valueToAdd = ss.gunnery;
        }
        else if (pressed == "Melee")
        {
            characteristicType = pressed;
            valueToAdd = ss.melee;
        }
        else if (pressed == "Ranged - Light")
        {
            characteristicType = pressed;
            valueToAdd = ss.rangedLight;
        }
        else if (pressed == "Ranged - Heavy")
        {
            characteristicType = pressed;
            valueToAdd = ss.rangedHeavy;
        }
        else if (pressed == "Core Worlds")
        {
            characteristicType = pressed;
            valueToAdd = ss.coreWorlds;
        }
        else if (pressed == "Education")
        {
            characteristicType = pressed;
            valueToAdd = ss.education;
        }
        else if (pressed == "Lore")
        {
            characteristicType = pressed;
            valueToAdd = ss.lore;
        }
        else if (pressed == "Outer Rim")
        {
            characteristicType = pressed;
            valueToAdd = ss.outerRim;
        }
        else if (pressed == "Underworld")
        {
            characteristicType = pressed;
            valueToAdd = ss.underworld;
        }
        else if (pressed == "Xenology")
        {
            characteristicType = pressed;
            valueToAdd = ss.xenology;
        }
        else if (pressed == "Custom1")
        {
            characteristicType = pressed;
            valueToAdd = gm.customSkillValues[0];
        }
        else if (pressed == "Custom2")
        {
            characteristicType = pressed;
            valueToAdd = gm.customSkillValues[1];
        }
        else if (pressed == "Custom3")
        {
            characteristicType = pressed;
            valueToAdd = gm.customSkillValues[2];
        }
        else if (pressed == "Custom4")
        {
            characteristicType = pressed;
            valueToAdd = gm.customSkillValues[3];
        }
        else if (pressed == "Custom5")
        {
            characteristicType = pressed;
            valueToAdd = gm.customSkillValues[4];
        }
        else if (pressed == "Custom6")
        {
            characteristicType = pressed;
            valueToAdd = gm.customSkillValues[5];
        }
        else if (pressed == "Custom7")
        {
            characteristicType = pressed;
            valueToAdd = gm.customSkillValues[6];
        }
        else if (pressed == "Custom8")
        {
            characteristicType = pressed;
            valueToAdd = gm.customSkillValues[7];
        }
        else if (pressed == "Custom9")
        {
            characteristicType = pressed;
            valueToAdd = gm.customSkillValues[8];
        }
        else if (pressed == "Custom10")
        {
            characteristicType = pressed;
            valueToAdd = gm.customSkillValues[9];
        }
        else if (pressed == "Custom11")
        {
            characteristicType = pressed;
            valueToAdd = gm.customSkillValues[10];
        }
        if (characteristicType != "Custom1" || characteristicType != "Custom2" || characteristicType != "Custom3" || characteristicType != "Custom4" || characteristicType != "Custom5" || characteristicType != "Custom6" || characteristicType != "Custom7" || characteristicType != "Custom8" || characteristicType != "Custom9" || characteristicType != "Custom10" || characteristicType != "Custom11")
        {
            valueToAddText.text = characteristicType + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom1")
        {
            valueToAddText.text = gm.customSkillNames[0] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom2")
        {
            valueToAddText.text = gm.customSkillNames[1] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom3")
        {
            valueToAddText.text = gm.customSkillNames[2] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom4")
        {
            valueToAddText.text = gm.customSkillNames[3] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom5")
        {
            valueToAddText.text = gm.customSkillNames[4] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom6")
        {
            valueToAddText.text = gm.customSkillNames[5] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom7")
        {
            valueToAddText.text = gm.customSkillNames[6] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom8")
        {
            valueToAddText.text = gm.customSkillNames[7] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom9")
        {
            valueToAddText.text = gm.customSkillNames[8] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom10")
        {
            valueToAddText.text = gm.customSkillNames[9] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom11")
        {
            valueToAddText.text = gm.customSkillNames[10] + ": " + valueToAdd.ToString();
        }
    }

    public void CancelledUpgrade()
    {
        upgradeUI.SetActive(false);
        valueToAdd = 0;
    }

    public void ConfirmingAddValue()
    {
        if (characteristicType == "Brawn")
        {
            gm.brawnValue = valueToAdd;
            characteristics.brawnText.text = "Brawn: " + gm.brawnValue;
            brawnButton.transform.GetChild(0).GetComponent<Text>().text = "Brawn: " + gm.brawnValue;
        }
        else if (characteristicType == "Agility")
        {
            gm.agilityValue = valueToAdd;
            characteristics.agilityText.text = "Agility: " + gm.agilityValue;
            agilityButton.transform.GetChild(0).GetComponent<Text>().text = "Agility: " + gm.agilityValue;
        }
        else if (characteristicType == "Intellect")
        {
            gm.intellectValue = valueToAdd;
            characteristics.intellectText.text = "Cunning: " + gm.intellectValue;
            intellectButton.transform.GetChild(0).GetComponent<Text>().text = "Intellect: " + gm.intellectValue;
        }
        else if (characteristicType == "Cunning")
        {
            gm.cunningValue = valueToAdd;
            characteristics.cunningText.text = "Cunning: " + gm.cunningValue;
            cunningButton.transform.GetChild(0).GetComponent<Text>().text = "Cunning: " + gm.cunningValue;
        }
        else if (characteristicType == "Willpower")
        {
            gm.willpowerValue = valueToAdd;
            characteristics.willpowerText.text = "Willpower: " + gm.willpowerValue;
            willpowerButton.transform.GetChild(0).GetComponent<Text>().text = "Willpower: " + gm.willpowerValue;
        }
        else if (characteristicType == "Presence")
        {
            gm.presenceValue = valueToAdd;
            characteristics.presenceText.text = "Presence: " + gm.presenceValue;
            presenceButton.transform.GetChild(0).GetComponent<Text>().text = "Presence: " + gm.presenceValue;
        }



        else if (characteristicType == "Astrogation")
        {
            ss.astrogation = valueToAdd;
            gm.astrogation = valueToAdd;
        }
        else if (characteristicType == "Athletics")
        {
            ss.athletics = valueToAdd;
            gm.athletics = valueToAdd;
        }
        else if (characteristicType == "Charm")
        {
            ss.charm = valueToAdd;
            gm.charm = valueToAdd;
        }
        else if (characteristicType == "Coercion")
        {
            ss.coercion = valueToAdd;
            gm.coercion = valueToAdd;
        }
        else if (characteristicType == "Computers")
        {
            ss.computers = valueToAdd;
            gm.computers = valueToAdd;
        }
        else if (characteristicType == "Cool")
        {
            ss.cool = valueToAdd;
            gm.cool = valueToAdd;
        }
        else if (characteristicType == "Coordination")
        {
            ss.coordination = valueToAdd;
            gm.coordination = valueToAdd;
        }
        else if (characteristicType == "Deception")
        {
            ss.deception = valueToAdd;
            gm.deception = valueToAdd;
        }
        else if (characteristicType == "Discipline")
        {
            ss.discipline = valueToAdd;
            gm.discipline = valueToAdd;
        }
        else if (characteristicType == "Leadership")
        {
            ss.leadership = valueToAdd;
            gm.leadership = valueToAdd;
        }
        else if (characteristicType == "Mechanics")
        {
            ss.mechanics = valueToAdd;
            gm.mechanics = valueToAdd;
        }
        else if (characteristicType == "Medicine")
        {
            ss.medicine = valueToAdd;
            gm.medicine = valueToAdd;
        }
        else if (characteristicType == "Negotiation")
        {
            ss.negotiation = valueToAdd;
            gm.negotiation = valueToAdd;
        }
        else if (characteristicType == "Perception")
        {
            ss.perception = valueToAdd;
            gm.perception = valueToAdd;
        }
        else if (characteristicType == "Piloting - Planetary")
        {
            ss.pilotingPlanetary = valueToAdd;
            gm.pilotingPlanetary = valueToAdd;
        }
        else if (characteristicType == "Piloting - Space")
        {
            ss.pilotingSpace = valueToAdd;
            gm.pilotingSpace = valueToAdd;
        }
        else if (characteristicType == "Resilience")
        {
            ss.resilience = valueToAdd;
            gm.resilience = valueToAdd;
        }
        else if (characteristicType == "Skullduggery")
        {
            ss.skullduggery = valueToAdd;
            gm.skullduggery = valueToAdd;
        }
        else if (characteristicType == "Stealth")
        {
            ss.stealth = valueToAdd;
            gm.stealth = valueToAdd;
        }
        else if (characteristicType == "Streetwise")
        {
            ss.streetwise = valueToAdd;
            gm.streetwise = valueToAdd;
        }
        else if (characteristicType == "Survival")
        {
            ss.survival = valueToAdd;
            gm.survival = valueToAdd;
        }
        else if (characteristicType == "Vigilance")
        {
            ss.vigilance = valueToAdd;
            gm.vigilance = valueToAdd;
        }
        else if (characteristicType == "Brawl")
        {
            ss.brawl = valueToAdd;
            gm.brawl = valueToAdd;
        }
        else if (characteristicType == "Gunnery")
        {
            ss.gunnery = valueToAdd;
            gm.gunnery = valueToAdd;
        }
        else if (characteristicType == "Melee")
        {
            ss.melee = valueToAdd;
            gm.melee = valueToAdd;
        }
        else if (characteristicType == "Ranged - Light")
        {
            ss.rangedLight = valueToAdd;
            gm.rangedLight = valueToAdd;
        }
        else if (characteristicType == "Ranged - Heavy")
        {
            ss.rangedHeavy = valueToAdd;
            gm.rangedHeavy = valueToAdd;
        }
        else if (characteristicType == "Core Worlds")
        {
            ss.coreWorlds = valueToAdd;
            gm.coreWorlds = valueToAdd;
        }
        else if (characteristicType == "Education")
        {
            ss.education = valueToAdd;
            gm.education = valueToAdd;
        }
        else if (characteristicType == "Lore")
        {
            ss.lore = valueToAdd;
            gm.lore = valueToAdd;
        }
        else if (characteristicType == "Outer Rim")
        {
            ss.outerRim = valueToAdd;
            gm.outerRim = valueToAdd;
        }
        else if (characteristicType == "Underworld")
        {
            ss.underworld = valueToAdd;
            gm.underworld = valueToAdd;
        }
        else if (characteristicType == "Xenology")
        {
            ss.xenology = valueToAdd;
            gm.xenology = valueToAdd;
        }
        else if (characteristicType == "Custom1")
        {
            gm.customSkillValues[0] = valueToAdd;
        }
        else if (characteristicType == "Custom2")
        {
            gm.customSkillValues[1] = valueToAdd;
        }
        else if (characteristicType == "Custom3")
        {
            gm.customSkillValues[2] = valueToAdd;
        }
        else if (characteristicType == "Custom4")
        {
            gm.customSkillValues[3] = valueToAdd;
        }
        else if (characteristicType == "Custom5")
        {
            gm.customSkillValues[4] = valueToAdd;
        }
        else if (characteristicType == "Custom6")
        {
            gm.customSkillValues[5] = valueToAdd;
        }
        else if (characteristicType == "Custom7")
        {
            gm.customSkillValues[6] = valueToAdd;
        }
        else if (characteristicType == "Custom8")
        {
            gm.customSkillValues[7] = valueToAdd;
        }
        else if (characteristicType == "Custom9")
        {
            gm.customSkillValues[8] = valueToAdd;
        }
        else if (characteristicType == "Custom10")
        {
            gm.customSkillValues[9] = valueToAdd;
        }
        else if (characteristicType == "Custom11")
        {
            gm.customSkillValues[10] = valueToAdd;
        }


        astrogationButton.transform.GetChild(0).GetComponent<Text>().text = "Astrogation (Intellect): " + ss.astrogation;
        athleticsButton.transform.GetChild(0).GetComponent<Text>().text = "Athletics (Brawn): " + ss.athletics;
        charmButton.transform.GetChild(0).GetComponent<Text>().text = "Charm (Presence): " + ss.charm;
        coercionButton.transform.GetChild(0).GetComponent<Text>().text = "Coercion (Willpower): " + ss.coercion;
        computersButton.transform.GetChild(0).GetComponent<Text>().text = "Computers (Intellect): " + ss.computers;
        coolButton.transform.GetChild(0).GetComponent<Text>().text = "Cool (Presence): " + ss.cool;
        coordinationButton.transform.GetChild(0).GetComponent<Text>().text = "Coordination (Agility): " + ss.coordination;
        deceptionButton.transform.GetChild(0).GetComponent<Text>().text = "Deception (Cunning): " + ss.deception;
        disciplineButton.transform.GetChild(0).GetComponent<Text>().text = "Discipline (Willpower): " + ss.discipline;
        leadershipButton.transform.GetChild(0).GetComponent<Text>().text = "Leadership (Presence): " + ss.leadership;
        mechanicsButton.transform.GetChild(0).GetComponent<Text>().text = "Mechanics (Intellect): " + ss.mechanics;
        medicineButton.transform.GetChild(0).GetComponent<Text>().text = "Medicine (Intellect): " + ss.medicine;
        negotiationButton.transform.GetChild(0).GetComponent<Text>().text = "Negotiation (Presence): " + ss.negotiation;
        perceptionButton.transform.GetChild(0).GetComponent<Text>().text = "Perception (Cunning): " + ss.perception;
        pilotingPlanetaryButton.transform.GetChild(0).GetComponent<Text>().text = "Piloting - Planetary (Agility): " + ss.pilotingPlanetary;
        pilotingSpaceButton.transform.GetChild(0).GetComponent<Text>().text = "Piloting - Space (Agility): " + ss.pilotingSpace;
        resilienceButton.transform.GetChild(0).GetComponent<Text>().text = "Resilience (Brawn): " + ss.resilience;
        skullduggeryButton.transform.GetChild(0).GetComponent<Text>().text = "Skullduggery (Cunning): " + ss.skullduggery;
        stealthButton.transform.GetChild(0).GetComponent<Text>().text = "Stealth (Agility): " + ss.stealth;
        streetwiseButton.transform.GetChild(0).GetComponent<Text>().text = "Streetwise (Cunning): " + ss.streetwise;
        survivalButton.transform.GetChild(0).GetComponent<Text>().text = "Survival (Cunning): " + ss.survival;
        vigilanceButton.transform.GetChild(0).GetComponent<Text>().text = "Vigilance (Willpower): " + ss.vigilance;
        brawlButton.transform.GetChild(0).GetComponent<Text>().text = "Brawl (Brawn): " + ss.brawl;
        gunneryButton.transform.GetChild(0).GetComponent<Text>().text = "Gunnery (Agility): " + ss.gunnery;
        meleeButton.transform.GetChild(0).GetComponent<Text>().text = "Melee (Brawn): " + ss.melee;
        rangedLightButton.transform.GetChild(0).GetComponent<Text>().text = "Ranged - Light (Agility): " + ss.rangedLight;
        rangedHeavyButton.transform.GetChild(0).GetComponent<Text>().text = "Ranged - Heavy (Agility): " + ss.rangedHeavy;
        coreWorldsButton.transform.GetChild(0).GetComponent<Text>().text = "Core Worlds (Intellect): " + ss.coreWorlds;
        educationButton.transform.GetChild(0).GetComponent<Text>().text = "Education (Intellect): " + ss.education;
        loreButton.transform.GetChild(0).GetComponent<Text>().text = "Lore (Intellect): " + ss.lore;
        outerRimButton.transform.GetChild(0).GetComponent<Text>().text = "Outer Rim (Intellect): " + ss.outerRim;
        underworldButton.transform.GetChild(0).GetComponent<Text>().text = "Underworld (Intellect): " + ss.underworld;
        xenologyButton.transform.GetChild(0).GetComponent<Text>().text = "Xenology (Intellect): " + ss.xenology;
        custom1Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[0] + " (" + gm.customSkillCharacteristics[0] + "): " + gm.customSkillValues[0];
        custom2Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[1] + " (" + gm.customSkillCharacteristics[1] + "): " + gm.customSkillValues[1];
        custom3Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[2] + " (" + gm.customSkillCharacteristics[2] + "): " + gm.customSkillValues[2];
        custom4Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[3] + " (" + gm.customSkillCharacteristics[3] + "): " + gm.customSkillValues[3];
        custom5Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[4] + " (" + gm.customSkillCharacteristics[4] + "): " + gm.customSkillValues[4];
        custom6Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[5] + " (" + gm.customSkillCharacteristics[5] + "): " + gm.customSkillValues[5];
        custom7Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[6] + " (" + gm.customSkillCharacteristics[6] + "): " + gm.customSkillValues[6];
        custom8Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[7] + " (" + gm.customSkillCharacteristics[7] + "): " + gm.customSkillValues[7];
        custom9Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[8] + " (" + gm.customSkillCharacteristics[8] + "): " + gm.customSkillValues[8];
        custom10Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[9] + " (" + gm.customSkillCharacteristics[9] + "): " + gm.customSkillValues[9];
        custom11Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[10] + " (" + gm.customSkillCharacteristics[10] + "): " + gm.customSkillValues[10];


        valueToAdd = 0;
        upgradeUI.SetActive(false);
        //ss.UpgradePhaseCompleted();
        gm.SaveGame();
    }

    public void PressingAddButton()
    {
        valueToAdd = valueToAdd + 1;  

        if (characteristicType != "Custom1" || characteristicType != "Custom2" || characteristicType != "Custom3" || characteristicType != "Custom4" || characteristicType != "Custom5" || characteristicType != "Custom6" || characteristicType != "Custom7" || characteristicType != "Custom8" || characteristicType != "Custom9" || characteristicType != "Custom10" || characteristicType != "Custom11")
        {
            valueToAddText.text = characteristicType + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom1")
        {
            valueToAddText.text = gm.customSkillNames[0] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom2")
        {
            valueToAddText.text = gm.customSkillNames[1] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom3")
        {
            valueToAddText.text = gm.customSkillNames[2] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom4")
        {
            valueToAddText.text = gm.customSkillNames[3] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom5")
        {
            valueToAddText.text = gm.customSkillNames[4] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom6")
        {
            valueToAddText.text = gm.customSkillNames[5] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom7")
        {
            valueToAddText.text = gm.customSkillNames[6] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom8")
        {
            valueToAddText.text = gm.customSkillNames[7] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom9")
        {
            valueToAddText.text = gm.customSkillNames[8] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom10")
        {
            valueToAddText.text = gm.customSkillNames[9] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom11")
        {
            valueToAddText.text = gm.customSkillNames[10] + ": " + valueToAdd.ToString();
        }
    }

    public void PressingSubtractButton()
    {
        valueToAdd = valueToAdd - 1;    
        
        if (characteristicType != "Custom1" || characteristicType != "Custom2" || characteristicType != "Custom3" || characteristicType != "Custom4" || characteristicType != "Custom5" || characteristicType != "Custom6" || characteristicType != "Custom7" || characteristicType != "Custom8" || characteristicType != "Custom9" || characteristicType != "Custom10" || characteristicType != "Custom11")
        {
            valueToAddText.text = characteristicType + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom1")
        {
            valueToAddText.text = gm.customSkillNames[0] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom2")
        {
            valueToAddText.text = gm.customSkillNames[1] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom3")
        {
            valueToAddText.text = gm.customSkillNames[2] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom4")
        {
            valueToAddText.text = gm.customSkillNames[3] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom5")
        {
            valueToAddText.text = gm.customSkillNames[4] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom6")
        {
            valueToAddText.text = gm.customSkillNames[5] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom7")
        {
            valueToAddText.text = gm.customSkillNames[6] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom8")
        {
            valueToAddText.text = gm.customSkillNames[7] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom9")
        {
            valueToAddText.text = gm.customSkillNames[8] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom10")
        {
            valueToAddText.text = gm.customSkillNames[9] + ": " + valueToAdd.ToString();
        }
        if (characteristicType == "Custom11")
        {
            valueToAddText.text = gm.customSkillNames[10] + ": " + valueToAdd.ToString();
        }
    }
}
