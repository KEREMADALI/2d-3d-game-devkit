using UnityEngine;

public class CustomInput : Input 
{
    #region Private & Const Variables
    #endregion

    #region Public Variables

    #endregion

    #region Public Methods
    /// <summary>
    /// Listens W, A, S, D keys and returns in Vector2 form 
    /// </summary>
    /// <returns></returns>
    public static Vector2 Get_WASD()
    {
        Vector2 input = new Vector2();

        if (GetKey(KeyCode.A))
        {
            input.x = -1;
        }

        if (GetKey(KeyCode.D))
        {
            input.x = 1;
        }

        if (GetKey(KeyCode.W))
        {
            input.y = 1;
        }

        if (GetKey(KeyCode.S))
        {
            input.y = -1;
        }

        return input;
    }

    /// <summary>
    /// Listens arrow keys and returns in Vector2 form 
    /// </summary>
    /// <returns></returns>
    public static Vector2 Get_Arrows()
    {
        Vector2 input = new Vector2();

        if (GetKey(KeyCode.LeftArrow))
        {
            input.x = -1;
        }

        if (GetKey(KeyCode.RightArrow))
        {
            input.x = 1;
        }

        if (GetKey(KeyCode.UpArrow))
        {
            input.y = 1;
        }

        if (GetKey(KeyCode.UpArrow))
        {
            input.y = -1;
        }

        return input;
    }
    #endregion

    #region Private Methods

    #endregion
}
