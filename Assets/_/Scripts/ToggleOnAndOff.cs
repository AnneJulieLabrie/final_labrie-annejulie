using UnityEngine;
using UnityEngine.UI;

public class ToggleOnAndOff : MonoBehaviour
{
    
    [SerializeField]
    private GameObject panel;

    private bool panelIsEnabled;
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        panelIsEnabled = true;
        panel.SetActive(panelIsEnabled);
    }

    private void TurnOnAndOff()
    {
        panelIsEnabled ^= true;
        panel.SetActive(panelIsEnabled);
    }
}