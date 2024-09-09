using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStateManager : MonoBehaviour
{
    public Text mensagem;

    GameBaseState currentState;
    // instancias de cada um dos estados do jogo
    public TelaInicialGameState telaInicialState = new TelaInicialGameState();
    public TelaCreditosGameState telaCreditosState = new TelaCreditosGameState();
    public IntroGameState introState = new IntroGameState();



    void Start()
    {
        // seta o estado inicial
        currentState = telaInicialState;
        // inicia o estado.
        currentState.enterState(this);

    }

    // Update is called once per frame
    void Update()
    {
        currentState.updateState(this);

    }
    public void switchState(GameBaseState state)
    {
        // sai do estado anterior
        currentState.leaveState(this);

        // muda o estado atual
        currentState = state;

        // entra no novo estado
        currentState.enterState(this);
    }

}
