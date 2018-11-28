class Rectangle
  def initialize(height,width)
    @height,@width = height,width
  end
  def height
    @height
  end
  def width
    @width
  end
  def setheight(double)
    @height = double
  end
  def setwidth(double)
    @width = double
  end
  def area
    @height*@width
  end
  def perimeter
    (@height*2)+(@width*2)
  end
end
a = Rectangle.new(1,5)
b = Rectangle.new(5,1)
#a.setheight(5)
#a.setwidth(6)
#b.setheight(2)
#b.setwidth(8)
puts "First rectangle area #{a.area}"
puts "First rectangle perimeter #{a.perimeter}"
puts "Second rectangle area #{b.area}"
puts "Second rectangle perimeter #{b.perimeter}"
