using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    public void CategoryButton()
    {
        SceneManager.LoadScene("Scenes/Categories");
    }

    public void ScienceButton()
    {
        SceneManager.LoadScene("Scenes/Science");
    }

    public void ArtButton()
    {
        SceneManager.LoadScene("Scenes/Art");
    }

    public void SportsButton()
    {
        SceneManager.LoadScene("Scenes/Sports");
    }

    public void HistoryButton()
    {
        SceneManager.LoadScene("Scenes/History");
    }

    public void GeographyButton()
    {
        SceneManager.LoadScene("Scenes/Geography");
    }

    public void EntertainmentButton()
    {
        SceneManager.LoadScene("Scenes/Entertainment");
    }

    public void PotatoButton()
    {
        SceneManager.LoadScene("Scenes/Potatoes");
    }
}
