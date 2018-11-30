def SquareArea(x)
  k = x * x
end
def RectArea(x,y)
  k = x * y
end
def CircleArea(x)
  k = ((Math::PI) * ( x * x))
end
def TriArea(x, y)
  k = (x * y ) / 2
end
print "enter your square side length: "
square = gets.chomp.to_i
puts "Square's area: #{SquareArea(square)}"
puts "\n"
print "enter your rectangle side width: "
rect1 = gets.chomp.to_i
print "enter your rectangle side height: "
rect2 = gets.chomp.to_i
puts "Rectangles area: #{RectArea(rect1,rect2)}"
puts "\n"
print "enter your circle radius: "
circle = gets.chomp.to_i
puts "Circle's area: #{CircleArea(circle)}"
puts "\n"
print "enter your triangle base: "
tri1 = gets.chomp.to_i
print "enter your triangle height: "
tri2 = gets.chomp.to_i
puts "Tirangle's area: #{TriArea(tri1,tri2)}"