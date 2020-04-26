using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int scoreIncrement)
    {
        score += scoreIncrement;
        text.text = "x" + score.ToString();
        text2.text = "x" + score.ToString();
    }
}

