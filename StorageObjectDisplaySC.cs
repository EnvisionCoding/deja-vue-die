using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageObjectDisplaySC : MonoBehaviour
{
    public StorageObjectSC storage;
    public Sprite sprite;

    //public Sprite testSprite;

    // Start is called before the first frame update
    void Start()
    {
        if (storage.heldItem == null)
            storage.isEmpty = true;
        else
            storage.isEmpty = false;

        sprite = storage.sprite;
        GetComponentInChildren<SpriteRenderer>().sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
