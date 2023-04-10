using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MacrofgCell : MonoBehaviour
{
    public new Rigidbody2D rigidbody;
    public float velocidadeMovimento;
    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float velocidadeX = (horizontal * this.velocidadeMovimento);
        float velocidadeY = (vertical * this.velocidadeMovimento);
        this.rigidbody.velocity = new Vector2(velocidadeX, velocidadeY);
        
    }
}


//a classe input pega a informação de qual direção o gameobject quer se mover, considerando os eixos cartesianos. O método getaxis faz exatamente isso: a unity verifica se o jogador
//está pressionando algum dos botões de movimento, atribuindo valores de 1 a -1. Resumindo, Input.GetAxis nos dá a informação pra onde o jogador quer se mover: direita, esquerda, pra cima ou pra baixo
//o componente rigidbody deixa o game object sujeito às leis da fisica, como a gravidade, aceleração, sujeito à forças ou velocidades.
//todo e qualquer componente contidos em um game object podem ser modificados por meio de scripts, basta criar uma variavel do tipo do componente
//rigidbody.velocity pega os valores da movimentação nas direções guardadas nas variaveis horizontal e vertical e transfere esses valores pro componente velocidade, com os mesmos valores de 1 a -1, o que é
//muito devagar, o que implica na multiplicação dos valores dessas variáveis





