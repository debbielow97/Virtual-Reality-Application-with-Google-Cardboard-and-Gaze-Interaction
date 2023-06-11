#region Includes
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
#endregion

namespace TS.GazeInteraction.player3
{
    public class player3 : MonoBehaviour
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
            anim.Play("Dancing Maraschino Step",-1,0f);
        }
        public void Reset()
        {
            enabled = false;
            }
        }
}