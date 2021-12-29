using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Panel : MonoBehaviour
{
    [SerializeField] protected GameObject MenuPanel;
    [SerializeField] protected GameObject AuthorsPanel;

    protected void PanelActivator(GameObject firstPanel, GameObject secondPanel)
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(true);
    }
}
