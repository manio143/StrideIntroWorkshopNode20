using System;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Engine;
using Stride.Physics;

namespace DropBall
{
    public class PlatformSpawner : AsyncScript
    {
        public Prefab PlatformPrefab { get; set; }
        
        public float PlatformDistance { get; set; } = 2;
    
        public override async Task Execute()
        {
            var physics = Entity.Get<RigidbodyComponent>();
            while(Game.IsRunning)
            {
                await physics.CollisionEnded();
                
                var entity = PlatformPrefab.Instantiate()[0];
                RandomPlatform(out var length, out var position);
                entity.Transform.Position = new Vector3(0, -PlatformDistance, position);
                entity.Transform.Scale.Z = length;
                
                Entity.Scene.Entities.Add(entity);
            }
        }
        
        private readonly Random rnd = new Random();
        private void RandomPlatform(out float length, out float position)
        {
            length = (float)(rnd.NextDouble() * 2 + 1.5); // between 1.5 and 3.5
            position = (float)(rnd.NextDouble() * 10 - 5); // between -5 and 5
        }
    }
}
