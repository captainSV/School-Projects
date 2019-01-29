def Addition(y, x)
  p = Array.new(3) {Array.new(3)}
  z = 0
  c = 0
  p.each do |n|
    n.each do |s|
      b = y[z][c] + x[z][c]
      p[z][c] = b
      c += 1
    end
    z += 1
    c = 0
  end
end
Arr1 = Array.new(3) { Array.new(3)}
Arr2 = Array.new(3) { Array.new(3)}
count = 0
counter = 0
print "What are the first array values: "
while (count < 3)
  test = gets.chomp.to_i
  Arr1[count][counter] = test
  counter += 1
  if (counter == 3) 
    counter = 0
    count += 1
  end
end
count = 0
counter = 0
print "what is the values for array 2: "
while (count < 3)
  test = gets.chomp.to_i
  Arr2[count][counter] = test
  counter += 1
  if (counter == 3) 
    counter = 0
    count += 1
  end
end
print "Array1: "
Arr1.each do |a|
  a.each do |int|
    print  "#{int}, "
  end
end
print "\nArray2: "
Arr2.each do |a|
  a.each do |int|
    print  "#{int}, "
  end
end
Arr3 = Addition(Arr1,Arr2)
print "\nArray3: "
Arr3.each do |a|
  a.each do |int|
    print  "#{int}, "
  end
end