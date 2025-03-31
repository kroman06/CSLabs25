namespace Lab3.Projectiles;

public class Rocket(int damage) : Projectile(damage)
{
	private static readonly Random Rnd = new();

	public override void HitTarget(IDamageable target)
	{
		int spread = Rnd.Next(-5, 6);
		int totalDamage = Damage + spread;
		target.TakeDamage(totalDamage);
		Console.WriteLine($"Rocket dealt {totalDamage} damage.");
	}
}