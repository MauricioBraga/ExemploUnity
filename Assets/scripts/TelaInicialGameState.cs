using UnityEngine;

public class TelaInicialGameState : GameBaseState
{
    private GameObject telaInicialJogo;

    public override void enterState(GameStateManager gameState)
    {
        Debug.Log("Entramos na Tela inicial.");
        gameState.mensagem.text = "tela inicial.";

        // pega o game object com a tela de t�tulo, para poder ativar / desativar
        // a sua apari��o (via SpriteRenderer) ao entrar / sair estado.
        telaInicialJogo = GameObject.Find("Tela_treasure_hunter_1280_x_1060");

        // ativa o sprite render do gameObject da tela de t�tulo, exibindo-a na tela.
        telaInicialJogo.GetComponent<SpriteRenderer>().enabled = true;

    }

    public override void updateState(GameStateManager gameState)
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            // muda para o pr�ximo estado.
            gameState.switchState(gameState.telaCreditosState);
        }

    }

    public override void leaveState(GameStateManager gameState)
    {
        Debug.Log("Saindo da Tela inicial.");
        // desativa o sprite render do gameObject da tela de t�tulo, escondendo-a.
        telaInicialJogo.GetComponent<SpriteRenderer>().enabled = false;

    }
}
