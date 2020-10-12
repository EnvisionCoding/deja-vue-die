using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using EnvisionCoding.CharacterStats;

public class CharacterSC : MonoBehaviour {

    public InventorySC inventory;
    public Canvas gameUI;
    public Text healthText;
    public Text scoreText;
    private Rigidbody2D rd2b;

    public CharacterStatsSC Health;
    public CharacterStatsSC Score;
    public CharacterStatsSC MovementSpeed;

    private float horizontal;
    private float vertical;
    private float SpeedLimiter = 0.7f;   // this is if we move diagonal, lets cap the speed so it does not move faster than we want.

    StorageObjectSC storageObject;

    public GameObject spawnLocation;

    public ObjectiveSC currentObj;

	// Use this for initialization
	void Start () {
        this.transform.position = spawnLocation.transform.position;

        Health.Amount = 4;
        Score.Amount = 0;

        updateHealthUI();

        rd2b = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    public void updateHealthUI()
    {
        healthText.text = "x" + Health.Amount.ToString();
    }

    public void updateScoreUI()
    {
        scoreText.text = Score.Amount.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Storage"))
        {            
            gameUI.GetComponent<DialogBoxSC>().display = true;

            storageObject = collision.GetComponent<StorageObjectDisplaySC>().storage;

            if(storageObject.isEmpty)
            {
                gameUI.GetComponent<DialogBoxSC>().hideButton();
                gameUI.GetComponent<DialogBoxSC>().updateText(storageObject.emptyText + " Better luck next time!");
            }
            else
            {
                gameUI.GetComponent<DialogBoxSC>().showButton();
                gameUI.GetComponent<DialogBoxSC>().updateText("You found a " + storageObject.heldItem.name + ", " + storageObject.heldItem.description +
                " Would you like to use it?");
            }            
        }
    }

    public void useItem()
    {
        switch(currentObj.currentObjective.ID)
        {
            case 0:
                {
                    if (storageObject.heldItem.name == currentObj.currentObjective.neededItem.name)
                    {
                        Score.UpdateAmount(currentObj.currentObjective.maxScore, true);

                        storageObject.isEmpty = true;
                        onDeath();
                    }
                    else
                    {
                        Score.UpdateAmount(100, false);
                    }

                    updateScoreUI();
                    break;
                }
            case 1:
                {
                    if (storageObject.heldItem.name == currentObj.currentObjective.neededItem.name)
                    {
                        Score.UpdateAmount(currentObj.currentObjective.maxScore, true);

                        storageObject.isEmpty = true;
                        onDeath();
                    }
                    else
                    {
                        Score.UpdateAmount(100, false);
                    }

                    updateScoreUI();
                    break;
                }
            case 2:
                {
                    if (storageObject.heldItem.name == currentObj.currentObjective.neededItem.name)
                    {
                        Score.UpdateAmount(currentObj.currentObjective.maxScore, true);

                        storageObject.isEmpty = true;
                        onDeath();
                    }
                    else
                    {
                        Score.UpdateAmount(100, false);
                    }

                    updateScoreUI();
                    break;
                }
            case 3:
                {
                    if (storageObject.heldItem.name == currentObj.currentObjective.neededItem.name)
                    {
                        Score.UpdateAmount(currentObj.currentObjective.maxScore, true);

                        storageObject.isEmpty = true;
                        onDeath();
                    }
                    else
                    {
                        Score.UpdateAmount(100, false);
                    }

                    updateScoreUI();
                    break;
                }
            default:
                {
                    Debug.Log("Should not reach here.");
                    break;
                }
                
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Storage"))
        {
            gameUI.GetComponent<DialogBoxSC>().display = false;
        }
    }

    public void getFoundItem()
    {
        string newText = "You found a " + storageObject.heldItem.name + ", " + storageObject.heldItem.description;
        gameUI.GetComponent<DialogBoxSC>().updateText(newText);
    }



    //Call physics updates here.
    private void FixedUpdate()
    {
        if(horizontal != 0 && vertical != 0)
        {
            horizontal *= SpeedLimiter;
            vertical *= SpeedLimiter;
        }

        rd2b.velocity = new Vector2(horizontal * MovementSpeed.Amount, vertical * MovementSpeed.Amount);
    }

    /*
     * Called when the player completes the current objective
     * 
     * currentObj - Current Objective
     */
    public void onDeath()
    {
        currentObj.stop = true;
        currentObj.completeObjective();
        currentObj.nextObjective();
        Health.UpdateAmount(1, false);
        this.transform.position = spawnLocation.transform.position;
        updateHealthUI();
    }
}
