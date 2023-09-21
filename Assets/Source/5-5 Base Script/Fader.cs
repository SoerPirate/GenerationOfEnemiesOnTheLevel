using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    [SerializeField] private Image _image;

    float _duration = 255f;

    private void Start()
    {
        StartFadeIn(_duration);

        // StopCoroutine(FadeIn());      - как работает? хз

        //StopCoroutine(fadeInJob);      - норм

        //StopAllCoroutines();           - стараться не использовать 
    }

    private void StartFadeIn(float duration)
    {
        Coroutine fadeInJob = StartCoroutine(FadeIn(duration)); // фасадный метод (при необходимости, вместо StopAllCoroutines). если такая корутина уже есть и работает, то останавливать ее и запускать новую 
    }

    private IEnumerator FadeIn(float duration)
    {
        var color = _image.color;

        var waitForOneSeconds = new WaitForSeconds(0.1f);      // через Х секунд  - правильная версия                                       !!!

        for (var i = 0; i < duration; i++)
        {
            color.a = 1f - (1f / duration * i);
            _image.color = color;

            yield return null; // это точка, в которой выполнение приостанавливается и возобновляется в следующем кадре.

            //yield return new WaitForEndOfFrame(); // в конце текущего фрейма после всех отрисовок  

            //yield return new WaitForSeconds(1); // через Х секунд   

            //yield return waitForOneSeconds; // через Х секунд  - правильная версия                                                        !!!

            //yield return new WaitForSecondsRealtime(1); // если игра будет на паузе - время все равно идет и корутина работает  

            //yield return new WaitUntil(); // predicate 

            //yield return new WaitWhile(); // predicate
        }
    }
}
