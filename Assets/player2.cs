#region Includes
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
#endregion

namespace TS.GazeInteraction.player2
{
    public class player2 : MonoBehaviour
    {
        #region Variables

        [Header("Configuration")]
        [SerializeField] private float _speed;
        [SerializeField] private float _radius;

        private Vector3 _initialPosition;
        private Vector3 _targetPosition;

        private Animator anim;

        #endregion

        private void Start()
        {
            anim = GetComponent<Animator>();

            Reset();
        }
        private void Update()
        {
            
        }

        public void Enable()
        {
            enabled = true;
            anim.Play("Hip Hop Dancing",-1,0f);
        }
        public void Reset()
        {
            enabled = false;
}
}
}