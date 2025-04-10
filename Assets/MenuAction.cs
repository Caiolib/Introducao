using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void IniciaJogo() 
    {
        GameController.Init();
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
