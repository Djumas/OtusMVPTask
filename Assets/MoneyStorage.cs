using TMPro;
using UnityEngine;

public class MoneyStorage : MonoBehaviour
{

    static public MoneyStorage Instance;
    [SerializeField] private int _money;

    [SerializeField] private TMP_Text _moneyText;
    private void Awake()
    {
        Instance = this;
    }

    public void Start()
    {
        _moneyText.text = _money.ToString();
    }
    public void SpendMoney(int money)
    { 
        _money -= money;
        _moneyText.text = _money.ToString();
    }

    
}
