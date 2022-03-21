using UnityEngine;
using UnityEngine.UI;

public class AuthorsPanel : Panel
{
    [SerializeField] private Button _back;

    private void OnEnable()
    {
        _back.onClick.AddListener(OnBackButtonClick);   
    }

    private void OnDisable()
    {
        _back.onClick.RemoveListener(OnBackButtonClick);
    }

    private void OnBackButtonClick()
    {
        PanelActivator(AuthorsPanel, MenuPanel);
    }
}
