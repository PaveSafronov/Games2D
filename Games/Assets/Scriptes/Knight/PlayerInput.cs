using UnityEngine;

namespace Play.Inputs
{ [RequireComponent(typeof(PlayerMovie))]

    public class PlayerInput : MonoBehaviour
    {

        private PlayerMovie playerMovie;

        private void Awake()
        {
            playerMovie = GetComponent<PlayerMovie>();
        }

        private void Update()
        {

         float horizontal = Input.GetAxisRaw(GlobalStringVaribles.HORIZONTAL_AXIS);

            bool jumping = Input.GetButtonDown(GlobalStringVaribles.JUMP_AXIS);



            playerMovie.Movie(horizontal, jumping);
        }

    }


}
