using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgressUI : MonoBehaviour
{
    [SerializeField] private Image uiFillImage;
    [SerializeField] private float reduceSpeed = 2;
    private float target = 0;

    // Update is called once per frame
    public void UpdateProgressFill(float max, float current)
    {
        target = current / max;
    }

    private void Update()
    {
        uiFillImage.fillAmount = Mathf.MoveTowards(uiFillImage.fillAmount, target, reduceSpeed * Time.deltaTime);
    }
}
