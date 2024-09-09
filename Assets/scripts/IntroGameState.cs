using UnityEngine;

public class IntroGameState : GameBaseState
{
    public override void enterState(GameStateManager gameState)
    {
        Debug.Log("Entramos no modo intro.");
        gameState.mensagem.text = "modo intro.";
    }

    public override void updateState(GameStateManager gameState)
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            // muda para o próximo estado.
            gameState.switchState(gameState.telaInicialState);
        }

    }

    public override void leaveState(GameStateManager gameState)
    {
        Debug.Log("Saindo do modo intro.");
    }
}


