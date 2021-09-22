using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inheritance 
public class Tank : Vehicle
{
  //Polymorphism
  public override float speed => 10f;
  //Polymorphism
  public override float turnSpeed => 30f;

}
