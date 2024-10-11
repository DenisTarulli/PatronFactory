using UnityEngine;

public abstract class Skill : MonoBehaviour
{
    [SerializeField] protected float lifeTime;
    public abstract string skillName { get; }
    public abstract void Activate();
}
