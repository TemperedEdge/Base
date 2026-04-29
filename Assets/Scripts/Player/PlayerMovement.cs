using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Player;

namespace Player {
    public class PlayerMovement : MonoBehaviour
    {
        PlayerInput playerInput;
        InputAction moveAction;

        [SerializeField] float speed = 5;

        private void Start()
        {
            playerInput = GetComponent<PlayerInput>();
            moveAction = playerInput.actions.FindAction("Move");
        }

        private void Update()
        {
            MovePlayer();
        }

        private void MovePlayer()
        {
            Vector2 direction = moveAction.ReadValue<Vector2>();
            transform.position += new Vector3(direction.x, 0, direction.y) * speed * Time.deltaTime;
        }

    }
}
