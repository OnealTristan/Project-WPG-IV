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
        foreach (Transform item_ in ItemContent)
        {
			Destroy(item_.gameObject);
		}
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