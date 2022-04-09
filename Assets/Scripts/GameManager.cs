using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    #region Singleton

    private static GameManager _instance;
        
        public static GameManager Instance => _instance;
    
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
            throw new NotImplementedException();
        }
    
}
