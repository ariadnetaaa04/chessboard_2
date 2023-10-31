using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //References
    public GameObject chesspiece;
    public GameObject movePlate;
    public GameObject controller;

    //Positions
    private int xBoard = -1;
    private int yBoard = -1;

    //Player
    private string player;

    public Sprite black_queen;

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");


        SetCoords();

        switch (this.name)
        {
            case "black_queen": this.GetComponent<SpriteRenderer>().sprite = black_queen; break
        }
    }

    public void SetCoords()
    {
        float x = xBoard;
        float y = yBoard;

        x *= 0.66f;
        y *= 0.66f;

        x += -2.3f;
        y += -2.3f;
        
        this.transform.position = new Vector3(x, y, -1);
    }

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(chesspiece, new Vector3(0,0,-1), Quaternion.identity);
    }


    
}
