print "Entered Value: "
input = gets.chomp.to_i
while (input >= 20 && input <= 60)
  sum = 0
  count = 2
  while (count <= input) 
    sum += count;
    count += 2
  end
  puts "Sum of even numbers between 2 and #{input} is #{sum}"
  print "Entered Value: "
  input = gets.chomp.to_i
end
puts "Yo that's actually an invalid number for this program. Please try again."