using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDisplaySC : MonoBehaviour
{
    public ItemSC item;
    public Sprite sprite;

    //public Sprite testSprite;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Item name: " + item.name);
        sprite = item.sprite;
        GetComponentInChildren<SpriteRenderer>().sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
