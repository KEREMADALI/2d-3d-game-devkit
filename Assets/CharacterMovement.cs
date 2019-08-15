using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : Movement
{
    #region Private & Const Variables

    #endregion

    #region Public Variables

    #endregion

    #region Public Methods

    #endregion

    #region Private Methods
    private void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        UpdateAnimation();
    }

    #endregion
}
