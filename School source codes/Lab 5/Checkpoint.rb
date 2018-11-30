puts "X coordinate is: "
xvalue = gets.chomp.to_i
puts "Y coordinate is: "
yvalue = gets.chomp.to_i
if (xvalue == 0) 
  if (yvalue == 0)
    puts "(#{xvalue},#{yvalue}) is the origin point"
  else
    puts "(#{xvalue},#{yvalue}) is on the Y Axis"
  end
elsif (xvalue > 0) 
  if (yvalue == 0)
    puts "(#{xvalue},#{yvalue}) is on the X Axis"
  elsif (yvalue > 0)
    puts "(#{xvalue},#{yvalue}) is in the first quadrant"
  else
    puts "(#{xvalue},#{yvalue}) is in the fourth quadrant"
  end
else
  if (yvalue == 0)
    puts "(#{xvalue},#{yvalue}) is on the X Axis"
  elsif (yvalue > 0)
    puts "(#{xvalue},#{yvalue}) is in the second quadrant"
  else 
    puts "(#{xvalue},#{yvalue}) is in the third quadrant"
  end
end