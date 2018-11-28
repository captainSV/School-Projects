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