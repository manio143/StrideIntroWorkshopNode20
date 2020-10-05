# Lesson 8: Create a platform remover

Similarly to the spawner create a 'Remover' entity with a trigger rigidbody. But this time execute when collision begins and remove the entity you collided with from the scene.

    using System.Threading.Tasks;
    using Stride.Engine;
    using Stride.Physics;

    namespace DropBall
    {
        public class PlatformRemover: AsyncScript
        {    
            public override async Task Execute()
            {
                var physics = Entity.Get<RigidbodyComponent>();
                while(Game.IsRunning)
                {
                    var collision = await physics.NewCollision();
                    
                    var entity = collision.ColliderA == physics
                        ? collision.ColliderB.Entity
                        : collision.ColliderA.Entity;
                    
                    Entity.Scene.Entities.Remove(entity);
                }
            }
        }
    }

Both `NewCollision()` and `CollisionEnded()` return a collision object which has two colliders, two physics components of two entities. We check which collider is the removers rigidbody and pick the entity of the other one which is the platform. Then we remove it from the scene.

The remover can have the same size as the spawner and be positioned around (Y: 5.9).
