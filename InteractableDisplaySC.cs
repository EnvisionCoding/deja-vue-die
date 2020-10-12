using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDisplaySC : MonoBehaviour
{
    public InteractableObjectSC obj;
    public Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = obj.orginalSprite;
        GetComponentInChildren<SpriteRenderer>().sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
