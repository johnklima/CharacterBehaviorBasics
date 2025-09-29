using UnityEngine;

public class RockPaperScissors : MonoBehaviour
{
                //rock      //paper     //scissors
    //rock      0            1            2

    //paper     2            0            1

    //scissors  1            2            0



    int[,] resultTable = new int[3, 3];


    int ROCK = 0;
    int PAPER = 1;
    int SCISSORS = 2;

    string[] play = { "Rock", "Paper", "Scissors" };

    string[] result = { "Tie", "Loss", "Win" };

    public bool doit = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resultTable[ROCK, ROCK] = 0;   //is tie
        resultTable[ROCK, PAPER] = 1;   //is loss
        resultTable[ROCK, SCISSORS] = 2;    //is win

        resultTable[PAPER, ROCK] = 2;
        resultTable[PAPER, PAPER] = 0;
        resultTable[PAPER, SCISSORS] = 1;

        resultTable[SCISSORS, ROCK] = 1;
        resultTable[SCISSORS, PAPER] = 2;
        resultTable[SCISSORS, SCISSORS] = 0;


    }

    // Update is called once per frame
    void Update()
    {


        if(doit)
        {
            doit = false;

            int me = Random.Range(0, 3);
            int him = Random.Range(0, 3);

            int r = resultTable[me, him];

            Debug.Log("I played " + play[me] + " he played " + play[him]);
            Debug.Log("I " + result[r]);


        }

    }
}
