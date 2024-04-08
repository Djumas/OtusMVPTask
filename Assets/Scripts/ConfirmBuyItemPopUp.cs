using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmBuyItemPopUp : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Button _buttonConfirm;
    [SerializeField] private Button _buttonCancel;
    [SerializeField] private TMP_Text _text;
    private IPresenter _presenter;

    public void Show(IPresenter presenter)
    {
        _presenter = presenter;
        _image.sprite = presenter.Image;
        _text.text = $"Spend {presenter.Cost} gems on {presenter.Name}?";
        _buttonCancel.onClick.AddListener(OnCancel);
        _buttonConfirm.onClick.AddListener(OnConfirm);
    }

    public void Hide() 
    {
        gameObject.SetActive(false);
        _buttonCancel.onClick.RemoveListener(OnCancel);
        _buttonConfirm.onClick.RemoveListener(OnConfirm);
    }

    private void OnCancel() 
    {
        Hide();
        _presenter.OnCancel();
    }

    private void OnConfirm()
    {
        Hide();
        _presenter.OnConfirm();
    }
}
    
