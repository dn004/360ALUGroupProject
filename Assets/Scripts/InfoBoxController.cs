using UnityEngine;

public class PanelToggler : MonoBehaviour
{
    public GameObject panel;

    public void TogglePanel()
    {
        if (panel != null)
        {
            bool isActive = panel.activeSelf;
            panel.SetActive(!isActive);
        }
    }
}
