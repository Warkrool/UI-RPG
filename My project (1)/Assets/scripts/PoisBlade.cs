using UnityEngine;

public class PoisBlade : Blade
{
    [SerializeField]
    float poisDamage;
    [SerializeField]
    int poisCount;

    public override float GetDamage()
    {
        float baseDamagae = base.GetDamage();
        if(poisCount > 0)
        {
            poisCount--;
            return baseDamagae + poisDamage;
        }
        return baseDamagae;
        }
    }

