using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Characteristics : MonoBehaviour
{
    public static GameManager gm;
    public static UpgradeScript us;

    public Text brawnText, agilityText, intellectText, cunningText, willpowerText, presenceText;
    [SerializeField] GameObject upgradeGroup;
    [SerializeField] Text upgradeText;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        us = FindObjectOfType<UpgradeScript>();

        
        brawnText.text = "Brawn: " + gm.brawnValue;
        agilityText.text = "Agility: " + gm.agilityValue;
        intellectText.text = "Intellect: " + gm.intellectValue;
        cunningText.text = "Cunning: " + gm.cunningValue;
        willpowerText.text = "Willpower: " + gm.willpowerValue;
        presenceText.text = "Presence: " + gm.presenceValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetUpgradeButtons()
    {
        if(gm.upgradePhase == true)
        {
            brawnText.enabled = false;
            agilityText.enabled = false;
            intellectText.enabled = false;
            cunningText.enabled = false;
            willpowerText.enabled = false;
            presenceText.enabled = false;
            upgradeText.text = "Done!";
        }
        else if(gm.upgradePhase == false)
        {
            brawnText.enabled = true;
            agilityText.enabled = true;
            intellectText.enabled = true;
            cunningText.enabled = true;
            willpowerText.enabled = true;
            presenceText.enabled = true;
            brawnText.text = "Brawn: " + gm.brawnValue;
            agilityText.text = "Agility: " + gm.agilityValue;
            intellectText.text = "Intellect: " + gm.intellectValue;
            cunningText.text = "Cunning: " + gm.cunningValue;
            willpowerText.text = "Willpower: " + gm.willpowerValue;
            presenceText.text = "Presence: " + gm.presenceValue;
            upgradeText.text = "Upgrade!";
        }
    }
}