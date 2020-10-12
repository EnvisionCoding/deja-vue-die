using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class ItemSC : ScriptableObject
{
    // Start is called before the first frame update
    public new string name;
    public string description;
    public Sprite sprite;

    public float scoreMultiplier;

    public string useText;

}
