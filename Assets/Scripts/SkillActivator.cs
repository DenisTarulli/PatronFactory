using UnityEngine;

public class SkillActivator : MonoBehaviour
{
    [SerializeField] private SkillFactory _skillFactory;
    [SerializeField] private Transform player;

    public void ActivateSkill(string skillName)
    {
        Skill skillToActivate = _skillFactory.CreateSkill(skillName, player);
        skillToActivate.Activate();
    }
}
