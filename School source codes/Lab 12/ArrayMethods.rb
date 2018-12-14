def ArrayMax(x)
  x.max
end
def ArrayMin(x)
  x.min
end
def ArraySquared(x)
  x.map! {|n| n **2}
end
def ArrayReverse(x)
  x.reverse!
end
count = 0
puts "What is the array size: "
size = gets.chomp.to_i
Arr1 = Array.new(size)
puts "Enter the numbers for the array: "
while (count < size)
  test = gets.chomp.to_i
  Arr1[count] = test
  count += 1
end
print "Original Array: "
print Arr1.join(' ')
puts "\n"
puts "Array Miximum: #{ArrayMax(Arr1)}"
puts "Array Minimum: #{ArrayMin(Arr1)}"
print "Array Squared: "
ArraySquared(Arr1)
print Arr1.join(" ")
puts "\n"
print "Array Reversed: "
ArrayReverse(Arr1)
print Arr1.join(" ")