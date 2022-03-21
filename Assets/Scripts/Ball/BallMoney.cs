using System;
using UnityEngine;
using UnityEngine.Events;

public class BallMoney : MonoBehaviour
{
    public int Money { get; private set; }

    public event UnityAction<int> MoneyChanged;

    public void AddMoney(int amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(nameof(amount));
        
        Money += amount;

        MoneyChanged?.Invoke(Money);
    }
}
