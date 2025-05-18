using System.Globalization;
using UnityEngine;
using UnityEngine.UI; //allows use to access UI components
using UnityEngine.SceneManagement; //allows access to scene components

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;  //now can make a reference to text because we included the UI library
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]  //function to test function
    //public because it interacts with other scripts
    public void addScore(int scoreToAdd) //adds 1 to the player's score and update UI text
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString(); //add .ToString to translate the integer to a string
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true); //trigger when the bird crashes into a pipe
    }
}
