using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUserAction
{
    //监听用户点击
    void clickOne();
    //监听用户输入空格（发射飞盘）
    void spacePress();
}


public interface ISceneController
{
    void LoadResources();
}

public interface GameStatus
{
    void Restart();
    void Hit(Vector3 pos);
    void GameOver();
    int GetScore();
    void BeginGame();
}


public class SSDirector : System.Object
{
    private static SSDirector _instance;
    private FirstSceneController currentSceneController;
    private GameStatus gameStatus;

    public static SSDirector getInstance()
    {
        if (_instance == null)
        {
            _instance = new SSDirector();
        }
        return _instance;
    }

    public FirstSceneController getCurrentSceneController()
    {
        return currentSceneController;
    }

    public void setCurrentSceneController(FirstSceneController currentSceneController)
    {
        if (this.currentSceneController == null)
        {
            this.currentSceneController = currentSceneController;
        }
    }

    public void setGameStatus(GameStatus gamestatus)
    {
        gameStatus = gamestatus;
    }

    public GameStatus getGameStatus()
    {
        return gameStatus;
    }
}
