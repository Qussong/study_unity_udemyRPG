using UnityEngine;

public class Cooldown_Example : MonoBehaviour
{
    private SpriteRenderer sr;

    [SerializeField] private float redColorDuration = 0.5f;

    public float currentTimeInGame;     // 게임 플레이 시간
    public float lastTimeWasDamaged;    // 마지막으로 데미지를 받은 시간

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        currentTimeInGame = Time.time;

        if (currentTimeInGame > lastTimeWasDamaged + redColorDuration)
        {
            if (sr.color != Color.white)
                sr.color = Color.white;
        }
    }

    public void TakeDamage()
    {
        sr.color = Color.red;
        lastTimeWasDamaged = Time.time;
    }

}
