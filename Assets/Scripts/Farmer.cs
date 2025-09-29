using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Farmer : MonoBehaviour
{
    [SerializeField] Sprite[] poses;
    [SerializeField] Image farmer;
    [SerializeField] TextMeshProUGUI auraScouter;
    [SerializeField]Slider comboCounter;
    [SerializeField]TextMeshProUGUI fameCounter;
    private int aura;
    private int fame;
    public int publicFame {  get { return fame; } }
    private int auraCapacity=1;
    float comboMeter = 0;
    

    public void Farm(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
        int index = Random.Range(0, poses.Length);
        Debug.Log(index);
        Sprite nextSprite = poses[index];
            if (farmer.sprite = nextSprite)
            {
        farmer.sprite =  nextSprite== poses[poses.Length-1] ? poses[Random.Range(0,poses.Length-1)] : poses[Random.Range(0, poses.Length)] ;
            }
            else
            {
                farmer.sprite = nextSprite;
            }
        aura += auraCapacity*(1+ (int)(comboMeter/10)+(fame/100));
            auraScouter.text= aura.ToString();

            comboMeter+= comboMeter>=40? .1f:.3f;
            comboCounter.value = comboMeter;
        }
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (comboMeter>0)
        {
            comboMeter-= 1 * Time.fixedDeltaTime;
        }
        comboCounter.value = comboMeter;
        //slider1Fill.color = Color.Lerp(Color.red, Color.green, slider1.value / 100);
    }

   public void upgradeFame(int fameToGet)
    {
        fame += fameToGet;
        fameCounter.text= fame.ToString();
    }

}
