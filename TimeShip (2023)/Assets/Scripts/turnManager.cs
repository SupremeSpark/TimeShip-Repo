using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class turnManager : MonoBehaviour
{
    public TextMeshProUGUI turnNumText;
    public TextMeshProUGUI loopNumText;
    public TextMeshProUGUI timeLimText;
    public int turnNum;
    public int loopNum;
    public float timeLimPercent;
    public int turnLim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        updateText();
    }
    public void updateText()
    {
        turnNumText.text = "Turn: " + turnNum;
        loopNumText.text = "Loop: " + loopNum;
        timeLimText.text = "TimeShip Strain: " + findStrain(turnNum, turnLim) + "%";
    }

//finds the percentage to the final turn, if turnlim 100 and turn 10, strain = 10%
    public float findStrain(int turnNum, int timeLim){
        float timeLimPercent = turnNum / timeLim;
        timeLimPercent = timeLimPercent * 100;
        return timeLimPercent;
    }
}
