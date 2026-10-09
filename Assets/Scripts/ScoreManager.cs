using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int Score = 0;
    [SerializeField]
    private TMP_Text score_Text;
    private void Start()
    {
        ChangeScore(Score);
    }
    private void OnEnable()
    {
        Target.TargetClicked += OnTargetClicked;
    }
    private void OnDisable()
    {
        Target.TargetClicked -= OnTargetClicked;  
    }

    void OnTargetClicked()
    {
        Score++;
        ChangeScore(Score);
    }

    void ChangeScore(int score)
    {
        score_Text.text = score.ToString();
    }
}
