using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Interactable", menuName = "Interactable Object")]
public class InteractableObjectSC : ScriptableObject
{
    public string Name;
    public string description;
    public Sprite orginalSprite;
    public Sprite interactedSprite;

    public bool updateSprite = false;

    public string interactionText;

}
