using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ConfirmBuyItemPopUp : MonoBehaviour
{
    [SerializeField] private Sprite image;
    [SerializeField] private Button buttonConfirm;
    [SerializeField] private Button buttonCancel;
    [SerializeField] private TMP_Text text;
    private BuyConfirmPresenter _presenter;

    public void Show(BuyConfirmPresenter presenter)
    {
        _presenter = presenter;
        gameObject.SetActive(true);
        image = presenter.image;
        text.text = $"Spend {presenter.cost} gems on {presenter.name}?";
        buttonCancel.onClick.AddListener(OnCancel);
        buttonConfirm.onClick.AddListener(OnConfirm);
    }

    public void Hide() {
        gameObject.SetActive(false);
        buttonCancel.onClick.RemoveListener(OnCancel);
        buttonConfirm.onClick.RemoveListener(OnConfirm);
    }

    private void OnCancel() {
        this.Hide();
        _presenter.OnCancel();
    }

    private void OnConfirm()
    {
        this.Hide();
        _presenter.OnConfirm();
    }


}
    
