using UnityEngine;

public class CharacterMovementController : Movement
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
        movement = CustomInput.Get_WASD();

        UpdateAnimation();
    }

    #endregion
}
