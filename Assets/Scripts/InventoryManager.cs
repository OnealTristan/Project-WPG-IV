using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
	public List<Item> Items = new List<Item>();

	public Transform ItemContent;
	public GameObject InventoryItem;

	public void Awake()
	{
		Instance = this;
	}

	public void Add (Item item)
	{
		Items.Add(item);

		GameObject obj = Instantiate(InventoryItem, ItemContent);
		var ItemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

		ItemIcon.sprite = item.icon;
	}

	public void Remove(Item item)
	{
		Items.Remove(item);
	}
}