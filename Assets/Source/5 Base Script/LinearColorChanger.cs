using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearColorChanger : MonoBehaviour
{
    //[HideInInspector] public SpriteRenderer Target;

    [SerializeField] private float _duration;

    [SerializeField] private Color _targetColor;
    //[SerializeField] private Color _targetColor = new Color(255, 0, 0);   - плохая идея задавать значение полю SerializeField. сперва поле в инспекторе заполнится этими значениями,
                                                                            //а потом оно наоброт уже оттуда будет сюда попадать каждый раз, вместо того чтобы новые значения брать 

    private Color _startTargetColor;

    private SpriteRenderer Target;

    private float _runnigTime;

    private void Start()
    {
        Target = GetComponent<SpriteRenderer>();
        
        _startTargetColor = Target.color;
    }

    private void Update()
    {
        if (_runnigTime <= _duration)
        {
            _runnigTime += Time.deltaTime;

            float normalizeRunningTime = _runnigTime / _duration;

            //Color newColor = new Color(_targetColor.r * normalizeRunningTime, _targetColor.g * normalizeRunningTime, _targetColor.b * normalizeRunningTime);

            //Target.color = newColor;

            Target.color = Color.Lerp(_startTargetColor, _targetColor, normalizeRunningTime);
        }
    }
}
