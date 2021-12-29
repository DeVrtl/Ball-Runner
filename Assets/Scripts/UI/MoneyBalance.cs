using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyBalance : MonoBehaviour
{
    [SerializeField] private Text _money;
    [SerializeField] private BallMoney _ballMoney;

    private void OnEnable()
    {
        _ballMoney.MoneyChanged += OnMoneyChanged;
    }

    private void OnDisable()
    {
        _ballMoney.MoneyChanged -= OnMoneyChanged;
    }

    private void OnMoneyChanged(int money)
    {
        _money.text = money.ToString();
    }
}
