using UnityEngine;

public class GameOver : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreText;
    public int score;

    private void Start()
    {
        scoreText.text = score.ToString();
    }

}
