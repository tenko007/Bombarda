using Cysharp.Threading.Tasks;

namespace BattleSystem.newExplosions
{
    public interface IExplosion
    {
        UniTask Explode();
    }
}