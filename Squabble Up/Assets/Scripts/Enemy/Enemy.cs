using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform hitEffect;
    public int health;
    public int maxHealth = 100;
    public int damagePoints = 5;

    public void Start()
    {
        health = maxHealth;
    }

    public void PlayerDamage()
    {
        if (health > 0)
        {
            damagePoints -= health;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerDamage();
        }
    }
}
