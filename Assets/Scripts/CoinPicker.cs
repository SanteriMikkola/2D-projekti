
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    public int coin;
    public TextMeshProUGUI textCoins;
    private CoinPicker gm;

    private void Start()
    {
        gm = GetComponent<CoinPicker>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Coin"))
        {
            gm.coin += 1;
            textCoins.text = coin.ToString();

            Destroy(other.gameObject);
        }
    }
}
