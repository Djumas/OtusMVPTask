using UnityEngine;

public interface IPresenter
{
    Sprite Image { get; }
    int Cost { get; }
    string Name { get; }

    void OnCancel();
    void OnConfirm();
}

