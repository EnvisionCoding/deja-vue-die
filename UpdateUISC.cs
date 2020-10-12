using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUISC : MonoBehaviour
{
    public Text characterHealth;
    public Text characterScore;
    public Text potentialScore;

    public Text endScoretext;

    public bool updateHealth = false;

    public TaskSC currentObj;
    public CharacterSC character;

    // Start is called before the first frame update
    void Start()
    {
        currentObj = GetComponent<ObjectiveSC>().currentObjective;
        characterScore.text = character.Score.Amount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        currentObj = GetComponent<ObjectiveSC>().currentObjective;
        potentialScore.text = currentObj.maxScore.ToString();

        updateEndScore();
    }

    public void updateEndScore()
    {
        endScoretext.text = character.Score.Amount.ToString();
    }
}
