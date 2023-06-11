#region Includes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#endregion

namespace TS.GazeInteraction.Movement
{
    public class Movement : MonoBehaviour
    {
        #region Variables
        [Header("Configuration")]
        [SerializeField] private float _speed;
        [SerializeField] private float _radius;

        private Vector3 _initialPosition;
        private Vector3 _targetPosition;

        private Animator anim;

        #endregion
        // Start is called before the first frame update
        private void Start()
        {
            anim = GetComponent<Animator>();

            Reset();
        }

        // Update is called once per frame
        private void Update()
        {

        }

        public void Enable()
        {
            enabled = true;
            anim.Play("Excited", -1, 0f);
        }

        public void Reset()
        {
            enabled = false;
        }
    }
}
