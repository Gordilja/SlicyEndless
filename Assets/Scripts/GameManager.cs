using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public bool canGenerateFruit;
    public float waitTime = 0.1f;
    public GameObject[] fruits;

    public GameObject StartPanel;
    public GameObject GameOverPanel;

    private void Awake()
    {
        StartPanel.SetActive(true);
        Time.timeScale = 0;
    }

    void Start()
    {
        canGenerateFruit = true;
        gameManager = this;
    }

    private void Update()
    {
       RenderSettings.fogColor = Camera.main.backgroundColor;
    }
    public void quit()
    {
        Application.Quit();
    }

    public void play()
    {
        Time.timeScale = 1;
        StartPanel.SetActive(false);
        GameOverPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            gameOver();
        }
    }

    public void retry() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void gameOver()
    {
        StartCoroutine(waitAnim());
    }

    IEnumerator waitAnim()
    {
        yield return new WaitForSeconds(waitTime);
        canGenerateFruit = false;
        GameOverPanel.SetActive(true);
    }
   
}


    
