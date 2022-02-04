using Cysharp.Threading.Tasks;

namespace BattleSystem.Explosions.Steps.Abstractions
{
    public interface IStep
    {
        UniTask Execute();
    }
}