using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Complete;

public class InputManager : MonoBehaviour
{
    public Complete.GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetPlayerMovementInput(int playerID, float verticalAxis)
    {
        if (gameManager.m_Tanks.Length >= playerID && gameManager.m_Tanks[playerID] != null)
            gameManager.m_Tanks[playerID].m_Movement.m_MovementInputValue = verticalAxis;
    }

    public void SetPlayerTurnInput(int playerID, float horizontalAxis)
    {
        if (gameManager.m_Tanks.Length >= playerID && gameManager.m_Tanks[playerID] != null)
            gameManager.m_Tanks[playerID].m_Movement.m_TurnInputValue = horizontalAxis;
    }

    public void SetPlayerShootingPressed(int playerID, bool shooting)
    {
        if (gameManager.m_Tanks.Length >= playerID && gameManager.m_Tanks[playerID] != null)
            gameManager.m_Tanks[playerID].m_Shooting.m_ShootPressed = shooting;
    }

    public void SetPlayerShootingReleased(int playerID, bool shooting)
    {
        if (gameManager.m_Tanks.Length >= playerID && gameManager.m_Tanks[playerID] != null)
            gameManager.m_Tanks[playerID].m_Shooting.m_ShootReleased = shooting;
    }

    public void SetPlayerShootCharging(int playerID, bool charging)
    {
        if (gameManager.m_Tanks.Length >= playerID && gameManager.m_Tanks[playerID] != null)
            gameManager.m_Tanks[playerID].m_Shooting.m_ShootCharging = charging;
    }
}
