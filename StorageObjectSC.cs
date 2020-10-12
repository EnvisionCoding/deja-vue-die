using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Storage Item", menuName = "Storage Item")]
public class StorageObjectSC : ScriptableObject
{
    [SerializeField]
    public ItemSC heldItem;
    public bool isEmpty;

    public string Name;
    public string description;
    public Sprite sprite;
    public bool locked;

    public string lockedText;
    public string emptyText;


}
