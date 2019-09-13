using UnityEngine;
namespace Core.InputSystem
{
    public class InputSystem 
    {
        ///<summary>
        /// Returns the current axis direction.
        ///</summary>
        public static Vector2 Axis
        {
            get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }
}