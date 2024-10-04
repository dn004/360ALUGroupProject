using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI;               

public class InteractWithButtons : MonoBehaviour
{
    
    public GameObject instructionsPanel; 
    
    public void StartTour()
    {
        
        SceneManager.LoadScene("ALU360");
    }

    public void EndTour()
    {

        SceneManager.LoadScene("OutroScene");
    }

    public void ShowInstructions()
    {
        if (instructionsPanel != null)
        {
            instructionsPanel.SetActive(true);  
        }
    }

    public void CloseInstructions()
    {
        if (instructionsPanel != null)
        {
            instructionsPanel.SetActive(false);  
        }
    }

    
    public void ExitApplication()
    {
        
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();  
#endif
    }
}
