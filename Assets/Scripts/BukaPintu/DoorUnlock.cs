using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUnlock : MonoBehaviour
{
	public GameObject Tutup;
	public GameObject Masuk;
	public GameObject Gembok;
	public InventoryManager itemcontainer;
    public Item item;

    public void OnOpenButtonClick()
    {
		if (itemcontainer.ItemCount(item) > 0)
		{
			Tutup.SetActive(false);
			Gembok.SetActive(false);
			Masuk.SetActive(true);
			Debug.Log("Berhasil!");
			itemcontainer.Remove(item);
		}
		else
		{
			Debug.Log("Not enough materials!");
		}
	}
}
