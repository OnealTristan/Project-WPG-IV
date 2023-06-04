using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakKursi : MonoBehaviour
{
    public GameObject kursi;
    public InventoryManager inventoryManager;
    public Item item, balokKayu;

    public void OnButtonClick()
    {
        if (inventoryManager.ItemCount(item) > 0)
        {
            inventoryManager.Remove(item);
            inventoryManager.Add(balokKayu);
            kursi.SetActive(false);
			Debug.Log("Berhasil!");
		}
		else
		{
			Debug.Log("Not enough materials!");
		}
	}
}
