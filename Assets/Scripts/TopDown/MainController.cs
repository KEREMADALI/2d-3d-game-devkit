using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    #region Private & Const Variables

    #endregion

    #region Public Variables

    #endregion

    #region Public Methods

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Explosion.CreateExplosion(transform.position, 50, 5);
        }
    }

    #endregion

    #region Private Methods

    #endregion
}
