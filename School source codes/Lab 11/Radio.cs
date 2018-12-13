using System;
using System.Collections.Generic;
using System.Linq;

public class Radio {
  private int station {get;set;}
  private int volume {get;set;}
  private bool turnton {get;set;}
  public Radio(){
    station = 1;
    volume = 1;
    turnton= false;
  }
  public void turnOn()
    {turnton = true;}
  public void turnOff()
    {turnton = false;}

  public int GetStation()
    {return station;}
  public int GetVolume()
    {return volume;}
  public void StationUp()
    {station++;}
    public void StationUp(int x)
    {station = station + x;}
  public void StationDown()
    {station--;}
  public void StationDown(int x)
    {station = station - x;}
  public void VolumeUp()
    {volume++;}
  public void VolumeUp(int x)
    {volume = volume + x;}
  public void VolumeDown()
    {volume--;}
  public void VolumeDown(int x)
    {volume = volume - x;}

  public override string ToString() {
    if (turnton == false)
      {return "The radio is off.";}
    return "The radio station is " + station + " and the volume level is " + volume + ".";
  }
}

class MainClass {
  public static void Main() {
    Radio test = new Radio();
    test.turnOn();
    Console.WriteLine(test);
    test.VolumeUp(3);
    Console.WriteLine(test);
    test.StationUp(5)
    Console.WriteLine(test);
    test.VolumeDown();
    Console.WriteLine(test);
    test.StationUp(3);
    Console.WriteLine(test);
    test.turnOff();
    Console.WriteLine(test);
    test.VolumeUp(2);
    Console.WriteLine(test);
    test.StationDown(2);
    Console.WriteLine(test);
  }
}