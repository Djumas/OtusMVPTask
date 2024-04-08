using UnityEngine;
using UnityEngine.UI;

public class BuyConfirmPresenter : IPresenter
{
    private readonly Sprite _image;
    private readonly int _cost;
    private readonly string _name;

    public Sprite Image => _image;
    public int Cost => _cost;
    public string Name => _name;
    

    public BuyConfirmPresenter(ShopItemSO item)
    {
        _image = item.Image;
        _cost = item.Cost;
        _name = item.Name;
    }

    public void OnConfirm() 
    {
        Debug.Log("Purchase confirmed");
        MoneyStorage.Instance.SpendMoney(_cost);

    }

    public void OnCancel() 
    {
        Debug.Log("Purchase canceled");
    }
}
