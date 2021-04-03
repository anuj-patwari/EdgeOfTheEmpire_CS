using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceScript : MonoBehaviour
{
    public static SkillsScript ss;

    [Header("Number of Dice to be rolled:")]
    public int greenDie; public int yellowDie; public int redDie; public int purpleDie; public int blackDie; public int blueDie; public int whiteDie;

    [SerializeField] Text greenDieText, yellowDieText, purpleDieText, redDieText, blueDieText, blackDieText, whiteDieText, totalSuccessText, totalAdvantageText;
    
    [Header("The Dice Outcomes:")] 
    public int success; public int advantage; public int triumph; public int failure; public int threat; public int despair; public int totalSuccess; public int totalAdvantage; public int lightSide; public int darkSide;

    // Start is called before the first frame update
    void Start()
    {
        ss = FindObjectOfType<SkillsScript>();


        greenDieText.text = "Green Dice: " + greenDie.ToString();
        yellowDieText.text = "Yellow Dice: " + yellowDie.ToString();
        purpleDieText.text = "Purple Dice: " + purpleDie.ToString();
        redDieText.text = "Red Dice: " + redDie.ToString();
        blueDieText.text = "Blue Dice: " + blueDie.ToString();
        blackDieText.text = "Black Dice: " + blackDie.ToString();
        whiteDieText.text = "White Dice: " + whiteDie.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayDice()
    {
        success = 0;
        advantage = 0;
        triumph = 0;
        failure = 0;
        threat = 0;
        despair = 0;
        lightSide = 0;
        darkSide = 0;
        totalSuccess = 0;
        totalAdvantage = 0;

        GreenDice(8);
        YellowDice(12);
        RedDice(12);
        PurpleDice(8);
        BlackDice(6);
        BlueDice(6);
        WhiteDice(12);

        greenDieText.text = "Green Dice: " + greenDie.ToString();
        yellowDieText.text = "Yellow Dice: " + yellowDie.ToString();
        purpleDieText.text = "Purple Dice: " + purpleDie.ToString();
        redDieText.text = "Red Dice: " + redDie.ToString();
        blueDieText.text = "Blue Dice: " + blueDie.ToString();
        blackDieText.text = "Black Dice: " + blackDie.ToString();
        whiteDieText.text = "White Dice: " + whiteDie.ToString();

        //     EndResult
        totalSuccess = success - failure;
        totalAdvantage = advantage - threat;


        //     Success/Failure     &     Triumph Text
        if (totalSuccess == 0 && triumph == 0)
        {
            totalSuccessText.text = "0 Success, 0 Triumph";
        }
        else if (totalSuccess > 0 && triumph == 0)
        {
            totalSuccessText.text = totalSuccess + " Success";
        }
        else if (totalSuccess < 0 && triumph == 0)
        {
            totalSuccessText.text = totalSuccess*-1 + " Failure";
        }
        else if (totalSuccess == 0 && triumph > 0)
        {
            totalSuccessText.text = triumph + " Triumph";
        }
        else if (totalSuccess > 0 && triumph > 0)
        {
            totalSuccessText.text = totalSuccess + " Success, " + triumph + " Triumph";
        }
        else if (totalSuccess < 0 && triumph > 0)
        {
            totalSuccessText.text = totalSuccess*-1 + " Failure, " + triumph + " Triumph";
        }



        //     Advantage/Threat     &     Despair Text
        if (despair == 0 && totalAdvantage == 0)
        {
            totalAdvantageText.text = "0 Advantage, 0 Despair";
        }
        else if (despair == 0 && totalAdvantage > 0)
        {
            totalAdvantageText.text = totalAdvantage + " Advantage";
        }
        else if (despair == 0 && totalAdvantage < 0)
        {
            totalAdvantageText.text = totalAdvantage*-1 + " Threat";
        }
        else if (despair > 0 && totalAdvantage == 0)
        {
            totalAdvantageText.text = despair + " Despair";
        }
        else if (despair > 0 && totalAdvantage > 0)
        {
            totalAdvantageText.text = totalAdvantage + " Advantage, " + despair + " Despair";
        }
        else if (despair > 0 && totalAdvantage < 0)
        {
            totalAdvantageText.text = totalAdvantage*-1 + " Threat, " + despair + " Despair";
        }
    }

    public void AddDie(string dieType)
    {
        if (dieType == "Green Die")
        {
            greenDie++;
        }
        if (dieType == "Yellow Die")
        {
            yellowDie++;
        }
        if (dieType == "Purple Die")
        {
            purpleDie++;
        }
        if (dieType == "Red Die")
        {
            redDie++;
        }
        if (dieType == "Blue Die")
        {
            blueDie++;
        }
        if (dieType == "Black Die")
        {
            blackDie++;
        }
        if (dieType == "White Die")
        {
            whiteDie++;
        }


        greenDieText.text = "Green Dice: " + greenDie.ToString();
        yellowDieText.text = "Yellow Dice: " + yellowDie.ToString();
        purpleDieText.text = "Purple Dice: " + purpleDie.ToString();
        redDieText.text = "Red Dice: " + redDie.ToString();
        blueDieText.text = "Blue Dice: " + blueDie.ToString();
        blackDieText.text = "Black Dice: " + blackDie.ToString();
        whiteDieText.text = "White Dice: " + whiteDie.ToString();
    }

    public void SubtractDie(string dieType)
    {
        if (dieType == "Green Die" && greenDie > 0)
        {
            greenDie--;
        }
        if (dieType == "Yellow Die" && yellowDie > 0)
        {
            yellowDie--;
        }
        if (dieType == "Purple Die" && purpleDie > 0)
        {
            purpleDie--;
        }
        if (dieType == "Red Die" && redDie > 0)
        {
            redDie--;
        }
        if (dieType == "Blue Die" && blueDie > 0)
        {
            blueDie--;
        }
        if (dieType == "Black Die" && blackDie > 0)
        {
            blackDie--;
        }
        if (dieType == "White Die" && whiteDie > 0)
        {
            whiteDie--;
        }

        greenDieText.text = "Green Dice: " + greenDie.ToString();
        yellowDieText.text = "Yellow Dice: " + yellowDie.ToString();
        purpleDieText.text = "Purple Dice: " + purpleDie.ToString();
        redDieText.text = "Red Dice: " + redDie.ToString();
        blueDieText.text = "Blue Dice: " + blueDie.ToString();
        blackDieText.text = "Black Dice: " + blackDie.ToString();
        whiteDieText.text = "White Dice: " + whiteDie.ToString();
    }

    public void GreenDice(int diceNumberOfSides)
    {
        while (greenDie > 0)
        {
            greenDie--;
            int randomNum = Random.Range(1, diceNumberOfSides+1);

            if (randomNum == 1)
            {

            }
            else if (randomNum == 2)
            {
                advantage = advantage + 2;
            }
            else if (randomNum == 3)
            {
                success = success + 1;
            }
            else if (randomNum == 4)
            {
                advantage = advantage + 1;
            }
            else if (randomNum == 5)
            {
                success = success + 2;
            }
            else if (randomNum == 6)
            {
                success = success + 1;
                advantage = advantage + 1;
            }
            else if (randomNum == 7)
            {
                advantage = advantage + 1;
            }
            else if (randomNum == 8)
            {
                success = success + 1;
            }
        }
    }

    public void YellowDice(int diceNumberOfSides)
    {
        while (yellowDie > 0)
        {
            yellowDie--;
            int randomNum = Random.Range(1, diceNumberOfSides+1);

            if (randomNum == 1)
            {
                
            }
            else if (randomNum == 2)
            {
                success = success + 2;
            }
            else if (randomNum == 3)
            {
                success = success + 1;
                advantage = advantage + 1;
            }
            else if (randomNum == 4)
            {
                success = success + 2;
            }
            else if (randomNum == 5)
            {
                success = success + 1;
                advantage = advantage + 1;
            }
            else if (randomNum == 6)
            {
                success = success + 1;
            }
            else if (randomNum == 7)
            {
                success = success + 1;
                advantage = advantage + 1;
            }
            else if (randomNum == 8)
            {
                success = success + 1;
            }
            else if (randomNum == 9)
            {
                triumph = triumph + 1;
            }
            else if (randomNum == 10)
            {
                advantage = advantage + 2;
            }
            else if (randomNum == 11)
            {
                advantage = advantage + 1;
            }
            else if (randomNum == 12)
            {
                advantage = advantage + 2;
            }
        }
    }

    public void RedDice(int diceNumberOfSides)
    {
        while (redDie > 0)
        {
            redDie--;
            int randomNum = Random.Range(1, diceNumberOfSides+1);

            if (randomNum == 1)
            {
                
            }
            else if (randomNum == 2)
            {
                failure = failure + 2;
            }
            else if (randomNum == 3)
            {
                despair = despair + 1;
            }
            else if (randomNum == 4)
            {
                failure = failure + 2;
            }
            else if (randomNum == 5)
            {
                failure = failure + 1;
            }
            else if (randomNum == 6)
            {
                failure = failure + 1;
                threat = threat + 1;
            }
            else if (randomNum == 7)
            {
                failure = failure + 1;
            }
            else if (randomNum == 8)
            {
                failure = failure + 1;
                threat = threat + 1;
            }
            else if (randomNum == 9)
            {
                threat = threat + 1;
            }
            else if (randomNum == 10)
            {
                threat = threat + 2;
            }
            else if (randomNum == 11)
            {
                threat = threat + 1;
            }
            else if (randomNum == 12)
            {
                threat = threat + 2;
            }
        }
    }

    public void PurpleDice(int diceNumberOfSides)
    {
        while (purpleDie > 0)
        {
            purpleDie--;
            int randomNum = Random.Range(1, diceNumberOfSides+1);

            if (randomNum == 1)
            {
                threat = threat + 1;
            }
            else if (randomNum == 2)
            {
                failure = failure + 2;
            }
            else if (randomNum == 3)
            {
                threat = threat + 2;
            }
            else if (randomNum == 4)
            {
                
            }
            else if (randomNum == 5)
            {
                threat = threat + 1;
            }
            else if (randomNum == 6)
            {
                failure = failure + 1;
                threat = threat + 1;
            }
            else if (randomNum == 7)
            {
                failure = failure + 1;
            }
            else if (randomNum == 8)
            {
                threat = threat + 1;
            }
        }
    }

    public void BlackDice(int diceNumberOfSides)
    {
        while (blackDie > 0)
        {
            blackDie--;
            int randomNum = Random.Range(1, diceNumberOfSides+1);

            if (randomNum == 1)
            {
                failure = failure + 1;
            }
            else if (randomNum == 2)
            {
                failure = failure + 1;
            }
            else if (randomNum == 3)
            {
                threat = threat + 1;
            }
            else if (randomNum == 4)
            {
                threat = threat + 1;
            }
            else if (randomNum == 5)
            {
                
            }
            else if (randomNum == 6)
            {
                
            }
        }
    }

    public void BlueDice(int diceNumberOfSides)
    {
        while (blueDie > 0)
        {
            blueDie--;
            int randomNum = Random.Range(1, diceNumberOfSides+1);

            if (randomNum == 1)
            {
                
            }
            else if (randomNum == 2)
            {
                success = success + 1;
            }
            else if (randomNum == 3)
            {
                
            }
            else if (randomNum == 4)
            {
                advantage = advantage + 2;
            }
            else if (randomNum == 4)
            {
                advantage = advantage + 1;
            }
            else if (randomNum == 5)
            {
                success = success + 1;
                advantage = advantage + 1;
            }
            else if (randomNum == 6)
            {
                advantage = advantage + 1;
            }
        }
    }

    public void WhiteDice(int diceNumberOfSides)
    {
        while (whiteDie > 0)
        {
            whiteDie--;
            int randomNum = Random.Range(1, diceNumberOfSides+1);

            if (randomNum == 1)
            {
                darkSide = darkSide + 2;
            }
            else if (randomNum == 2)
            {
                darkSide = darkSide + 1;
            }
            else if (randomNum == 3)
            {
                lightSide = lightSide + 1;
            }
            else if (randomNum == 4)
            {
                darkSide = darkSide + 1;
            }
            else if (randomNum == 5)
            {
                lightSide = lightSide + 1;
            }
            else if (randomNum == 6)
            {
                darkSide = darkSide + 1;
            }
            else if (randomNum == 7)
            {
                lightSide = lightSide + 2;
            }
            else if (randomNum == 8)
            {
                darkSide = darkSide + 1;
            }
            else if (randomNum == 9)
            {
                lightSide = lightSide + 2;
            }
            else if (randomNum == 10)
            {
                darkSide = darkSide + 1;
            }
            else if (randomNum == 11)
            {
                lightSide = lightSide + 2;
            }
            else if (randomNum == 12)
            {
                darkSide = darkSide + 1;
            }
        }
    }
}
