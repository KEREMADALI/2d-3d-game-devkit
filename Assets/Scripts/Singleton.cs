using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    #region Private & Const Variables

    private static T m_Instance;

    #endregion

    #region Public Variables

    public static T Instance => m_Instance;
    public static bool IsInitialized => (m_Instance != null);

    #endregion

    #region Public Methods

    #endregion

    #region Private Methods

    protected void Awake()
    {
        if (m_Instance == null)
        {
            m_Instance = (T)this;
        }
        else
        {
            Debug.LogError("Trying to instantiate a second instance for a Singleton class!");
        }
    }

    protected void OnDestroy()
    {
        if (m_Instance == this)
        {
            m_Instance = null;
        }
    }

    #endregion
}
