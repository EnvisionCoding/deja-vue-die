using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySC : MonoBehaviour {

    bool hasMatches = false;
    bool hasDrawerKey = false;
    bool hasGarageKey = false;
    bool hasToaster = false;

    public int slots = 4;
    public GameObject slot1;    //Drawer Key
    public GameObject slot2;    //Garage Key
    public GameObject slot3;    //Matches
    public GameObject slot4;    //Toaster

    [SerializeField]
    public List<ItemSC> dataBase = new List<ItemSC>();

    [SerializeField]
    public List<ItemSC> itemCollection = new List<ItemSC>();
    public List<GameObject> slotCollection = new List<GameObject>();

    public void AddItem(ItemSC item)
    {
        if (item.name == "Drawer Key")
        {
            slot1.GetComponent<SpriteRenderer>().sprite = item.sprite;
            hasDrawerKey = true;
        }
        else if (item.name == "Garage Key")
        {
            slot2.GetComponent<SpriteRenderer>().sprite = item.sprite;
            hasGarageKey = true;
        }
        else if(item.name == "Matches")
        {
            slot3.GetComponent<SpriteRenderer>().sprite = item.sprite;
            hasMatches = true;
        }
        else if(item.name == "Toaster")
        {
            slot4.GetComponent<SpriteRenderer>().sprite = item.sprite;
            hasToaster = true;
        }
    }

    public void RemoveItem(ItemSC item)
    {
        if (item.name == "Drawer Key")
        {
            slot1.GetComponent<SpriteRenderer>().sprite = null;
            hasDrawerKey = false;
        }
        else if (item.name == "Garage Key")
        {
            slot2.GetComponent<SpriteRenderer>().sprite = null;
            hasGarageKey = false;
        }
        else if (item.name == "Matches")
        {
            slot3.GetComponent<SpriteRenderer>().sprite = null;
            hasMatches = false;
        }
        else if (item.name == "Toaster")
        {
            slot4.GetComponent<SpriteRenderer>().sprite = null;
            hasToaster = false;
        }
    }
}
