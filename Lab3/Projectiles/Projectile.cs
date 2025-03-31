namespace Lab3;

public abstract class Projectile(int damage)
{
	protected readonly int Damage = damage;

	public abstract void HitTarget(IDamageable target);
}