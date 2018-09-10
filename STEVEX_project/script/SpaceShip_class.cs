using UnityEngine;
using System.Collections;

public class SpaceShip
{
    private float speed;
    private String name;
    private Color color;
 	

    
    
    public float getSpeed (){return speed;}
    public void setSpeed (float s){speed = s;}
    public String getName (){return speed;}
    public void setName (String n){name = n;}

    private void OfficeSort (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}