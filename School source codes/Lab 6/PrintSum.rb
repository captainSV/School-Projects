print "You entered: "
countingnum = gets.chomp.to_i
sum = 0
x = 1
if (countingnum < 0 || countingnum > 100)
  puts "Invalid input. Try again."
else 
  while (x <= countingnum) 
    sum += x
    x += 1
  end
end
puts "Sum of values: #{sum}"