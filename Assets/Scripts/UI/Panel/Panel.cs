using System;
using System.Collections.Generic;
using UnityEngine;


public abstract class Panel : MonoBehaviour
{
    [SerializeField] private Panel _menuPanel;
    [SerializeField] private Panel _authorsPanel;

    public Panel MenuPanel => _menuPanel;
    public Panel AuthorsPanel => _authorsPanel;

    private void OnEnable()
    {
        Validate();
    }

    public void Validate()
    {
        if (_menuPanel == null)
            throw new InvalidOperationException();

        if (_authorsPanel == null)
            throw new InvalidOperationException();
    }

    protected void PanelActivator(Panel firstPanel, Panel secondPanel)
    {
        firstPanel.gameObject.SetActive(false);
        secondPanel.gameObject.SetActive(true);
    }
}
