using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : GameClient
{
    public override void Arsenal()
    {
        // triển khai logic của arsenal
    }

    public override void EndGame()
    {
        // triển  khailogic kết  thúc game
    }

    public override void StartGame()
    {
        // Triển khai logic bắt đầu trò chơi
        Debug.Log("startgame");
    }
    public override void Profile()
    {
        // triển khai logic về profile
    }
}
