using UnityEngine.UI;

public interface IPresenter
{
    Image Image { get; }
    int Cost {  get;}
    string Name { get; }

    void OnCancel();
    void OnConfirm();
}

