using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    public float movSpeed;
    float movSpeedX, movSpeedY;
    Rigidbody2D body;
    public int playerHealth = 100;
    public int coinNum = 0;
    public bool key;
    [SerializeField] GameObject Trap;
    [SerializeField] GameObject Guy;
    [SerializeField] GameObject Door;
    [SerializeField] TextMeshProUGUI YLTMP;
    [SerializeField] TextMeshProUGUI HealthTMP;
    [SerializeField] TextMeshProUGUI KeyTMP;
    [SerializeField] TextMeshProUGUI CoinTMP;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movSpeedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        movSpeedY = Input.GetAxisRaw("Vertical") * movSpeed;
        body.velocity = new Vector2(movSpeedX, movSpeedY);
        HealthTMP.text = string.Format("HP:" + playerHealth + "/100");
        CoinTMP.text = string.Format("Coins:" + coinNum);
        if (playerHealth <= 0)
        {
            YLTMP.gameObject.SetActive(true);
            Guy.SetActive(false);
        }
    }

    public void RemoveHealth(int damage)
    {
        playerHealth -= damage;
    }
    public void GetKey(bool hasKey)
    {
        key = hasKey;
        KeyTMP.gameObject.SetActive(true);
    }
    public void CheckDoor()
    {
        if (key == true)
        {
            Door.SetActive(false);
            key = false;
            KeyTMP.gameObject.SetActive(false);
        }
    }
    public void CoinCollect(int coinCollected)
    {
        coinNum += coinCollected;
    }
}
