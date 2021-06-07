using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slot : MonoBehaviour
{
    public Items slotItem;
    public Image slotImage;
    public Text slotNum;

    public void ItemOnClicked()
    {
        InventoryManage.UpdateItemInfo(slotItem.itemInfo);
    }
}
