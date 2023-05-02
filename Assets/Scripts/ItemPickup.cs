using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPickup : MonoBehaviour, IPointerClickHandler
{
    public Item item;

    void Pickup()
    {
        InventoryManager.Instance.Add(item);
        Destroy(gameObject);
    }

	public void OnPointerClick(PointerEventData pointerEventData)
	{
        Pickup();
	}
}
