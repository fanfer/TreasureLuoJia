using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Item", menuName = "Inventory/new Inventory")]
public class Inventory : ScriptableObject
{
    public List<Items> itemList = new List<Items>();
}
