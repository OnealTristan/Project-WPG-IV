using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingRecipeUI : MonoBehaviour
{
    public InventoryManager InventoryManager;
    public CraftingRecipe craftingRecipe;

    public void OnCraftButtonClick()
    {
        if (craftingRecipe != null && InventoryManager != null)
        {
            if (craftingRecipe.CanCraft(InventoryManager))
            {
                craftingRecipe.Craft(InventoryManager);
				Debug.Log("Berhasil!");
			}
            else
            {
                Debug.Log("Not enough materials!");
            }
		}else
        {
			Debug.Log("Salah!");
		}		
	}
}
