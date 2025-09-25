using UnityEngine;
using UnityEngine.UI;

public class ChangingSlider : MonoBehaviour
{
   [SerializeField] Slider comboSlider;
   [SerializeField] Image sliderFill;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        FireComboColor();
    }
    public void FireComboColor()
    {
        sliderFill.color = Color.Lerp(Color.cyan, Color.red, comboSlider.value / 50);
    }
}
