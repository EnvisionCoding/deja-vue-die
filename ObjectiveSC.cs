using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveSC : MonoBehaviour
{
    public int completedObjectives = 0;

    [SerializeField]
    public List<TaskSC> objectives = new List<TaskSC>();
    public TaskSC currentObjective;

    public Text objectiveText;
    public Text possibleScoreText;

    public bool stop = false;


    // Start is called before the first frame update
    void Start()
    {
        nextObjective();
        StartCoroutine(decreasePossibleScore());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextObjective()
    {
        if(completedObjectives <= objectives.Count)
        {
            currentObjective = objectives[completedObjectives];
            currentObjective.maxScore = 1000;
            stop = false;
            objectiveText.text = currentObjective.task;
            
            possibleScoreText.text = currentObjective.maxScore.ToString();
            
        }
    }

    public void completeObjective()
    {
        completedObjectives++;
    }

    private IEnumerator decreasePossibleScore()
    {
        while (!stop)
        {
            if(currentObjective.maxScore > 0)
            {
                currentObjective.maxScore = currentObjective.maxScore - 10; ;
            }

            yield return new WaitForSeconds(1);
        }
    }
}
