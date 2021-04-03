using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeScript : MonoBehaviour
{
    public static GameManager gm;
    public static Characteristics characteristics;
    public static SkillsScript ss;

    [SerializeField] Button brawnButton, agilityButton, intellectButton, cunningButton, willpowerButton, presenceButton;
    [SerializeField] GameObject astrogationButton, athleticsButton, charmButton, coercionButton, computersButton, coolButton, coordinationButton, deceptionButton, disciplineButton, leadershipButton, mechanicsButton, medicineButton, negotiationButton, perceptionButton, pilotingPlanetaryButton, pilotingSpaceButton, resilienceButton, skullduggeryButton, stealthButton, streetwiseButton, survivalButton, vigilanceButton, brawlButton, gunneryButton, meleeButton, rangedLightButton, rangedHeavyButton, coreWorldsButton, educationButton, loreButton, outerRimButton, underworldButton, xenologyButton;
    [SerializeField] GameObject upgradeUI;
    int valueToAdd = 0;
    string characteristicType;

    // Start is called before the first frame update
    void Awake()
    {
        gm = FindObjectOfType<GameManager>();
        characteristics = FindObjectOfType<Characteristics>();
        ss = FindObjectOfType<SkillsScript>();



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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetUpgradeButtons()
    {
        brawnButton.transform.GetChild(0).GetComponent<Text>().text = "Brawn: " + gm.brawnValue;
        agilityButton.transform.GetChild(0).GetComponent<Text>().text = "Agility: " + gm.agilityValue;
        intellectButton.transform.GetChild(0).GetComponent<Text>().text = "Intellect: " + gm.intellectValue;
        cunningButton.transform.GetChild(0).GetComponent<Text>().text = "Cunning: " + gm.cunningValue;
        willpowerButton.transform.GetChild(0).GetComponent<Text>().text = "Willpower: " + gm.willpowerValue;
        presenceButton.transform.GetChild(0).GetComponent<Text>().text = "Presence: " + gm.presenceValue;
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
        }
        else if (characteristicType == "Athletics")
        {
            ss.athletics = valueToAdd;
        }
        else if (characteristicType == "Charm")
        {
            ss.charm = valueToAdd;
        }
        else if (characteristicType == "Coercion")
        {
            ss.coercion = valueToAdd;
        }
        else if (characteristicType == "Computers")
        {
            ss.computers = valueToAdd;
        }
        else if (characteristicType == "Cool")
        {
            ss.cool = valueToAdd;
        }
        else if (characteristicType == "Coordination")
        {
            ss.coordination = valueToAdd;
        }
        else if (characteristicType == "Deception")
        {
            ss.deception = valueToAdd;
        }
        else if (characteristicType == "Discipline")
        {
            ss.discipline = valueToAdd;
        }
        else if (characteristicType == "Leadership")
        {
            ss.leadership = valueToAdd;
        }
        else if (characteristicType == "Mechanics")
        {
            ss.mechanics = valueToAdd;
        }
        else if (characteristicType == "Medicine")
        {
            ss.medicine = valueToAdd;
        }
        else if (characteristicType == "Negotiation")
        {
            ss.negotiation = valueToAdd;
        }
        else if (characteristicType == "Perception")
        {
            ss.perception = valueToAdd;
        }
        else if (characteristicType == "Piloting - Planetary")
        {
            ss.pilotingPlanetary = valueToAdd;
        }
        else if (characteristicType == "Piloting - Space")
        {
            ss.pilotingSpace = valueToAdd;
        }
        else if (characteristicType == "Resilience")
        {
            ss.resilience = valueToAdd;
        }
        else if (characteristicType == "Skullduggery")
        {
            ss.skullduggery = valueToAdd;
        }
        else if (characteristicType == "Stealth")
        {
            ss.stealth = valueToAdd;
        }
        else if (characteristicType == "Streetwise")
        {
            ss.streetwise = valueToAdd;
        }
        else if (characteristicType == "Survival")
        {
            ss.survival = valueToAdd;
        }
        else if (characteristicType == "Vigilance")
        {
            ss.vigilance = valueToAdd;
        }
        else if (characteristicType == "Brawl")
        {
            ss.brawl = valueToAdd;
        }
        else if (characteristicType == "Gunnery")
        {
            ss.gunnery = valueToAdd;
        }
        else if (characteristicType == "Melee")
        {
            ss.melee = valueToAdd;
        }
        else if (characteristicType == "Ranged - Light")
        {
            ss.rangedLight = valueToAdd;
        }
        else if (characteristicType == "Ranged - Heavy")
        {
            ss.rangedHeavy = valueToAdd;
        }
        else if (characteristicType == "Core Worlds")
        {
            ss.coreWorlds = valueToAdd;
        }
        else if (characteristicType == "Education")
        {
            ss.education = valueToAdd;
        }
        else if (characteristicType == "Lore")
        {
            ss.lore = valueToAdd;
        }
        else if (characteristicType == "Outer Rim")
        {
            ss.outerRim = valueToAdd;
        }
        else if (characteristicType == "Underworld")
        {
            ss.underworld = valueToAdd;
        }
        else if (characteristicType == "Xenology")
        {
            ss.xenology = valueToAdd;
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


        valueToAdd = 0;
        upgradeUI.SetActive(false);
        ss.UpgradePhaseCompleted();
        gm.SaveGame();
    }

    public void PressingAddButton()
    {
        valueToAdd = valueToAdd + 1;    
    }

    public void PressingSubtractButton()
    {
        valueToAdd = valueToAdd - 1;    
    }
}
