using UnityEngine;

public class TelaCreditosGameState : GameBaseState
{
    public override void enterState(GameStateManager gameState)
    {
        Debug.Log("Entramos na tela de cr�ditos.");
        gameState.mensagem.text = "tela cr�ditos.";
    }

    public override void updateState(GameStateManager gameState)
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            // muda para o pr�ximo estado.
            gameState.switchState(gameState.introState);
        }

    }

    public override void leaveState(GameStateManager gameState)
    {
        Debug.Log("Saindo da tela de cr�ditos.");
    }
}
