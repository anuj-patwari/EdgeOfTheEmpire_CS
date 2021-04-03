using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsScript : MonoBehaviour
{
    public static GameManager gm;

    public int astrogation, athletics, charm, coercion, computers, cool, coordination, deception, discipline, leadership, mechanics, medicine, negotiation, perception, pilotingPlanetary, pilotingSpace, resilience, skullduggery, stealth, streetwise, survival, vigilance, brawl, gunnery, melee, rangedLight, rangedHeavy, coreWorlds, education, lore, outerRim, underworld, xenology;
    public int yellowDie, greenDie;

    [SerializeField] GameObject astrogationButton, athleticsButton, charmButton, coercionButton, computersButton, coolButton, coordinationButton, deceptionButton, disciplineButton, leadershipButton, mechanicsButton, medicineButton, negotiationButton, perceptionButton, pilotingPlanetaryButton, pilotingSpaceButton, resilienceButton, skullduggeryButton, stealthButton, streetwiseButton, survivalButton, vigilanceButton, brawlButton, gunneryButton, meleeButton, rangedLightButton, rangedHeavyButton, coreWorldsButton, educationButton, loreButton, outerRimButton, underworldButton, xenologyButton;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        
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
                greenDie = gm.intellectValue - astrogation;
                yellowDie = astrogation;
            }
            else if (astrogation > gm.intellectValue)
            {
                greenDie = astrogation - gm.intellectValue;
                yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Athletics")
        {
            if (athletics <= gm.brawnValue)
            {
                greenDie = gm.brawnValue - athletics;
                yellowDie = athletics;
            }
            else if (athletics > gm.brawnValue)
            {
                greenDie = athletics - gm.brawnValue;
                yellowDie = gm.brawnValue;
            }
        }
        else if (skillName == "Charm")
        {
            if (charm <= gm.presenceValue)
            {
                greenDie = gm.presenceValue - charm;
                yellowDie = charm;
            }
            else if (charm > gm.presenceValue)
            {
                greenDie = charm - gm.presenceValue;
                yellowDie = gm.presenceValue;
            }
        }
        else if (skillName == "Coercion")
        {
            if (coercion <= gm.willpowerValue)
            {
                greenDie = gm.willpowerValue - coercion;
                yellowDie = coercion;
            }
            else if (coercion > gm.willpowerValue)
            {
                greenDie = coercion - gm.willpowerValue;
                yellowDie = gm.willpowerValue;
            }
        }
        else if (skillName == "Computers")
        {
            if (computers <= gm.intellectValue)
            {
                greenDie = gm.intellectValue - computers;
                yellowDie = computers;
            }
            else if (computers > gm.intellectValue)
            {
                greenDie = computers - gm.intellectValue;
                yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Cool")
        {
            if (cool <= gm.presenceValue)
            {
                greenDie = gm.presenceValue - cool;
                yellowDie = cool;
            }
            else if (cool > gm.presenceValue)
            {
                greenDie = cool - gm.presenceValue;
                yellowDie = gm.presenceValue;
            }
        }
        else if (skillName == "Coordination")
        {
            if (coordination <= gm.agilityValue)
            {
                greenDie = gm.agilityValue - coordination;
                yellowDie = coordination;
            }
            else if (coordination > gm.agilityValue)
            {
                greenDie = coordination - gm.agilityValue;
                yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Deception")
        {
            if (deception <= gm.cunningValue)
            {
                greenDie = gm.cunningValue - deception;
                yellowDie = deception;
            }
            else if (deception > gm.cunningValue)
            {
                greenDie = deception - gm.cunningValue;
                yellowDie = gm.cunningValue;
            }
        }
        else if (skillName == "Discpline")
        {
            if (discipline <= gm.willpowerValue)
            {
                greenDie = gm.willpowerValue - discipline;
                yellowDie = discipline;
            }
            else if (discipline > gm.willpowerValue)
            {
                greenDie = discipline - gm.willpowerValue;
                yellowDie = gm.willpowerValue;
            }
        }
        else if (skillName == "Leadership")
        {
            if (leadership <= gm.presenceValue)
            {
                greenDie = gm.presenceValue - leadership;
                yellowDie = leadership;
            }
            else if (leadership > gm.presenceValue)
            {
                greenDie = leadership - gm.presenceValue;
                yellowDie = gm.presenceValue;
            }
        }
        else if (skillName == "Mechanics")
        {
            if (mechanics <= gm.intellectValue)
            {
                greenDie = gm.intellectValue - mechanics;
                yellowDie = mechanics;
            }
            else if (mechanics > gm.intellectValue)
            {
                greenDie = mechanics - gm.intellectValue;
                yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Medicine")
        {
            if (medicine <= gm.intellectValue)
            {
                greenDie = gm.intellectValue - medicine;
                yellowDie = medicine;
            }
            else if (medicine > gm.intellectValue)
            {
                greenDie = medicine - gm.intellectValue;
                yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Negotiation")
        {
            if (negotiation <= gm.presenceValue)
            {
                greenDie = gm.presenceValue - negotiation;
                yellowDie = negotiation;
            }
            else if (negotiation > gm.presenceValue)
            {
                greenDie = negotiation - gm.presenceValue;
                yellowDie = gm.presenceValue;
            }
        }
        else if (skillName == "Perception")
        {
            if (perception <= gm.cunningValue)
            {
                greenDie = gm.cunningValue - perception;
                yellowDie = perception;
            }
            else if (perception > gm.cunningValue)
            {
                greenDie = perception - gm.cunningValue;
                yellowDie = gm.cunningValue;
            }
        }
        else if (skillName == "Piloting - Planetary")
        {
            if (pilotingPlanetary <= gm.agilityValue)
            {
                greenDie = gm.agilityValue - pilotingPlanetary;
                yellowDie = pilotingPlanetary;
            }
            else if (pilotingPlanetary > gm.agilityValue)
            {
                greenDie = pilotingPlanetary - gm.agilityValue;
                yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Piloting - Space")
        {
            if (pilotingSpace <= gm.agilityValue)
            {
                greenDie = gm.agilityValue - pilotingSpace;
                yellowDie = pilotingSpace;
            }
            else if (pilotingSpace > gm.agilityValue)
            {
                greenDie = pilotingSpace - gm.agilityValue;
                yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Resilience")
        {
            if (resilience <= gm.brawnValue)
            {
                greenDie = gm.brawnValue - resilience;
                yellowDie = resilience;
            }
            else if (resilience > gm.brawnValue)
            {
                greenDie = resilience - gm.brawnValue;
                yellowDie = gm.brawnValue;
            }
        }
        else if (skillName == "Skullduggery")
        {
            if (skullduggery <= gm.cunningValue)
            {
                greenDie = gm.cunningValue - skullduggery;
                yellowDie = skullduggery;
            }
            else if (skullduggery > gm.cunningValue)
            {
                greenDie = skullduggery - gm.cunningValue;
                yellowDie = gm.cunningValue;
            }
        }
        else if (skillName == "Stealth")
        {
            if (stealth <= gm.agilityValue)
            {
                greenDie = gm.agilityValue - stealth;
                yellowDie = stealth;
            }
            else if (stealth > gm.agilityValue)
            {
                greenDie = stealth - gm.agilityValue;
                yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Streetwise")
        {
            if (streetwise <= gm.cunningValue)
            {
                greenDie = gm.cunningValue - streetwise;
                yellowDie = streetwise;
            }
            else if (streetwise > gm.cunningValue)
            {
                greenDie = streetwise - gm.cunningValue;
                yellowDie = gm.cunningValue;
            }
        }
        else if (skillName == "Survival")
        {
            if (survival <= gm.cunningValue)
            {
                greenDie = gm.cunningValue - survival;
                yellowDie = survival;
            }
            else if (survival > gm.cunningValue)
            {
                greenDie = survival - gm.cunningValue;
                yellowDie = gm.cunningValue;
            }
        }
        else if (skillName == "Vigilance")
        {
            if (vigilance <= gm.willpowerValue)
            {
                greenDie = gm.willpowerValue - vigilance;
                yellowDie = vigilance;
            }
            else if (vigilance > gm.willpowerValue)
            {
                greenDie = vigilance - gm.willpowerValue;
                yellowDie = gm.willpowerValue;
            }
        }
        else if (skillName == "Brawl")
        {
            if (brawl <= gm.brawnValue)
            {
                greenDie = gm.brawnValue - brawl;
                yellowDie = brawl;
            }
            else if (brawl > gm.brawnValue)
            {
                greenDie = brawl - gm.brawnValue;
                yellowDie = gm.brawnValue;
            }
        }
        else if (skillName == "Gunnery")
        {
            if (gunnery <= gm.agilityValue)
            {
                greenDie = gm.agilityValue - gunnery;
                yellowDie = gunnery;
            }
            else if (gunnery > gm.agilityValue)
            {
                greenDie = gunnery - gm.agilityValue;
                yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Melee")
        {
            if (melee <= gm.brawnValue)
            {
                greenDie = gm.brawnValue - melee;
                yellowDie = melee;
            }
            else if (melee > gm.brawnValue)
            {
                greenDie = melee - gm.brawnValue;
                yellowDie = gm.brawnValue;
            }
        }
        else if (skillName == "Ranged - Light")
        {
            if (rangedLight <= gm.agilityValue)
            {
                greenDie = gm.agilityValue - rangedLight;
                yellowDie = rangedLight;
            }
            else if (rangedLight > gm.agilityValue)
            {
                greenDie = rangedLight - gm.agilityValue;
                yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Ranged - Heavy")
        {
            if (rangedHeavy <= gm.agilityValue)
            {
                greenDie = gm.agilityValue - rangedHeavy;
                yellowDie = rangedHeavy;
            }
            else if (rangedHeavy > gm.agilityValue)
            {
                greenDie = rangedHeavy - gm.agilityValue;
                yellowDie = gm.agilityValue;
            }
        }
        else if (skillName == "Core Worlds")
        {
            if (coreWorlds <= gm.intellectValue)
            {
                greenDie = gm.intellectValue - coreWorlds;
                yellowDie = coreWorlds;
            }
            else if (coreWorlds > gm.intellectValue)
            {
                greenDie = coreWorlds - gm.intellectValue;
                yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Education")
        {
            if (education <= gm.intellectValue)
            {
                greenDie = gm.intellectValue - education;
                yellowDie = education;
            }
            else if (education > gm.intellectValue)
            {
                greenDie = education - gm.intellectValue;
                yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Lore")
        {
            if (lore <= gm.intellectValue)
            {
                greenDie = gm.intellectValue - lore;
                yellowDie = lore;
            }
            else if (lore > gm.intellectValue)
            {
                greenDie = lore - gm.intellectValue;
                yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Outer Rim")
        {
            if (outerRim <= gm.intellectValue)
            {
                greenDie = gm.intellectValue - outerRim;
                yellowDie = outerRim;
            }
            else if (outerRim > gm.intellectValue)
            {
                greenDie = outerRim - gm.intellectValue;
                yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Underworld")
        {
            if (underworld <= gm.intellectValue)
            {
                greenDie = gm.intellectValue - underworld;
                yellowDie = underworld;
            }
            else if (underworld > gm.intellectValue)
            {
                greenDie = underworld - gm.intellectValue;
                yellowDie = gm.intellectValue;
            }
        }
        else if (skillName == "Xenology")
        {
            if (xenology <= gm.intellectValue)
            {
                greenDie = gm.intellectValue - xenology;
                yellowDie = xenology;
            }
            else if (xenology > gm.intellectValue)
            {
                greenDie = xenology - gm.intellectValue;
                yellowDie = gm.intellectValue;
            }
        }
        print (yellowDie + " Yellow");
        print (greenDie + " Green");
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
