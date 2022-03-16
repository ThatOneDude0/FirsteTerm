using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SliderColor : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Image slider1Fill;
    void Start()
    {
        slider = GetComponent<Slider>();

        StartCoroutine(SliderAdd());
    }

    IEnumerator SliderAdd()
    {
        float timer = 0;
        float value = 1;

        while (timer <= value)
        {
            if (slider.value == 0)
            {
                slider1Fill.color = Color.red;
            } 
            
            timer += 0.02f;

            slider1Fill.color = Color.Lerp(Color.red, Color.green, slider.value);

            yield return new WaitForSeconds(0.2f);
        }
    }
}
