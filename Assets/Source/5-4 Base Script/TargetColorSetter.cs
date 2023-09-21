using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Game01;

namespace Game01
{
    public class TargetColorSetter : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _renderer;

        [SerializeField] private Color _targetColor;

        public void SetColor()
        {
            _renderer.color = _targetColor;
        }
    }
}
