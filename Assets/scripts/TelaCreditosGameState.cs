using UnityEngine;

public class TelaCreditosGameState : GameBaseState
{
    private GameObject telaCreditosJogo;

    public override void enterState(GameStateManager gameState)
    {
        Debug.Log("Entramos na tela de cr�ditos.");
        gameState.mensagem.text = "tela cr�ditos.";
        // pega o game object com a tela de t�tulo, para poder ativar / desativar
        // a sua apari��o (via SpriteRenderer) ao entrar / sair estado.
        telaCreditosJogo = GameObject.Find("tela_creditos_Treasure_Hunter_1280_1060");

        // ativa o sprite render do gameObject da tela de t�tulo, exibindo-a na tela.
        telaCreditosJogo.GetComponent<SpriteRenderer>().enabled = true;

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
        // desativa o sprite render do gameObject da tela de t�tulo, escondendo-a.
        telaCreditosJogo.GetComponent<SpriteRenderer>().enabled = false;

    }
}
