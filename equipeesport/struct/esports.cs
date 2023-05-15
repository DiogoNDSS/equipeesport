namespace Struct;

public struct Esports{
    public string verificarjogo;
    public string verificarnomejogador;
    public string verificarcampeaoprincipal;
    public string registrarNumerosFirstBlood;
    public string registrarNumeroPentakill;
    public string verificarVinculoClube;
    public string verificartreinoconcluido;
    public string verificarvitoriacampeonato;
    public string verificarposicao;
    public float totalpremiacoes;
    public string anodeestreia;
    
    
    public Esports(string jogo, string nomejogador, string campeao, string firstblood, string pentakill, string vinculoclube, string treinoconcluido, string campeonato, string posicao, string anoestreia){
        this.verificarjogo = jogo;
        this.verificarnomejogador = nomejogador;
        this.verificarcampeaoprincipal = campeao;
        this.registrarNumerosFirstBlood = firstblood;
        this.registrarNumeroPentakill = pentakill;
        this.verificarVinculoClube = vinculoclube;
        this.verificartreinoconcluido = treinoconcluido;
        this.verificarvitoriacampeonato = campeonato;
        this.verificarposicao = posicao;
        this.totalpremiacoes = 0;
        this.anodeestreia = anoestreia;
    }
    public void valorcampeonato(float atualizarvalor) {
    this.totalpremiacoes = this.totalpremiacoes + atualizarvalor;
     }
    public string imprimir(){
        return "\nJogo: " + this. verificarjogo +
        "\nNome do jogador: " + this.verificarnomejogador +
        "\nCampeao Main: " + this.verificarcampeaoprincipal + 
        "\nFirstBloods: " + this.registrarNumerosFirstBlood +
        "\nPentakill: " + this.registrarNumeroPentakill +
        "\nClube: " + this.verificarVinculoClube +
        "\nTreinos Concluidos: " + this.verificartreinoconcluido +
        "\nVitorias em campeonatos: " + this.verificarvitoriacampeonato +
        "\nPosição: " + this.verificarposicao +
        "\nPremiações: " + this.totalpremiacoes +
        "\nEstreia: " + this.anodeestreia;
         
    }
}