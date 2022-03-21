using UnityEngine;
using UnityEngine.UI;
using IJunior.TypedScenes;

public class MenuPanel : Panel
{
    [SerializeField] private Button _play; 
    [SerializeField] private Button _аuthors; 
    [SerializeField] private Button _exit;

    private void OnEnable()
    {
        _play.onClick.AddListener(OnPlayButtonClick);
        _аuthors.onClick.AddListener(OnAuthorsButtonClick);
        _exit.onClick.AddListener(OnExitButtonClick);
    }

    private void OnDisable()
    {
        _play.onClick.RemoveListener(OnPlayButtonClick);
        _аuthors.onClick.RemoveListener(OnAuthorsButtonClick);
        _exit.onClick.RemoveListener(OnExitButtonClick);
    }

    private void OnPlayButtonClick()
    {
        Game.Load();
    }

    private void OnAuthorsButtonClick()
    {
        PanelActivator(MenuPanel, AuthorsPanel);
    }

    private void OnExitButtonClick()
    {
        Application.Quit();
    }
}
