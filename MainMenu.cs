using System.ComponentModel.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    int daljiLevel = 1;
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void DrugiLvl()
    {
        if(daljiLevel == 2)
        SceneManager.LoadSceneAsync(2);
    }
    public void TreciLvl()
    {
        if (daljiLevel == 3)
            SceneManager.LoadSceneAsync(3);
    }
    public void CetvrtiLvl()
    {
        if (daljiLevel == 4)
            SceneManager.LoadSceneAsync(4);
    }
    public void PetiLvl()
    {
        if (daljiLevel == 5)
            SceneManager.LoadSceneAsync(5);
    }
    public void SestiLvl()
    {
        if (daljiLevel == 6)
            SceneManager.LoadSceneAsync(6);
    }
        public void SedmiLvl()
    {
        if (daljiLevel == 7)
            SceneManager.LoadSceneAsync(7);
    }
    public void OsmiLvl()
    {
        if (daljiLevel == 8)
            SceneManager.LoadSceneAsync(8);
    }
    public void DevetiLvl()
    {
        if (daljiLevel == 9)
            SceneManager.LoadSceneAsync(9);
    }
    public void DesetiLvl()
    {
        if (daljiLevel == 10)
            SceneManager.LoadSceneAsync(10);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}

    
