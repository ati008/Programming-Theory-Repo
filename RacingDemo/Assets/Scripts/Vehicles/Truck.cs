using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inheritance 
public class Truck : Vehicle
{
  //Polymorphism
  public override float speed => 15f;
  //Polymorphism
  public override float turnSpeed => 40f;

}
