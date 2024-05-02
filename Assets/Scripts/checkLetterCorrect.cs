using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkLetterCorrect : MonoBehaviour
{
    public GameObject letterTile;
    public GameObject dots;
    public GameObject baseTile;

    public GameObject Letter;

    public GameObject dot1;
    public GameObject dot2;
    public GameObject dot3;
    public GameObject dot4;
    public GameObject dot5;
    public GameObject dot6;

    public Material[] material;

    // Start is called before the first frame update
    void Start()
    {
        dots.SetActive(true);
        baseTile.SetActive(true);
        letterTile.SetActive(false);
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log("OnTriggerEnter called");
    //     if (other.gameObject.CompareTag("hand"))
    //     {
    //         dots.SetActive(true);
    //         baseTile.SetActive(true);
    //         letterTile.SetActive(false);
    //     }
        
    // }

    // Update is called once per frame
    void Update()
    {
        string dotOne = dot1.GetComponent<MeshRenderer>().material.name;
        string dotTwo = dot2.GetComponent<MeshRenderer>().material.name;
        string dotThree = dot3.GetComponent<MeshRenderer>().material.name;
        string dotFour = dot4.GetComponent<MeshRenderer>().material.name;
        string dotFive = dot5.GetComponent<MeshRenderer>().material.name;
        string dotSix = dot6.GetComponent<MeshRenderer>().material.name;
        
        string[] solution = new string[6];
        
        if (Letter.name == "Letter 1") {  //O
            solution = new string[] { "B", "W", "W", "B", "B", "W"};
        } else if (Letter.name == "Letter 2") {  //U
            solution = new string[] { "B", "W", "W", "W", "B", "B"};
        } else if (Letter.name == "Letter 3") {  //T
            solution = new string[] { "W", "B", "B", "B", "B", "W"};
        }

        if (dotOne.Contains(solution[0]) && dotTwo.Contains(solution[1]) && dotThree.Contains(solution[2]) && dotFour.Contains(solution[3]) && dotFive.Contains(solution[4]) && dotSix.Contains(solution[5])) {
            dots.SetActive(false);
            baseTile.SetActive(false);
            letterTile.SetActive(true);
        }
        
    }
}
