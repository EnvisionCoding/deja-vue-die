using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogBoxSC : MonoBehaviour
{
    public CanvasGroup dialogBox;
    public CanvasGroup UseBox;
    public CanvasGroup buttonGroup;

    public bool display = false;
    public bool searched = false;
    public bool found = false;

    public Text displayText;

    // Start is called before the first frame update
    void Start()
    {
        display = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (display == false)
            hideDialogBox();
        else
            showDialogBox();
    }

    public void updateText(string text)
    {
        displayText.text = text;
    }


    public void hideDialogBox()
    {
        dialogBox.alpha = 0.0f;
        dialogBox.blocksRaycasts = false;

        hideUseBox();
    }

    public void showDialogBox()
    {
        dialogBox.alpha = 1.0f;
        dialogBox.blocksRaycasts = true;

        showUseBox();
    }

    public void showButton()
    {
        buttonGroup.alpha = 1.0f;
        buttonGroup.blocksRaycasts = true;
    }

    public void hideButton()
    {
        buttonGroup.alpha = 0.0f;
        buttonGroup.blocksRaycasts = false;
    }

    public void hideUseBox()
    {
        UseBox.alpha = 0.0f;
        UseBox.blocksRaycasts = false;
    }

    public void showUseBox()
    {
        UseBox.alpha = 1.0f;
        UseBox.blocksRaycasts = true;
    }
    

}
