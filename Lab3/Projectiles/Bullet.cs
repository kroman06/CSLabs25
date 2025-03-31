namespace Lab3;

public class Bullet(int damage) : Projectile(damage)
{
	private static readonly Random Rnd = new();
	
	public override void HitTarget(IDamageable target)
	{
		int spread = Rnd.Next(-2, 3);
		int totalDamage = Damage + spread;
		
		target.TakeDamage(totalDamage);
		Console.WriteLine($"Bullet dealt {totalDamage} damage.");
	}
}