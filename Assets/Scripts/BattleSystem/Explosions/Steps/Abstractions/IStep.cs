using Cysharp.Threading.Tasks;

namespace BattleSystem.newExplosions
{
    public interface IStep
    {
        UniTask Execute();
    }
}