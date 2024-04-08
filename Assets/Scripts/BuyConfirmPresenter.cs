using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyConfirmPresenter
{
    public Sprite image;
    public int cost;
    public string name;

    public BuyConfirmPresenter(ShopItemSO item)
    {
        image = item.image;
        cost = item.cost;
        name = item.name;
    }

    public void OnConfirm() {
        Debug.Log("Purchase confirmed");
    }

    public void OnCancel() {
        Debug.Log("Purchase canceled");
    }
}
