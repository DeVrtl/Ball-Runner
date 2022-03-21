using System;
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

        Validate();
    }

    private void OnDisable()
    {
        _ballMoney.MoneyChanged -= OnMoneyChanged;
    }

    private void Validate()
    {
        if (_ballMoney == null)
            throw new InvalidOperationException();

        if (_money == null)
            throw new InvalidOperationException();
    }

    private void OnMoneyChanged(int money)
    {
        _money.text = money.ToString();
    }
}
