using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int coins = 0;
    public int keys = 0;

    public AudioSource audioCoinCollect;
    public AudioSource audioKeyCollect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coins += 1;
            Destroy(collision.gameObject);
            if (audioCoinCollect != null)
            {
                audioCoinCollect.Play();
            }
        }
        if (collision.gameObject.CompareTag("Key"))
        {
            keys += 1;
            Destroy(collision.gameObject);
            if (audioKeyCollect != null)
            {
                audioKeyCollect.Play();
            }
        }
        if (collision.gameObject.CompareTag("Door"))
        {
            if (keys > 0)
            {
                keys -= 1;
                Destroy(collision.gameObject);
                if (audioKeyCollect != null)
                {
                    audioKeyCollect.Play();
                }
            }
        }
    }

    public void AddKey(int amount)
    {
        keys += amount;
    }
}
