using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private player Player;
    [SerializeField] private enemy Enemy;
    [SerializeField] private TMP_Text playerName, playerHP, enemyName, enemyHP;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        playerName.text = Player.CharName;
        enemyName.text = Enemy.CharName;
        playerHP.text = "HP: " + Player.health.ToString("F1");
        enemyHP.text = "HP: " + Enemy.health.ToString("F1");
    }
    public void PlayerAttack()
    {
        Player.Attack(Enemy);
        Enemy.Attack(Player);
        UpdateUI();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
