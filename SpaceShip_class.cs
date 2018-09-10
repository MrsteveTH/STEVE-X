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
    public Color getColor (){return color;}
    public void setColor (Color c){name = n;}

  	public downSpeed(float x){
  		speed -= x;
  	}

  	public increaseSpeed(float x){
  		speed += x;
  	}

  	
}