using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponsScript : MonoBehaviour
{
    public static GameManager gm;

    public GameObject weaponHeader;
    public GameObject skillHeader;
    public GameObject damageHeader;
    public GameObject rangeHeader;
    public GameObject critHeader;
    public GameObject specialHeader;


    [Header("Weapons")]
    public TMP_InputField weapon1Text;
    public TMP_InputField weapon2Text;
    public TMP_InputField weapon3Text;
    public TMP_InputField weapon4Text;
    public TMP_InputField weapon5Text;
    public TMP_InputField weapon6Text;
    public TMP_InputField weapon7Text;
    public TMP_InputField weapon8Text;
    public TMP_InputField weapon9Text;
    public TMP_InputField weapon10Text;


    [Header("Skills")]
    public TMP_InputField skill1Text;
    public TMP_InputField skill2Text;
    public TMP_InputField skill3Text;
    public TMP_InputField skill4Text;
    public TMP_InputField skill5Text;
    public TMP_InputField skill6Text;
    public TMP_InputField skill7Text;
    public TMP_InputField skill8Text;
    public TMP_InputField skill9Text;
    public TMP_InputField skill10Text;


    [Header("Damage")]
    public TMP_InputField damage1Text;
    public TMP_InputField damage2Text;
    public TMP_InputField damage3Text;
    public TMP_InputField damage4Text;
    public TMP_InputField damage5Text;
    public TMP_InputField damage6Text;
    public TMP_InputField damage7Text;
    public TMP_InputField damage8Text;
    public TMP_InputField damage9Text;
    public TMP_InputField damage10Text;


    [Header("Range")]
    public TMP_InputField range1Text;
    public TMP_InputField range2Text;
    public TMP_InputField range3Text;
    public TMP_InputField range4Text;
    public TMP_InputField range5Text;
    public TMP_InputField range6Text;
    public TMP_InputField range7Text;
    public TMP_InputField range8Text;
    public TMP_InputField range9Text;
    public TMP_InputField range10Text;


    [Header("Crit")]
    public TMP_InputField crit1Text;
    public TMP_InputField crit2Text;
    public TMP_InputField crit3Text;
    public TMP_InputField crit4Text;
    public TMP_InputField crit5Text;
    public TMP_InputField crit6Text;
    public TMP_InputField crit7Text;
    public TMP_InputField crit8Text;
    public TMP_InputField crit9Text;
    public TMP_InputField crit10Text;


    [Header("Special")]
    public TMP_InputField special1Text;
    public TMP_InputField special2Text;
    public TMP_InputField special3Text;
    public TMP_InputField special4Text;
    public TMP_InputField special5Text;
    public TMP_InputField special6Text;
    public TMP_InputField special7Text;
    public TMP_InputField special8Text;
    public TMP_InputField special9Text;
    public TMP_InputField special10Text;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WeaponValues()
    {
        gm.weapon1[0] = weapon1Text.text;
        gm.weapon1[1] = skill1Text.text;
        gm.weapon1[2] = damage1Text.text;
        gm.weapon1[3] = range1Text.text;
        gm.weapon1[4] = crit1Text.text;
        gm.weapon1[5] = special1Text.text;

        gm.weapon2[0] = weapon2Text.text;
        gm.weapon2[1] = skill2Text.text;
        gm.weapon2[2] = damage2Text.text;
        gm.weapon2[3] = range2Text.text;
        gm.weapon2[4] = crit2Text.text;
        gm.weapon2[5] = special2Text.text;

        gm.weapon3[0] = weapon3Text.text;
        gm.weapon3[1] = skill3Text.text;
        gm.weapon3[2] = damage3Text.text;
        gm.weapon3[3] = range3Text.text;
        gm.weapon3[4] = crit3Text.text;
        gm.weapon3[5] = special3Text.text;

        gm.weapon4[0] = weapon4Text.text;
        gm.weapon4[1] = skill4Text.text;
        gm.weapon4[2] = damage4Text.text;
        gm.weapon4[3] = range4Text.text;
        gm.weapon4[4] = crit4Text.text;
        gm.weapon4[5] = special4Text.text;

        gm.weapon5[0] = weapon5Text.text;
        gm.weapon5[1] = skill5Text.text;
        gm.weapon5[2] = damage5Text.text;
        gm.weapon5[3] = range5Text.text;
        gm.weapon5[4] = crit5Text.text;
        gm.weapon5[5] = special5Text.text;

        gm.weapon6[0] = weapon6Text.text;
        gm.weapon6[1] = skill6Text.text;
        gm.weapon6[2] = damage6Text.text;
        gm.weapon6[3] = range6Text.text;
        gm.weapon6[4] = crit6Text.text;
        gm.weapon6[5] = special6Text.text;

        gm.weapon7[0] = weapon7Text.text;
        gm.weapon7[1] = skill7Text.text;
        gm.weapon7[2] = damage7Text.text;
        gm.weapon7[3] = range7Text.text;
        gm.weapon7[4] = crit7Text.text;
        gm.weapon7[5] = special7Text.text;

        gm.weapon8[0] = weapon8Text.text;
        gm.weapon8[1] = skill8Text.text;
        gm.weapon8[2] = damage8Text.text;
        gm.weapon8[3] = range8Text.text;
        gm.weapon8[4] = crit8Text.text;
        gm.weapon8[5] = special8Text.text;

        gm.weapon9[0] = weapon9Text.text;
        gm.weapon9[1] = skill9Text.text;
        gm.weapon9[2] = damage9Text.text;
        gm.weapon9[3] = range9Text.text;
        gm.weapon9[4] = crit9Text.text;
        gm.weapon9[5] = special9Text.text;

        gm.weapon10[0] = weapon10Text.text;
        gm.weapon10[1] = skill10Text.text;
        gm.weapon10[2] = damage10Text.text;
        gm.weapon10[3] = range10Text.text;
        gm.weapon10[4] = crit10Text.text;
        gm.weapon10[5] = special10Text.text;

        gm.SaveGame();
    }
}
