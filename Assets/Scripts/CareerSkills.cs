using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CareerSkills : MonoBehaviour
{
    public static GameManager gm;

    //public bool test;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //test = gm.toggle1.GetComponent<Toggle>().isOn;
    }

    public void EnableCareerSkills()
    {
        if (gm.upgradePhase == true)
        {
            gm.toggle1.GetComponent<Toggle>().interactable = true;
            gm.toggle2.GetComponent<Toggle>().interactable = true;
            gm.toggle3.GetComponent<Toggle>().interactable = true;
            gm.toggle4.GetComponent<Toggle>().interactable = true;
            gm.toggle5.GetComponent<Toggle>().interactable = true;
            gm.toggle6.GetComponent<Toggle>().interactable = true;
            gm.toggle7.GetComponent<Toggle>().interactable = true;
            gm.toggle8.GetComponent<Toggle>().interactable = true;
            gm.toggle9.GetComponent<Toggle>().interactable = true;
            gm.toggle10.GetComponent<Toggle>().interactable = true;
            gm.toggle11.GetComponent<Toggle>().interactable = true;
            gm.toggle12.GetComponent<Toggle>().interactable = true;
            gm.toggle13.GetComponent<Toggle>().interactable = true;
            gm.toggle14.GetComponent<Toggle>().interactable = true;
            gm.toggle15.GetComponent<Toggle>().interactable = true;
            gm.toggle16.GetComponent<Toggle>().interactable = true;
            gm.toggle17.GetComponent<Toggle>().interactable = true;
            gm.toggle18.GetComponent<Toggle>().interactable = true;
            gm.toggle19.GetComponent<Toggle>().interactable = true;
            gm.toggle20.GetComponent<Toggle>().interactable = true;
            gm.toggle21.GetComponent<Toggle>().interactable = true;
            gm.toggle22.GetComponent<Toggle>().interactable = true;
            gm.toggle23.GetComponent<Toggle>().interactable = true;
            gm.toggle24.GetComponent<Toggle>().interactable = true;
            gm.toggle25.GetComponent<Toggle>().interactable = true;
            gm.toggle26.GetComponent<Toggle>().interactable = true;
            gm.toggle27.GetComponent<Toggle>().interactable = true;
            gm.toggle28.GetComponent<Toggle>().interactable = true;
            gm.toggle29.GetComponent<Toggle>().interactable = true;
            gm.toggle30.GetComponent<Toggle>().interactable = true;
            gm.toggle31.GetComponent<Toggle>().interactable = true;
            gm.toggle32.GetComponent<Toggle>().interactable = true;
            gm.toggle33.GetComponent<Toggle>().interactable = true;
        }

        else if (gm.upgradePhase == false)
        {
            gm.toggle1.GetComponent<Toggle>().interactable = false;
            gm.toggle2.GetComponent<Toggle>().interactable = false;
            gm.toggle3.GetComponent<Toggle>().interactable = false;
            gm.toggle4.GetComponent<Toggle>().interactable = false;
            gm.toggle5.GetComponent<Toggle>().interactable = false;
            gm.toggle6.GetComponent<Toggle>().interactable = false;
            gm.toggle7.GetComponent<Toggle>().interactable = false;
            gm.toggle8.GetComponent<Toggle>().interactable = false;
            gm.toggle9.GetComponent<Toggle>().interactable = false;
            gm.toggle10.GetComponent<Toggle>().interactable = false;
            gm.toggle11.GetComponent<Toggle>().interactable = false;
            gm.toggle12.GetComponent<Toggle>().interactable = false;
            gm.toggle13.GetComponent<Toggle>().interactable = false;
            gm.toggle14.GetComponent<Toggle>().interactable = false;
            gm.toggle15.GetComponent<Toggle>().interactable = false;
            gm.toggle16.GetComponent<Toggle>().interactable = false;
            gm.toggle17.GetComponent<Toggle>().interactable = false;
            gm.toggle18.GetComponent<Toggle>().interactable = false;
            gm.toggle19.GetComponent<Toggle>().interactable = false;
            gm.toggle20.GetComponent<Toggle>().interactable = false;
            gm.toggle21.GetComponent<Toggle>().interactable = false;
            gm.toggle22.GetComponent<Toggle>().interactable = false;
            gm.toggle23.GetComponent<Toggle>().interactable = false;
            gm.toggle24.GetComponent<Toggle>().interactable = false;
            gm.toggle25.GetComponent<Toggle>().interactable = false;
            gm.toggle26.GetComponent<Toggle>().interactable = false;
            gm.toggle27.GetComponent<Toggle>().interactable = false;
            gm.toggle28.GetComponent<Toggle>().interactable = false;
            gm.toggle29.GetComponent<Toggle>().interactable = false;
            gm.toggle30.GetComponent<Toggle>().interactable = false;
            gm.toggle31.GetComponent<Toggle>().interactable = false;
            gm.toggle32.GetComponent<Toggle>().interactable = false;
            gm.toggle33.GetComponent<Toggle>().interactable = false;


            gm.careerSkill1 = gm.toggle1.GetComponent<Toggle>().isOn;
            gm.careerSkill2 = gm.toggle2.GetComponent<Toggle>().isOn;
            gm.careerSkill3 = gm.toggle3.GetComponent<Toggle>().isOn;
            gm.careerSkill4 = gm.toggle4.GetComponent<Toggle>().isOn;
            gm.careerSkill5 = gm.toggle5.GetComponent<Toggle>().isOn;
            gm.careerSkill6 = gm.toggle6.GetComponent<Toggle>().isOn;
            gm.careerSkill7 = gm.toggle7.GetComponent<Toggle>().isOn;
            gm.careerSkill8 = gm.toggle8.GetComponent<Toggle>().isOn;
            gm.careerSkill9 = gm.toggle9.GetComponent<Toggle>().isOn;
            gm.careerSkill10 = gm.toggle10.GetComponent<Toggle>().isOn;
            gm.careerSkill11 = gm.toggle11.GetComponent<Toggle>().isOn;
            gm.careerSkill12 = gm.toggle12.GetComponent<Toggle>().isOn;
            gm.careerSkill13 = gm.toggle13.GetComponent<Toggle>().isOn;
            gm.careerSkill14 = gm.toggle14.GetComponent<Toggle>().isOn;
            gm.careerSkill15 = gm.toggle15.GetComponent<Toggle>().isOn;
            gm.careerSkill16 = gm.toggle16.GetComponent<Toggle>().isOn;
            gm.careerSkill17 = gm.toggle17.GetComponent<Toggle>().isOn;
            gm.careerSkill18 = gm.toggle18.GetComponent<Toggle>().isOn;
            gm.careerSkill19 = gm.toggle19.GetComponent<Toggle>().isOn;
            gm.careerSkill20 = gm.toggle20.GetComponent<Toggle>().isOn;
            gm.careerSkill21 = gm.toggle21.GetComponent<Toggle>().isOn;
            gm.careerSkill22 = gm.toggle22.GetComponent<Toggle>().isOn;
            gm.careerSkill23 = gm.toggle23.GetComponent<Toggle>().isOn;
            gm.careerSkill24 = gm.toggle24.GetComponent<Toggle>().isOn;
            gm.careerSkill25 = gm.toggle25.GetComponent<Toggle>().isOn;
            gm.careerSkill26 = gm.toggle26.GetComponent<Toggle>().isOn;
            gm.careerSkill27 = gm.toggle27.GetComponent<Toggle>().isOn;
            gm.careerSkill28 = gm.toggle28.GetComponent<Toggle>().isOn;
            gm.careerSkill29 = gm.toggle29.GetComponent<Toggle>().isOn;
            gm.careerSkill30 = gm.toggle30.GetComponent<Toggle>().isOn;
            gm.careerSkill31 = gm.toggle31.GetComponent<Toggle>().isOn;
            gm.careerSkill32 = gm.toggle32.GetComponent<Toggle>().isOn;
            gm.careerSkill33 = gm.toggle33.GetComponent<Toggle>().isOn;

        }
    }
}
