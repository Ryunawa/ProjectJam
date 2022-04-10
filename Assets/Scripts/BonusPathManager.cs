using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPathManager : MonoBehaviour
{
    #region Singleton

    private static BonusPathManager _instance;
        
    public static BonusPathManager Instance => _instance;

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            _instance.Setup();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #endregion

    private void Setup()
    {
        _pathProgress = new Dictionary<BonusPath.BonusPathValue, int>
        {
            { BonusPath.BonusPathValue.Snowflake, 0 },
            { BonusPath.BonusPathValue.Sword, 0 },
            { BonusPath.BonusPathValue.Boots, 0 },
            { BonusPath.BonusPathValue.Chococoin, 0 }
        };
    }

    public bool CanUse(BonusPath.BonusPathValue value) => _pathProgress[value] >= 2;
    
    #region BonusPaths

    [SerializeField] private List<GameDialog> _failedAnswer;
    
    [SerializeField] private int _pathLength;
    private Dictionary<BonusPath.BonusPathValue, int> _pathProgress;

    public void Answered(BonusPath.BonusPathValue path, bool answeredCorrectly, GameChoice next)
    {
        if (answeredCorrectly)
        {
            _pathProgress[path]++;

            if (_pathProgress[path] < _pathLength)
                GameManager.Instance.AddGameChoice(next);
            else if(_pathProgress[path] == _pathLength)
            {
                GameManager.Instance.NextText();
                GameManager.Instance.Light((int)path);
            }
        }
        else
        {
            _pathProgress[path] = 0;
            
            GameManager.Instance.Respawn();
            GameManager.Instance.AddGameDialog(_failedAnswer[(int)path]);
        }
    }

    #endregion
}
