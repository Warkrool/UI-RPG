using UnityEngine;

public abstract class character : MonoBehaviour
{
    public float health;
    [SerializeField]
    private string charName;

    public string CharName
    {
        get { return charName; }

    }
    public abstract void Attack(character toHit);
    public void TakeDamage(float damage)
    {
        health = health - damage;
        Debug.Log(charName + "took" + damage + "damage! Health: " + health);
    }

    public void TakeDamage(Weapon ThrowWeapon)
    {
        float damage = ThrowWeapon.GetDamage();
        health = health - ThrowWeapon.GetDamage();
            Debug.Log(charName + "took" + damage + "damage! Health: " + health);
    }

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
