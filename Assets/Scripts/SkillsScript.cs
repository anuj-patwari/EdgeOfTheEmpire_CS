using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsScript : MonoBehaviour
{
    public static GameManager gm;
    public static DiceScript ds;

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

    public GameObject astrogationButton, athleticsButton, charmButton, coercionButton, computersButton, coolButton, coordinationButton, deceptionButton, disciplineButton, leadershipButton, mechanicsButton, medicineButton, negotiationButton, perceptionButton, pilotingPlanetaryButton, pilotingSpaceButton, resilienceButton, skullduggeryButton, stealthButton, streetwiseButton, survivalButton, vigilanceButton, brawlButton, gunneryButton, meleeButton, rangedLightButton, rangedHeavyButton, coreWorldsButton, educationButton, loreButton, outerRimButton, underworldButton, xenologyButton, custom1Button, custom2Button, custom3Button, custom4Button, custom5Button, custom6Button, custom7Button, custom8Button, custom9Button, custom10Button, custom11Button;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        ds = FindObjectOfType<DiceScript>();
        
        astrogationButton.transform.GetChild(0).GetComponent<Text>().text = "Astrogation (Intellect): " + astrogation;
        athleticsButton.transform.GetChild(0).GetComponent<Text>().text = "Athletics (Brawn): " + athletics;
        charmButton.transform.GetChild(0).GetComponent<Text>().text = "Charm (Presence): " + charm;
        coercionButton.transform.GetChild(0).GetComponent<Text>().text = "Coercion (Willpower): " + coercion;
        computersButton.transform.GetChild(0).GetComponent<Text>().text = "Computers (Intellect): " + computers;
        coolButton.transform.GetChild(0).GetComponent<Text>().text = "Cool (Presence): " + cool;
        coordinationButton.transform.GetChild(0).GetComponent<Text>().text = "Coordination (Agility): " + coordination;
        deceptionButton.transform.GetChild(0).GetComponent<Text>().text = "Deception (Cunning): " + deception;
        disciplineButton.transform.GetChild(0).GetComponent<Text>().text = "Discipline (Willpower): " + discipline;
        leadershipButton.transform.GetChild(0).GetComponent<Text>().text = "Leadership (Presence): " + leadership;
        mechanicsButton.transform.GetChild(0).GetComponent<Text>().text = "Mechanics (Intellect): " + mechanics;
        medicineButton.transform.GetChild(0).GetComponent<Text>().text = "Medicine (Intellect): " + medicine;
        negotiationButton.transform.GetChild(0).GetComponent<Text>().text = "Negotiation (Presence): " + negotiation;
        perceptionButton.transform.GetChild(0).GetComponent<Text>().text = "Perception (Cunning): " + perception;
        pilotingPlanetaryButton.transform.GetChild(0).GetComponent<Text>().text = "Piloting - Planetary (Agility): " + pilotingPlanetary;
        pilotingSpaceButton.transform.GetChild(0).GetComponent<Text>().text = "Piloting - Space (Agility): " + pilotingSpace;
        resilienceButton.transform.GetChild(0).GetComponent<Text>().text = "Resilience (Brawn): " + resilience;
        skullduggeryButton.transform.GetChild(0).GetComponent<Text>().text = "Skullduggery (Cunning): " + skullduggery;
        stealthButton.transform.GetChild(0).GetComponent<Text>().text = "Stealth (Agility): " + stealth;
        streetwiseButton.transform.GetChild(0).GetComponent<Text>().text = "Streetwise (Cunning): " + streetwise;
        survivalButton.transform.GetChild(0).GetComponent<Text>().text = "Survival (Cunning): " + survival;
        vigilanceButton.transform.GetChild(0).GetComponent<Text>().text = "Vigilance (Willpower): " + vigilance;
        brawlButton.transform.GetChild(0).GetComponent<Text>().text = "Brawl (Brawn): " + brawl;
        gunneryButton.transform.GetChild(0).GetComponent<Text>().text = "Gunnery (Agility): " + gunnery;
        meleeButton.transform.GetChild(0).GetComponent<Text>().text = "Melee (Brawn): " + melee;
        rangedLightButton.transform.GetChild(0).GetComponent<Text>().text = "Ranged - Light (Agility): " + rangedLight;
        rangedHeavyButton.transform.GetChild(0).GetComponent<Text>().text = "Ranged - Heavy (Agility): " + rangedHeavy;
        coreWorldsButton.transform.GetChild(0).GetComponent<Text>().text = "Core Worlds (Intellect): " + coreWorlds;
        educationButton.transform.GetChild(0).GetComponent<Text>().text = "Education (Intellect): " + education;
        loreButton.transform.GetChild(0).GetComponent<Text>().text = "Lore (Intellect): " + lore;
        outerRimButton.transform.GetChild(0).GetComponent<Text>().text = "Outer Rim (Intellect): " + outerRim;
        underworldButton.transform.GetChild(0).GetComponent<Text>().text = "Underworld (Intellect): " + underworld;
        xenologyButton.transform.GetChild(0).GetComponent<Text>().text = "Xenology (Intellect): " + xenology;
        /*custom1Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[0] + " (" + gm.customSkillCharacteristics[0] + "): " + gm.customSkillValues[0];
        custom2Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[1] + " (" + gm.customSkillCharacteristics[1] + "): " + gm.customSkillValues[1];
        custom3Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[2] + " (" + gm.customSkillCharacteristics[2] + "): " + gm.customSkillValues[2];
        custom4Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[3] + " (" + gm.customSkillCharacteristics[3] + "): " + gm.customSkillValues[3];
        custom5Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[4] + " (" + gm.customSkillCharacteristics[4] + "): " + gm.customSkillValues[4];
        custom6Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[5] + " (" + gm.customSkillCharacteristics[5] + "): " + gm.customSkillValues[5];
        custom7Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[6] + " (" + gm.customSkillCharacteristics[6] + "): " + gm.customSkillValues[6];
        custom8Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[7] + " (" + gm.customSkillCharacteristics[7] + "): " + gm.customSkillValues[7];
        custom9Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[8] + " (" + gm.customSkillCharacteristics[8] + "): " + gm.customSkillValues[8];
        custom10Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[9] + " (" + gm.customSkillCharacteristics[9] + "): " + gm.customSkillValues[9];
        custom11Button.transform.GetChild(0).GetComponent<Text>().text = gm.customSkillNames[10] + " (" + gm.customSkillCharacteristics[10] + "): " + gm.customSkillValues[10];*/
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExecuteSkill(string skillName)
    {
        if (skillName == "Astrogation")
        {
            if (astrogation <= gm.intellectValue)
            {
                ds.greenDie = gm.intellectValue - astrogation;
                ds.yellowDie = astrogation;
            }
            else if (astrogation > gm.intellectValue)
            {
                ds.greenDie = astrogation - gm.intellectValue;
                ds.yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Athletics")
        {
            if (athletics <= gm.brawnValue)
            {
                ds.greenDie = gm.brawnValue - athletics;
                ds.yellowDie = athletics;
            }
            else if (athletics > gm.brawnValue)
            {
                ds.greenDie = athletics - gm.brawnValue;
                ds.yellowDie = gm.brawnValue;
            }
        }
        else if (skillName == "Charm")
        {
            if (charm <= gm.presenceValue)
            {
                ds.greenDie = gm.presenceValue - charm;
                ds.yellowDie = charm;
            }
            else if (charm > gm.presenceValue)
            {
                ds.greenDie = charm - gm.presenceValue;
                ds.yellowDie = gm.presenceValue;
            }
        }
        else if (skillName == "Coercion")
        {
            if (coercion <= gm.willpowerValue)
            {
                ds.greenDie = gm.willpowerValue - coercion;
                ds.yellowDie = coercion;
            }
            else if (coercion > gm.willpowerValue)
            {
                ds.greenDie = coercion - gm.willpowerValue;
                ds.yellowDie = gm.willpowerValue;
            }
        }
        else if (skillName == "Computers")
        {
            if (computers <= gm.intellectValue)
            {
                ds.greenDie = gm.intellectValue - computers;
                ds.yellowDie = computers;
            }
            else if (computers > gm.intellectValue)
            {
                ds.greenDie = computers - gm.intellectValue;
                ds.yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Cool")
        {
            if (cool <= gm.presenceValue)
            {
                ds.greenDie = gm.presenceValue - cool;
                ds.yellowDie = cool;
            }
            else if (cool > gm.presenceValue)
            {
                ds.greenDie = cool - gm.presenceValue;
                ds.yellowDie = gm.presenceValue;
            }
        }
        else if (skillName == "Coordination")
        {
            if (coordination <= gm.agilityValue)
            {
                ds.greenDie = gm.agilityValue - coordination;
                ds.yellowDie = coordination;
            }
            else if (coordination > gm.agilityValue)
            {
                ds.greenDie = coordination - gm.agilityValue;
                ds.yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Deception")
        {
            if (deception <= gm.cunningValue)
            {
                ds.greenDie = gm.cunningValue - deception;
                ds.yellowDie = deception;
            }
            else if (deception > gm.cunningValue)
            {
                ds.greenDie = deception - gm.cunningValue;
                ds.yellowDie = gm.cunningValue;
            }
        }
        else if (skillName == "Discpline")
        {
            if (discipline <= gm.willpowerValue)
            {
                ds.greenDie = gm.willpowerValue - discipline;
                ds.yellowDie = discipline;
            }
            else if (discipline > gm.willpowerValue)
            {
                ds.greenDie = discipline - gm.willpowerValue;
                ds.yellowDie = gm.willpowerValue;
            }
        }
        else if (skillName == "Leadership")
        {
            if (leadership <= gm.presenceValue)
            {
                ds.greenDie = gm.presenceValue - leadership;
                ds.yellowDie = leadership;
            }
            else if (leadership > gm.presenceValue)
            {
                ds.greenDie = leadership - gm.presenceValue;
                ds.yellowDie = gm.presenceValue;
            }
        }
        else if (skillName == "Mechanics")
        {
            if (mechanics <= gm.intellectValue)
            {
                ds.greenDie = gm.intellectValue - mechanics;
                ds.yellowDie = mechanics;
            }
            else if (mechanics > gm.intellectValue)
            {
                ds.greenDie = mechanics - gm.intellectValue;
                ds.yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Medicine")
        {
            if (medicine <= gm.intellectValue)
            {
                ds.greenDie = gm.intellectValue - medicine;
                ds.yellowDie = medicine;
            }
            else if (medicine > gm.intellectValue)
            {
                ds.greenDie = medicine - gm.intellectValue;
                ds.yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Negotiation")
        {
            if (negotiation <= gm.presenceValue)
            {
                ds.greenDie = gm.presenceValue - negotiation;
                ds.yellowDie = negotiation;
            }
            else if (negotiation > gm.presenceValue)
            {
                ds.greenDie = negotiation - gm.presenceValue;
                ds.yellowDie = gm.presenceValue;
            }
        }
        else if (skillName == "Perception")
        {
            if (perception <= gm.cunningValue)
            {
                ds.greenDie = gm.cunningValue - perception;
                ds.yellowDie = perception;
            }
            else if (perception > gm.cunningValue)
            {
                ds.greenDie = perception - gm.cunningValue;
                ds.yellowDie = gm.cunningValue;
            }
        }
        else if (skillName == "Piloting - Planetary")
        {
            if (pilotingPlanetary <= gm.agilityValue)
            {
                ds.greenDie = gm.agilityValue - pilotingPlanetary;
                ds.yellowDie = pilotingPlanetary;
            }
            else if (pilotingPlanetary > gm.agilityValue)
            {
                ds.greenDie = pilotingPlanetary - gm.agilityValue;
                ds.yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Piloting - Space")
        {
            if (pilotingSpace <= gm.agilityValue)
            {
                ds.greenDie = gm.agilityValue - pilotingSpace;
                ds.yellowDie = pilotingSpace;
            }
            else if (pilotingSpace > gm.agilityValue)
            {
                ds.greenDie = pilotingSpace - gm.agilityValue;
                ds.yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Resilience")
        {
            if (resilience <= gm.brawnValue)
            {
                ds.greenDie = gm.brawnValue - resilience;
                ds.yellowDie = resilience;
            }
            else if (resilience > gm.brawnValue)
            {
                ds.greenDie = resilience - gm.brawnValue;
                ds.yellowDie = gm.brawnValue;
            }
        }
        else if (skillName == "Skullduggery")
        {
            if (skullduggery <= gm.cunningValue)
            {
                ds.greenDie = gm.cunningValue - skullduggery;
                ds.yellowDie = skullduggery;
            }
            else if (skullduggery > gm.cunningValue)
            {
                ds.greenDie = skullduggery - gm.cunningValue;
                ds.yellowDie = gm.cunningValue;
            }
        }
        else if (skillName == "Stealth")
        {
            if (stealth <= gm.agilityValue)
            {
                ds.greenDie = gm.agilityValue - stealth;
                ds.yellowDie = stealth;
            }
            else if (stealth > gm.agilityValue)
            {
                ds.greenDie = stealth - gm.agilityValue;
                ds.yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Streetwise")
        {
            if (streetwise <= gm.cunningValue)
            {
                ds.greenDie = gm.cunningValue - streetwise;
                ds.yellowDie = streetwise;
            }
            else if (streetwise > gm.cunningValue)
            {
                ds.greenDie = streetwise - gm.cunningValue;
                ds.yellowDie = gm.cunningValue;
            }
        }
        else if (skillName == "Survival")
        {
            if (survival <= gm.cunningValue)
            {
                ds.greenDie = gm.cunningValue - survival;
                ds.yellowDie = survival;
            }
            else if (survival > gm.cunningValue)
            {
                ds.greenDie = survival - gm.cunningValue;
                ds.yellowDie = gm.cunningValue;
            }
        }
        else if (skillName == "Vigilance")
        {
            if (vigilance <= gm.willpowerValue)
            {
                ds.greenDie = gm.willpowerValue - vigilance;
                ds.yellowDie = vigilance;
            }
            else if (vigilance > gm.willpowerValue)
            {
                ds.greenDie = vigilance - gm.willpowerValue;
                ds.yellowDie = gm.willpowerValue;
            }
        }
        else if (skillName == "Brawl")
        {
            if (brawl <= gm.brawnValue)
            {
                ds.greenDie = gm.brawnValue - brawl;
                ds.yellowDie = brawl;
            }
            else if (brawl > gm.brawnValue)
            {
                ds.greenDie = brawl - gm.brawnValue;
                ds.yellowDie = gm.brawnValue;
            }
        }
        else if (skillName == "Gunnery")
        {
            if (gunnery <= gm.agilityValue)
            {
                ds.greenDie = gm.agilityValue - gunnery;
                ds.yellowDie = gunnery;
            }
            else if (gunnery > gm.agilityValue)
            {
                ds.greenDie = gunnery - gm.agilityValue;
                ds.yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Melee")
        {
            if (melee <= gm.brawnValue)
            {
                ds.greenDie = gm.brawnValue - melee;
                ds.yellowDie = melee;
            }
            else if (melee > gm.brawnValue)
            {
                ds.greenDie = melee - gm.brawnValue;
                ds.yellowDie = gm.brawnValue;
            }
        }
        else if (skillName == "Ranged - Light")
        {
            if (rangedLight <= gm.agilityValue)
            {
                ds.greenDie = gm.agilityValue - rangedLight;
                ds.yellowDie = rangedLight;
            }
            else if (rangedLight > gm.agilityValue)
            {
                ds.greenDie = rangedLight - gm.agilityValue;
                ds.yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Ranged - Heavy")
        {
            if (rangedHeavy <= gm.agilityValue)
            {
                ds.greenDie = gm.agilityValue - rangedHeavy;
                ds.yellowDie = rangedHeavy;
            }
            else if (rangedHeavy > gm.agilityValue)
            {
                ds.greenDie = rangedHeavy - gm.agilityValue;
                ds.yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Core Worlds")
        {
            if (coreWorlds <= gm.intellectValue)
            {
                ds.greenDie = gm.intellectValue - coreWorlds;
                ds.yellowDie = coreWorlds;
            }
            else if (coreWorlds > gm.intellectValue)
            {
                ds.greenDie = coreWorlds - gm.intellectValue;
                ds.yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Education")
        {
            if (education <= gm.intellectValue)
            {
                ds.greenDie = gm.intellectValue - education;
                ds.yellowDie = education;
            }
            else if (education > gm.intellectValue)
            {
                ds.greenDie = education - gm.intellectValue;
                ds.yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Lore")
        {
            if (lore <= gm.intellectValue)
            {
                ds.greenDie = gm.intellectValue - lore;
                ds.yellowDie = lore;
            }
            else if (lore > gm.intellectValue)
            {
                ds.greenDie = lore - gm.intellectValue;
                ds.yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Outer Rim")
        {
            if (outerRim <= gm.intellectValue)
            {
                ds.greenDie = gm.intellectValue - outerRim;
                ds.yellowDie = outerRim;
            }
            else if (outerRim > gm.intellectValue)
            {
                ds.greenDie = outerRim - gm.intellectValue;
                ds.yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Underworld")
        {
            if (underworld <= gm.intellectValue)
            {
                ds.greenDie = gm.intellectValue - underworld;
                ds.yellowDie = underworld;
            }
            else if (underworld > gm.intellectValue)
            {
                ds.greenDie = underworld - gm.intellectValue;
                ds.yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Xenology")
        {
            if (xenology <= gm.intellectValue)
            {
                ds.greenDie = gm.intellectValue - xenology;
                ds.yellowDie = xenology;
            }
            else if (xenology > gm.intellectValue)
            {
                ds.greenDie = xenology - gm.intellectValue;
                ds.yellowDie = gm.intellectValue;
            }
        }
        /*else if (skillName == "Custom Skill 1")
        {
            if (customSkill1 <= )
            {

            }
        }*/

        ds.PlayDice();
    }

    public void UpgradePhaseCompleted()
    {
        astrogationButton.transform.GetChild(0).GetComponent<Text>().text = "Astrogation (Intellect): " + astrogation;
        athleticsButton.transform.GetChild(0).GetComponent<Text>().text = "Athletics (Brawn): " + athletics;
        charmButton.transform.GetChild(0).GetComponent<Text>().text = "Charm (Presence): " + charm;
        coercionButton.transform.GetChild(0).GetComponent<Text>().text = "Coercion (Willpower): " + coercion;
        computersButton.transform.GetChild(0).GetComponent<Text>().text = "Computers (Intellect): " + computers;
        coolButton.transform.GetChild(0).GetComponent<Text>().text = "Cool (Presence): " + cool;
        coordinationButton.transform.GetChild(0).GetComponent<Text>().text = "Coordination (Agility): " + coordination;
        deceptionButton.transform.GetChild(0).GetComponent<Text>().text = "Deception (Cunning): " + deception;
        disciplineButton.transform.GetChild(0).GetComponent<Text>().text = "Discipline (Willpower): " + discipline;
        leadershipButton.transform.GetChild(0).GetComponent<Text>().text = "Leadership (Presence): " + leadership;
        mechanicsButton.transform.GetChild(0).GetComponent<Text>().text = "Mechanics (Intellect): " + mechanics;
        medicineButton.transform.GetChild(0).GetComponent<Text>().text = "Medicine (Intellect): " + medicine;
        negotiationButton.transform.GetChild(0).GetComponent<Text>().text = "Negotiation (Presence): " + negotiation;
        perceptionButton.transform.GetChild(0).GetComponent<Text>().text = "Perception (Cunning): " + perception;
        pilotingPlanetaryButton.transform.GetChild(0).GetComponent<Text>().text = "Piloting - Planetary (Agility): " + pilotingPlanetary;
        pilotingSpaceButton.transform.GetChild(0).GetComponent<Text>().text = "Piloting - Space (Agility): " + pilotingSpace;
        resilienceButton.transform.GetChild(0).GetComponent<Text>().text = "Resilience (Brawn): " + resilience;
        skullduggeryButton.transform.GetChild(0).GetComponent<Text>().text = "Skullduggery (Cunning): " + skullduggery;
        stealthButton.transform.GetChild(0).GetComponent<Text>().text = "Stealth (Agility): " + stealth;
        streetwiseButton.transform.GetChild(0).GetComponent<Text>().text = "Streetwise (Cunning): " + streetwise;
        survivalButton.transform.GetChild(0).GetComponent<Text>().text = "Survival (Cunning): " + survival;
        vigilanceButton.transform.GetChild(0).GetComponent<Text>().text = "Vigilance (Willpower): " + vigilance;
        brawlButton.transform.GetChild(0).GetComponent<Text>().text = "Brawl (Brawn): " + brawl;
        gunneryButton.transform.GetChild(0).GetComponent<Text>().text = "Gunnery (Agility): " + gunnery;
        meleeButton.transform.GetChild(0).GetComponent<Text>().text = "Melee (Brawn): " + melee;
        rangedLightButton.transform.GetChild(0).GetComponent<Text>().text = "Ranged - Light (Agility): " + rangedLight;
        rangedHeavyButton.transform.GetChild(0).GetComponent<Text>().text = "Ranged - Heavy (Agility): " + rangedHeavy;
        coreWorldsButton.transform.GetChild(0).GetComponent<Text>().text = "Core Worlds (Intellect): " + coreWorlds;
        educationButton.transform.GetChild(0).GetComponent<Text>().text = "Education (Intellect): " + education;
        loreButton.transform.GetChild(0).GetComponent<Text>().text = "Lore (Intellect): " + lore;
        outerRimButton.transform.GetChild(0).GetComponent<Text>().text = "Outer Rim (Intellect): " + outerRim;
        underworldButton.transform.GetChild(0).GetComponent<Text>().text = "Underworld (Intellect): " + underworld;
        xenologyButton.transform.GetChild(0).GetComponent<Text>().text = "Xenology (Intellect): " + xenology;

    }
}
