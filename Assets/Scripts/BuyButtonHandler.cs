using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class BuyButtonHandler : MonoBehaviour
{
    [SerializeField] ConfirmBuyItemPopUp _popup;

    [SerializeField] Button _buyButton;
    readonly List<IPresenter> _buyConfirmPresenters = new List<IPresenter>();

    [SerializeField] private List<ShopItemSO> _item;

    private void Start()
    {
        foreach (ShopItemSO item in _item)
        {
            _buyConfirmPresenters.Add(new BuyConfirmPresenter(item));
        }

    }

    public void OnEnable()
    {
        _buyButton.onClick.AddListener(ShowPopUp);

    }
    public void SetAnyPresenter()
    {
        _popup.Show(_buyConfirmPresenters.FirstOrDefault());
    }
    public void ShowPopUp()
    {
        _popup.gameObject.SetActive(true);
        SetAnyPresenter();
    }
    private void OnDisable()
    {
        _buyButton?.onClick.RemoveListener(ShowPopUp);
    }
}
