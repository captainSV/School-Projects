class Circle
  attr_accessor :radius
  def initialize(args={})
    @radius = args.fetch(:radius, 1)
  end
  def SetRadius(a)
    @radius = a
  end
  def GetRadius
    @radius
  end
  def GetArea
    return ((radius*radius)*Math::PI)
  end
  def GetPerimeter
    return (Math::PI*2*radius)
  end
  def to_s
    "The circle has radius #{@radius}"
  end
end
test = Circle.new
puts test
puts "Area is: #{test.GetArea}"
puts "Perimeter is: #{test.GetPerimeter}"
test.SetRadius(5)
puts "\n"
puts test
puts "Area is: #{test.GetArea}"
puts "Perimeter is: #{test.GetPerimeter}"