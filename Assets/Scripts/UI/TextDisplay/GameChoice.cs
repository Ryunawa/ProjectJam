using UnityEngine;

[CreateAssetMenu(menuName = "Scriptableobjects/Choice", fileName = "Choice")]
public class GameChoice : GameText
{
    [SerializeField][TextArea] private string _firstChoice;
    [SerializeField][TextArea] private string _secondChoice;
    [SerializeField] private GameText[] _next;

    public string FirstChoice => _firstChoice;
    public string SecondChoice => _secondChoice;

    public void Choose(int choice) => BonusPathManager.Instance.Answered(_next[choice]);
}
