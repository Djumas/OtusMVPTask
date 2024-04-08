using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmBuyItemPopUp : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Button buttonConfirm;
    [SerializeField] private Button buttonCancel;
    [SerializeField] private TMP_Text text;
    private IPresenter _presenter;

    public void Show(IPresenter presenter)
    {
        _presenter = presenter;
        image = presenter.Image;
        text.text = $"Spend {presenter.Cost} gems on {presenter.Name}?";
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
    
