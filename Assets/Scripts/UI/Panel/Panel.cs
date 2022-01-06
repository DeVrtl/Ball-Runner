using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Panel : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _authorsPanel;

    public GameObject MenuPanel => _menuPanel;
    public GameObject AuthorsPanel => _authorsPanel;

    protected void PanelActivator(GameObject firstPanel, GameObject secondPanel)
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(true);
    }
}
