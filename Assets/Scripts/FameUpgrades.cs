using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FameUpgrades : MonoBehaviour
{
    [SerializeField] Farmer player;
    public int fameCost = 600;
    [SerializeField] Button upgradeButton;
    [SerializeField] TextMeshProUGUI costText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        costText.text = fameCost.ToString();
    }
    public void upgradeFame()
    {
        if(player.publicFame>fameCost)
        player.upgradeFame(100);
        fameCost *= 3;
        costText.text = fameCost.ToString();
    }
    private void Update()
    {
        
        if (player.publicFame > fameCost)
        {
            upgradeButton.enabled = true;
        }
        else {
        upgradeButton.enabled=false;
        }
    }
}
