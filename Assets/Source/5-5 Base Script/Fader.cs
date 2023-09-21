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

        // StopCoroutine(FadeIn());      - ��� ��������? ��

        //StopCoroutine(fadeInJob);      - ����

        //StopAllCoroutines();           - ��������� �� ������������ 
    }

    private void StartFadeIn(float duration)
    {
        Coroutine fadeInJob = StartCoroutine(FadeIn(duration)); // �������� ����� (��� �������������, ������ StopAllCoroutines). ���� ����� �������� ��� ���� � ��������, �� ������������� �� � ��������� ����� 
    }

    private IEnumerator FadeIn(float duration)
    {
        var color = _image.color;

        var waitForOneSeconds = new WaitForSeconds(0.1f);      // ����� � ������  - ���������� ������                                       !!!

        for (var i = 0; i < duration; i++)
        {
            color.a = 1f - (1f / duration * i);
            _image.color = color;

            yield return null; // ��� �����, � ������� ���������� ������������������ � �������������� � ��������� �����.

            //yield return new WaitForEndOfFrame(); // � ����� �������� ������ ����� ���� ���������  

            //yield return new WaitForSeconds(1); // ����� � ������   

            //yield return waitForOneSeconds; // ����� � ������  - ���������� ������                                                        !!!

            //yield return new WaitForSecondsRealtime(1); // ���� ���� ����� �� ����� - ����� ��� ����� ���� � �������� ��������  

            //yield return new WaitUntil(); // predicate 

            //yield return new WaitWhile(); // predicate
        }
    }
}
