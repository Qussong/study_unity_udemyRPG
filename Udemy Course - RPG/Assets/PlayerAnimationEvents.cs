using Unity.VisualScripting;
using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour
{
    private Player player;

    private void Awake()
    {
        player = GetComponentInParent<Player>();
    }

    public void DamageEnemies() => player.DamageEnemies();

    public void DisableMovementAndJump()
    {
        player.EnableMovementAndJump(false);
    }

    public void EnableMovementAndJump() => player.EnableMovementAndJump(true);  // 람다식 표현

}
