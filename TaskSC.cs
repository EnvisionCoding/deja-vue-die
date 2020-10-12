using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Task", menuName = "Task")]
public class TaskSC : ScriptableObject
{
    public int ID;
    public new string name;
    public string task;

    public ItemSC neededItem;

    public float maxScore;
}
