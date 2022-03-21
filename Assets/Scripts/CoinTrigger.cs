using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    [SerializeField] private int _reward;

    private void OnValidate()
    {
        _reward = Mathf.Clamp(_reward, 0, int.MaxValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<BallMoney>(out BallMoney ballMoney))
        {
            ballMoney.AddMoney(_reward);
            Destroy(gameObject);
        }
    }
}
