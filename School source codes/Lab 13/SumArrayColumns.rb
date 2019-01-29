def GetSum(y)
  sum, count, counter = 0,0,0
  x = Array.new
  while (counter < 4)
    while (count < 3)
      sum += y[count][counter]
      count += 1
    end
    x << sum
    sum, count = 0,0
    counter += 1
  end
  return x
end
Arr1 = Array.new(3) { Array.new(4)}
count,counter,test = 0,0,0
puts "What are the array values: "
#Random rnd = new Random(Guid.NewGuid().GetHashCode()/13246);
while (count < 3)
  test = gets.chomp.to_i
  Arr1[count][counter] = test
  counter += 1
  if (counter == 4)
    counter = 0
    count += 1
  end
end
puts "Original Array: "
Arr1.each { |x| puts x.join(" ") }
blegh = GetSum(Arr1)
puts blegh
blegh.each { |x| puts "Sum of column #{blegh.index(x)} is #{x}" }