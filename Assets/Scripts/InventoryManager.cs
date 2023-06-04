using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour, IItemContainer
{
    public static InventoryManager Instance;
	public List<Item> Items = new List<Item>();

	public Transform ItemContent;
	public InventoryItem inventoryItem;

	private List<InventoryItem> inventoryItemList = new List<InventoryItem>();

	public void Awake()
	{
		Instance = this;
	}

	public void Add (Item item)
	{
		Items.Add(item);

		InventoryItem obj = Instantiate(inventoryItem, ItemContent);
		inventoryItemList.Add(obj);
		
		obj.item = item;
		obj.image.sprite = item.icon;
	}

	public bool Remove(Item item)
	{
		for (int i = 0; i < inventoryItemList.Count; i++)
		{
            if (inventoryItemList[i].item == item)
            {
				Items.Remove(item);
				Destroy(inventoryItemList[i].gameObject);
				return true;
			}
		}
		return false;
	}

	public bool ContainsItem(Item item)
	{
		for (int i = 0; i < Items.Count; i++)
		{
			if (Items[i] == item)
			{
				return false;
			}
		}
		return true;
	}

	public int ItemCount(Item item)
	{
		int number = 0;

		for (int i = 0; i < Items.Count; i++)
		{
			if (Items[i] == item)
			{
				number++;
			}
		}

		return number;
    }
}