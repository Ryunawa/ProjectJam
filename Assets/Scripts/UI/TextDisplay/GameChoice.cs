using UnityEngine;

[CreateAssetMenu(menuName = "Scriptableobjects/Choice", fileName = "Choice")]
public class GameChoice : GameText
{
    [SerializeField] private string _firstChoice;
    [SerializeField] private string _secondChoice;
    [SerializeField][Range(1, 2)] private int _validChoice;
    [SerializeField] private GameChoice _next;
    [SerializeField] private BonusPath.BonusPathValue _path;

    public string FirstChoice => _firstChoice;
    public string SecondChoice => _secondChoice;

    public void Choose(int choice) => BonusPathManager.Instance.Answered(_path, choice == _validChoice, _next);
}
