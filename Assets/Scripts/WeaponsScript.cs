using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public InputField weapon1Text;
    public InputField weapon2Text;
    public InputField weapon3Text;
    public InputField weapon4Text;
    public InputField weapon5Text;
    public InputField weapon6Text;
    public InputField weapon7Text;
    public InputField weapon8Text;
    public InputField weapon9Text;
    public InputField weapon10Text;


    [Header("Skills")]
    public InputField skill1Text;
    public InputField skill2Text;
    public InputField skill3Text;
    public InputField skill4Text;
    public InputField skill5Text;
    public InputField skill6Text;
    public InputField skill7Text;
    public InputField skill8Text;
    public InputField skill9Text;
    public InputField skill10Text;


    [Header("Damage")]
    public InputField damage1Text;
    public InputField damage2Text;
    public InputField damage3Text;
    public InputField damage4Text;
    public InputField damage5Text;
    public InputField damage6Text;
    public InputField damage7Text;
    public InputField damage8Text;
    public InputField damage9Text;
    public InputField damage10Text;


    [Header("Range")]
    public InputField range1Text;
    public InputField range2Text;
    public InputField range3Text;
    public InputField range4Text;
    public InputField range5Text;
    public InputField range6Text;
    public InputField range7Text;
    public InputField range8Text;
    public InputField range9Text;
    public InputField range10Text;


    [Header("Crit")]
    public InputField crit1Text;
    public InputField crit2Text;
    public InputField crit3Text;
    public InputField crit4Text;
    public InputField crit5Text;
    public InputField crit6Text;
    public InputField crit7Text;
    public InputField crit8Text;
    public InputField crit9Text;
    public InputField crit10Text;


    [Header("Special")]
    public InputField special1Text;
    public InputField special2Text;
    public InputField special3Text;
    public InputField special4Text;
    public InputField special5Text;
    public InputField special6Text;
    public InputField special7Text;
    public InputField special8Text;
    public InputField special9Text;
    public InputField special10Text;

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
        gm.weapon9[5] = special2Text.text;

        gm.weapon10[0] = weapon10Text.text;
        gm.weapon10[1] = skill10Text.text;
        gm.weapon10[2] = damage10Text.text;
        gm.weapon10[3] = range10Text.text;
        gm.weapon10[4] = crit10Text.text;
        gm.weapon10[5] = special10Text.text;

        gm.SaveGame();
    }
}
