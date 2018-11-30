def Max(x,y,z) 
  k = Array[x,y,z]
  k.max
end
def Min (x,y,z)
  k = Array[x,y,z]
  k.min
end
def Avr (x,y,z)
    ((x+y+z)/3)
end

print "enter your numbers: "
zed = gets.chomp.to_i
zedd = gets.chomp.to_i
zeddd = gets.chomp.to_i
zedmax = Max(zed,zedd,zeddd)
zedmin = Min(zed,zedd,zeddd)
zedavr = Avr(zed,zedd,zeddd)
puts "You Entered: #{zed}, #{zedd}, #{zeddd}"
puts "Max valuee #{zedmax}"
puts "Min value: #{zedmin}"
puts "Average Value: #{zedavr}"