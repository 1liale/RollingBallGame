using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Text display;
    public Text bonus;
    public Animator anim;

    private int score;

    public void AddScore(int value)
    {
        score += value;

        bonus.text = "+" + value;
        anim.Play("ScoreBonus");
        display.text = score.ToString();
    }
}
