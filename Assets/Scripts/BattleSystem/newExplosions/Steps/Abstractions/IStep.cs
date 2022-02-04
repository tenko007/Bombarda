using Cysharp.Threading.Tasks;

namespace BattleSystem.newExplosions
{
    public interface IStep
    {
        //Transform ParentTransform { get; protected set; }
        //public void SetParentTransform(Transform transform) => ParentTransform = transform; 
        UniTask Execute();
    }
}