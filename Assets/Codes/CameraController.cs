using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ball
{
    public class CameraController : MonoBehaviour
    {
        private Vector3 _offset;
        public Player Player;

        private void Awake()
        {
            _offset = transform.position - Player.transform.position;
        }

        private void LateUpdate()
        {
            transform.position = Player.transform.position + _offset;
        }
    }
}

