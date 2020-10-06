using System.Threading.Tasks;
using Stride.UI;
using Stride.Engine;
using Stride.Engine.Events;

namespace DropBall
{
    public class GameOverUI : AsyncScript
    {
        public UIPage UIPage;

        public override async Task Execute()
        {
            var receiver = new EventReceiver(SphereKiller.GameOver);
            await receiver.ReceiveAsync();
            
            var ui = Entity.GetOrCreate<UIComponent>();
            ui.Page = UIPage;
        }
    }
}
