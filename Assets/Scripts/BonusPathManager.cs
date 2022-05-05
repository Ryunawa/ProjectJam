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

    [SerializeField]
    private BonusGetter[] _bonusGetters;

    private void Setup()
    {
        _pathProgress = new Dictionary<BonusPath.BonusPathValue, bool>
        {
            { BonusPath.BonusPathValue.Snowflake, false },
            { BonusPath.BonusPathValue.Sword, false },
            { BonusPath.BonusPathValue.Boots, false },
            { BonusPath.BonusPathValue.Chococoin, false }
        };
    }

    public bool CanUse(BonusPath.BonusPathValue value) => _pathProgress[value];
    
    #region BonusPaths
    
    private Dictionary<BonusPath.BonusPathValue, bool> _pathProgress;

    public void Answered(GameText next)
    {
        GameManager.Instance.AddGameText(next);
    }
    
    public void Answered(BonusPath.BonusPathValue path, bool goodEnd)
    {
        Debug.Log($"[{path.ToString()}] End dialogue: good end? ({goodEnd})");
        _pathProgress[path] = goodEnd;

        if (goodEnd)
            GetBonus((int)path);
        else
            GameManager.Instance.Respawn();
        
        GameManager.Instance.NextText();
    }

    private void GetBonus(int path)
    {
        GameManager.Instance.Light(path);
        _bonusGetters[path].gameObject.SetActive(false);
    }

    #endregion
}
