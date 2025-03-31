using Lab3.DamageableObjects;
using Lab3.Projectiles;

namespace Lab3;

class Program
{
	static void Main()
	{
		IDamageable enemy = new Enemy(50);
		IDamageable armoredEnemy = new ArmoredEnemy(75, 25);
		IDamageable wall = new BreakableWall(25);

		Projectile bullet = new Bullet(30);
		Projectile rocket = new Rocket(50);

		Console.WriteLine("=== Bullet hits Enemy ===");
		bullet.HitTarget(enemy);

		Console.WriteLine("\n=== Rocket hits Armored Enemy ===");
		rocket.HitTarget(armoredEnemy);

		Console.WriteLine("\n=== Bullet hits Breakable Wall ===");
		bullet.HitTarget(wall);

		Console.WriteLine("\n=== Bullet hits Armored Enemy 3 times ===");
		for (var i = 0; i < 3; i++)
		{
			bullet.HitTarget(armoredEnemy);

			if (armoredEnemy.IsDead)
			{
				Console.WriteLine($"Armored enemy died after {i+1} hit.");
				break;
			}
		}

		Console.ReadLine();
	}
}