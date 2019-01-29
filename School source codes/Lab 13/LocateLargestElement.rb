def LocateLargest(y)
  largestX,largestY = 0,0
  largest = y[0][0]
  x = Array.new(3)
  y.each { |sub| sub.each { |ssub|
    if(ssub > largest) then largestX,largestY,largest = y.index(sub),sub.index(ssub),ssub end }}
  x[0] = largestX
  x[1] = largestY
  return x
end
Arr1 = Array.new(3) { Array.new(4)}
blegh = Array.new(2)
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
puts ""
blegh = LocateLargest(Arr1)
puts "First largest value is located at row #{blegh[0]} and at column #{blegh[1]}"