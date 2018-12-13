def SumDigits(x)
  sum = 0
  while(x>0) 
    m=x % 10  
    sum= sum + m  
    x= x/10
  end
  return sum
end
print "What is the number: "
number = gets.chomp.to_i
puts "Sum of digits is #{SumDigits(number)}"