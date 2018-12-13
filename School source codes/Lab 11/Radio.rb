class Radio
  def initialize()
    @station,@volume,@turnton = 1,1,false
  end
  def turnOn
    @turnton = true
  end
  def turnOff
    @turnton = false
  end
  def GetStation
    @station
  end
  def GetVolume
    @station
  end
  def StationUp(x = 1)
    @station += x
  end
  def StationDown(x = 1)
    @station -= x
  end
  def VolumeUp(x = 1)
    @volume += x
  end
  def VolumeDown(x = 1)
    @volume -= x
  end
  def to_s
    if (@turnton == false)
      "The radio is off."
    else 
      "The radio station is #{@station} and the volume level is #{@volume}."
    end
  end
end
test = Radio.new
test.turnOn
puts test
test.VolumeUp(3)
puts test
test.StationUp(5)
puts test
test.VolumeDown
puts test
test.StationUp(3)
puts test
test.turnOff
puts test
test.VolumeUp(2)
puts test
test.StationDown(2)
puts test