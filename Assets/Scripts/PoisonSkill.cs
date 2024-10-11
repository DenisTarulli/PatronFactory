using UnityEngine;

public class PoisonSkill : Skill
{
    public override string skillName => "Poison";

    public override void Activate()
    {
        Destroy(gameObject, lifeTime);
    }
}
