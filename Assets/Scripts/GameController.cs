using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
  public GameObject gameOverPanel;
  public GameObject tapTostart;
  private void Start()
  {
    gameOverPanel.SetActive(false);
    tapTostart.SetActive(true);
    PauseGame();
  }
  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Mouse0))
    {
      StartGame();
    }
  }
  public void GameOver()
  { 
    gameOverPanel.SetActive(true);
  }
  public void Restart()
  {
    SceneManager.LoadScene("Game");
  }
  public void QuitGmae()
  {
    Application.Quit();
  }
  public void PauseGame()
  {
    Time.timeScale = 0f;
  }
  public void StartGame()
  {
    tapTostart.SetActive(false);
    Time.timeScale = 1f;
   
  }
}
