def Compare(x, y)
  if (x == y) then true else false end
end
count1 = 0
count2 = 0
print "What is the array size: "
size = gets.chomp.to_i
Arr1 = Array.new(size)
Arr2 = Array.new(size)
print "Enter the numbers for array 1: "
while (count1 < size)
  Arr1 << gets.chomp.to_i
  count1 += 1
end
print "Enter the numbers for array 2: "
while (count2 < size)
  Arr2 << gets.chomp.to_i
  count2 += 1
end
if (Compare(Arr1,Arr2) == false)
  puts "The arrays are not identical."
else
  puts "The arrays are identical."
end