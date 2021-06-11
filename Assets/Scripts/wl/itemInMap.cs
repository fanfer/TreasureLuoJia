using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemInMap : MonoBehaviour
{
    public Items thisItem;
    public Inventory playerInventory;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "unitychan")
        {
            AddNewItem();
            Destroy(gameObject);
        }
    }

    public void AddNewItem()
    {
        if (!playerInventory.itemList.Contains(thisItem))
        {
            playerInventory.itemList.Add(thisItem);
        }
        else
        {
            thisItem.itemHeld += 1;
        }
        InventoryManage.RefreshItem();
    }
}
