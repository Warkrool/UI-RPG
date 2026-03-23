using UnityEngine;

public class player : character
{
    [SerializeField]
    private Weapon activeWeapon;
    public override void Attack(character EnemyToHit)
    {
        EnemyToHit.TakeDamage(activeWeapon);
        float damage = activeWeapon.GetDamage();
        EnemyToHit.TakeDamage(damage);
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
