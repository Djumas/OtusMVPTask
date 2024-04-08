using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    List<IPresenter> _buyConfirmPresenters;

    [SerializeField] private List<ShopItemSO> _item;

    private void Start()
    {
        foreach (ShopItemSO item in _item) 
        {
            _buyConfirmPresenters.Add(new BuyConfirmPresenter(item));
        }
        
    }
}
