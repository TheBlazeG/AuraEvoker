using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Farmer : MonoBehaviour
{
    [SerializeField] Sprite[] poses;
    [SerializeField] Image farmer;
    private int aura;
    private int fame;
    private int auraCapacity=1;
    TextMeshProUGUI auraCounter;
    TextMeshProUGUI fameMeter;
    float comboMeter = 0;
    float comboGrace = 0;

    public void Farm(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
        int index = Random.Range(0, poses.Length);
        Debug.Log(index);
        Sprite nextSprite = poses[index];
        farmer.sprite = nextSprite == farmer.sprite && nextSprite== poses[poses.Length-1] ? poses[Random.Range(0,poses.Length-1)] :nextSprite ;
            comboMeter+= comboMeter>=40? .2f:1;
            comboGrace = 3;
        aura += auraCapacity*(int)(1+comboMeter);
        }
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (comboGrace>0)
        {
            comboGrace -= 1 * Time.fixedDeltaTime;
        }
        if (comboGrace==0&& comboMeter!=0)
        {
            comboMeter = 0;
        }
    }

}
