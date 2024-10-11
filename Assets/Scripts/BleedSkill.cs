using UnityEngine;

public class BleedSkill : Skill
{ 
    public override string skillName => "Bleed";

    public override void Activate()
    {
        Destroy(gameObject, lifeTime);
    }
}
